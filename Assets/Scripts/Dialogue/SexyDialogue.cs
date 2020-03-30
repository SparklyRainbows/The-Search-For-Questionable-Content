using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SexyDialogue : MonoBehaviour
{
    public Text textbox;

    private DialogueManager manager;

    private void Start() {
        manager = GetComponent<DialogueManager>();
    }

    public void DisplayText(string text) {
        textbox.text = "";
        StartCoroutine(DisplayTextEnum(text));
    }

    private IEnumerator DisplayTextEnum(string text) {
        string str = "";
        foreach (char c in text) {
            str += c;
            textbox.text = str;

            yield return new WaitForSeconds(.01f);
        }

        manager.CanAdvance();
    }
}
