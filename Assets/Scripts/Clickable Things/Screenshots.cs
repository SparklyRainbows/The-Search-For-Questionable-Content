using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screenshots : MonoBehaviour
{
    public Sprite screenshotNoBomb;

    public GameObject screenshotImage;
    public GameObject bombImage;

    public void OpenImage() {
        screenshotImage.SetActive(true);
    }

    public void TakeBomb() {
        if (bombImage != null) {
            Destroy(bombImage);
            screenshotImage.GetComponent<Image>().sprite = screenshotNoBomb;
            GameManager.instance.HasBomb();
        }
    }

    public void CloseImage() {
        screenshotImage.SetActive(false);
    }

    public void Close() {
        GameManager.instance.DeleteHistory();
        gameObject.SetActive(false);
    }
}
