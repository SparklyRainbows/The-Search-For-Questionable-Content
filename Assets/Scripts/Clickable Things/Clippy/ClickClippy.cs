using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickClippy : MonoBehaviour {

    public void Click() {
        if (GameManager.instance.hasFlower && !GameManager.instance.hasClippy && GameManager.instance.hasUnlockedFP) {
            gameObject.SetActive(false);
            GameManager.instance.StartClippySeduction();
        }
    }
}
