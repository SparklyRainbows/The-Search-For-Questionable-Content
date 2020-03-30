using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trojan : MonoBehaviour
{
    public GameObject trojanExe;
    public GameObject error;
    public GameObject success;

    public void OpenTrojan() {
        gameObject.SetActive(true);
        if (GameManager.instance.firewallDisabled) {
            ShowSuccess();
        } else {
            ShowError();
        }
    }

    public void ShowError() {
        error.SetActive(true);
    }

    public void ShowSuccess() {
        trojanExe.SetActive(false);
        GameManager.instance.HasVirus();
        success.SetActive(true);
    }

    public void CloseError() {
        error.SetActive(false);
        gameObject.SetActive(false);
    }

    public void CloseSuccess() {
        success.SetActive(false);
        gameObject.SetActive(false);
    }
}
