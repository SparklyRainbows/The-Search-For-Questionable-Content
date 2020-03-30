using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public GameObject first;
    public GameObject second;

    public bool foundFirst = false;
    public bool foundSecond = false;

    public void ShowFirstKey() {
        foundFirst = true;
        first.SetActive(true);
    }

    public void ShowSecondKey() {
        foundSecond = true;
        second.SetActive(true);
    }
}
