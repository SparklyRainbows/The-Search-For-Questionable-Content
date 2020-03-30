using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IE : MonoBehaviour
{
    public void OpenIE() {
        gameObject.SetActive(true);
    }

    public void CloseIE() {
        gameObject.SetActive(false);
    }
}
