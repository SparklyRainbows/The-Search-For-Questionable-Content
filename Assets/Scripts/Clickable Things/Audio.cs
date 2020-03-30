using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public GameObject error;
    public GameObject audacity;

    public void OpenFile() {
        if (GameManager.instance.foundSecondKey) {
            audacity.SetActive(true);
        } else {
            ShowError();
        }
    }

    public void ShowError() {
        error.SetActive(true);
    }

    public void CloseError() {
        error.SetActive(false);
    }
}
