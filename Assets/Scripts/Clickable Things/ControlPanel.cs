using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPanel : MonoBehaviour
{
    public Sprite brokenFirewall;
    public Image firewallImage;
    public GameObject firewall;
    public GameObject ClippyText;

    public void Open() {
        gameObject.SetActive(true);
    }

    public void Close() {
        GameManager.instance.DeleteHistory();
        gameObject.SetActive(false);
    }

    public void DestroyFirewall(GameObject bomb) {
        if (firewall.activeInHierarchy) {
            bomb.SetActive(false);
            firewallImage.sprite = brokenFirewall;
            GameManager.instance.firewallDisabled = true;
            ClippyText.GetComponent<ClippyHints>().TryIndex(8);
        }
    }
}
