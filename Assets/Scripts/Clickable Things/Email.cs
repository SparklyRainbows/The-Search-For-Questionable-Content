using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Email : MonoBehaviour
{
    public GameObject flower;
    public GameObject emails;
    public GameObject spam;

    public void OpenEmail() {
        
        gameObject.SetActive(true);
        spam.SetActive(false);
    }

    public void ClickDeletedItems() {
        if (flower != null) {
            flower.SetActive(true);
        }
        spam.SetActive(true);
        emails.SetActive(false);
    }

    public void CloseEmail() {
        spam.SetActive(false);
        emails.SetActive(true);

        gameObject.SetActive(false);

        if (flower != null) {
            flower.SetActive(false);
        }
    }

    public void CollectFlower() {
        if (flower != null) {
            GameManager.instance.HasFlower();
            Destroy(flower);
        }
    }
}
