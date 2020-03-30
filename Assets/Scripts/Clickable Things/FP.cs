using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FP : MonoBehaviour
{
    public GameObject poorClippy;

    public GameObject notFPScreen;
    public GameObject passwordInput;
    public GameObject fileLocked;
    public GameObject ClippyText;

    public void OpenNotFP() {
        if (GameManager.instance.hasUnlockedFP) {
            notFPScreen.SetActive(true);
        } else {
            passwordInput.SetActive(true);
        }
    }

    public void CloseFP() {
        GameManager.instance.DeleteHistory();
        notFPScreen.SetActive(false);
    }

    public void ClickLockedFile() {
        fileLocked.SetActive(true);
    }

    public void CloseLockedError() {
        fileLocked.SetActive(false);

        if (poorClippy == null || !poorClippy.activeInHierarchy) {
            return;
        }

        ClippyText.GetComponent<ClippyHints>().TryIndex(10);
    }

    public void UseClippyToUnlock() {
        if (fileLocked.activeInHierarchy) {
            GameManager.instance.WinGame();
        }
    }
}
