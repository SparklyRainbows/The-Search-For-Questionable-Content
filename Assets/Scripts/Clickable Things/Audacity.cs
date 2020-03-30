using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audacity : MonoBehaviour
{
    public GameObject errorMessage;

    public Sprite decryptedSprite;
    public Image wavelengthImage;

    public void Decrypt() {
        wavelengthImage.sprite = decryptedSprite;
        GameManager.instance.FindSecondKey();
    }

    public void OpenAudacity() {
        errorMessage.SetActive(false);
        gameObject.SetActive(true);
    }

    public void CloseAudacity() {
        gameObject.SetActive(false);
    }
}
