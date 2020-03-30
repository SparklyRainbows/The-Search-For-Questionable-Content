using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recent : MonoBehaviour
{
    public GameObject locked;
    public GameObject textFile;
    public Text textFileText;
    public GameObject ClippyText;

    public bool fileLocked = true;

    public void OpenFile() {
        if (fileLocked) {
            locked.SetActive(true);
        } else {
            textFile.SetActive(true);
        }
    }

    public void DecryptText(GameObject virus) {
        if (textFile.activeInHierarchy) {
            virus.SetActive(false);
            textFileText.text = "i0g4w";
            GameManager.instance.FindFirstKey();
            ClippyText.GetComponent<ClippyHints>().TryIndex(9);
        }
    }

    public void UnlockFile(GameObject key) {
        if (locked.activeInHierarchy) {
            key.SetActive(false);
            fileLocked = false;
            CloseLockedMessage();
            OpenFile();
            ClippyText.GetComponent<ClippyHints>().TryIndex(6);
        }
    }

    public void CloseText() {
        textFile.SetActive(false);
    }

    public void Close() {
        GameManager.instance.DeleteHistory();
        gameObject.SetActive(false);
    }

    public void CloseLockedMessage() {
        locked.SetActive(false);
    }
}
