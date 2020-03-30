using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceBar : MonoBehaviour
{
    public GameObject spacebarObj;
    public Text spacebar;

    private void Start() {
        StartCoroutine(Flash());
    }

    private IEnumerator Flash() {
        while (true) {
            while (spacebar.color.a < 1) {
                Color temp = spacebar.color;
                temp.a += .1f;
                spacebar.color = temp;
                yield return new WaitForSeconds(.1f);
            }
            while (spacebar.color.a > 0) {
                Color temp = spacebar.color;
                temp.a -= .1f;
                spacebar.color = temp;
                yield return new WaitForSeconds(.1f);
            }
        }
    }

    public void HideSpacebar() {
        spacebarObj.SetActive(false);
    }

    public void ShowSpacebar() {
        spacebarObj.SetActive(true);
    }
}
