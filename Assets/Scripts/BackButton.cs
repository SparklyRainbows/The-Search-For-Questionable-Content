using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public Sprite disabled;

    public Image image;
    public Button button;

    private void OnEnable() {
        if (!GameManager.instance.HasMoreHistory()) {
            image.sprite = disabled;
            button.interactable = false;
        }
    }

    public void Click() {
        GameObject prev = GameManager.instance.GetPreviousScreen();
        prev.SetActive(true);
        transform.parent.gameObject.SetActive(false);
    }
}
