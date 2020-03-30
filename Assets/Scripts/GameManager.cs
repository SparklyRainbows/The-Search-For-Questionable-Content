using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Instance
    public static GameManager instance = null;

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else {
            Destroy(this);
        }
    }
    #endregion

    [SerializeField]
    public Stack<GameObject> history = new Stack<GameObject>();

    public bool firewallDisabled = false;

    public Note noteScript;

    public bool foundSecondKey = false;

    public GameObject flower;
    public bool hasFlower = false;

    public GameObject clippy;
    public bool hasClippy = false;

    public GameObject key;
    public bool hasKey = false;

    public GameObject bomb;
    public bool hasBomb = false;

    public GameObject virus;
    public bool hasVirus = false;

    public GameObject datingSim;
    public DialogueManager dialogue;

    public int keysFound = 0;
    public bool canUnlockFP = false;
    public bool hasUnlockedFP = false;

    private string password = "i0g4wdPu2E";

    #region history
    public void DeleteHistory() {
        history = new Stack<GameObject>();
    }

    public void AddHistory(GameObject next) {
        if (HasMoreHistory() && history.Peek() == next) {
            return;
        }

        history.Push(next);
    }

    public bool HasMoreHistory() {
        return history.Count > 0;
    }

    public GameObject GetPreviousScreen() {
        if (HasMoreHistory()) {
            return history.Pop();
        }
        return null;
    }
    #endregion

    public void WinGame() {
        SceneManager.LoadScene("Win");
    }

    public bool CorrectPassword(string pass) {
        hasUnlockedFP = pass.Equals(password) && keysFound == 2;
        return hasUnlockedFP;
    }

    #region keys and items
    public void FindFirstKey() {
        if (noteScript.foundFirst) {
            return;
        }

        keysFound++;
        noteScript.ShowFirstKey();
    }

    public void FindSecondKey() {
        if (noteScript.foundSecond) {
            return;
        }

        foundSecondKey = true;
        keysFound++;
        noteScript.ShowSecondKey();
    }

    public void HasClippy() {
        hasClippy = true;
        clippy.SetActive(true);
    }

    public void HasFlower() {
        hasFlower = true;
        flower.SetActive(true);
    }

    public void HasKey() {
        hasKey = true;
        key.SetActive(true);
    }

    public void HasBomb() {
        hasBomb = true;
        bomb.SetActive(true);
    }

    public void HasVirus() {
        hasVirus = true;
        virus.SetActive(true);
    }
    #endregion

    public void StartClippySeduction() {
        datingSim.SetActive(true);
    }

}
