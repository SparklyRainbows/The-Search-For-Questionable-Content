using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSGO : MonoBehaviour
{
    public GameObject screenshots;

    public void Close() {
        GameManager.instance.DeleteHistory();
        gameObject.SetActive(false);
    }

    public void Screenshots() {
        GameManager.instance.AddHistory(gameObject);
        screenshots.SetActive(true);
        gameObject.SetActive(false);
    }
}
