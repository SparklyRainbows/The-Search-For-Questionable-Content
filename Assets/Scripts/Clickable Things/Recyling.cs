using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recyling : MonoBehaviour
{
    public GameObject trojan;
    public GameObject restoreMessage;

    public GameObject restoredTrojan;

    public void Open() {
        gameObject.SetActive(true);
    }

    public void Close() {
        GameManager.instance.DeleteHistory();
        gameObject.SetActive(false);
    }

    public void ShowRestoreMessage() {
        restoreMessage.SetActive(true);
    }

    public void HideRestoreMessage() {
        restoreMessage.SetActive(false);
    }

    public void Restore() {
        HideRestoreMessage();
        restoredTrojan.SetActive(true);
        Destroy(trojan);
    }
}
