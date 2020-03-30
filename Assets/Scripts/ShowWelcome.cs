using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowWelcome : MonoBehaviour
{
    public Image welcome;

    private void Start() {
        StartCoroutine(PlayWelcome());
    }

    private IEnumerator PlayWelcome() {
        while (welcome.color.a > 0) {
            Color temp = welcome.color;
            temp.a -= .1f;
            welcome.color = temp;

            yield return new WaitForSeconds(.1f);
        }
    }
}
