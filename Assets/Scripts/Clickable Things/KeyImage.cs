using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyImage : MonoBehaviour
{
    public Sprite noKeyImage;

    public GameObject keyImage;
    public GameObject actualKeyThing;

    public GameObject ClippyObject;

    public void TakeKey() {
        if (actualKeyThing != null) {
            Destroy(actualKeyThing);
            keyImage.GetComponent<Image>().sprite = noKeyImage;
            GameManager.instance.HasKey();
            ClippyObject.GetComponent<ClippyHints>().TryIndex(5);

        }
    }

    public void ShowImage() {
        keyImage.SetActive(true);
    }

    public void HideImage() {
        keyImage.SetActive(false);
    }

    public void Close() {
        GameManager.instance.DeleteHistory();
        gameObject.SetActive(false);
    }
}
