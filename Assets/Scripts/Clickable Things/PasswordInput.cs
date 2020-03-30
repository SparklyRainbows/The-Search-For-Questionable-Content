using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordInput : MonoBehaviour
{
    public InputField mainInputField;
    public GameObject incorrectScreen;
    public GameObject notFPScreen;

    private void Start() {
        mainInputField.onEndEdit.AddListener(delegate { CheckPassword(mainInputField); });
    }

    public void CheckPassword(InputField input) {
        if (GameManager.instance.CorrectPassword(input.text)) {
            notFPScreen.SetActive(true);
            gameObject.SetActive(false);
        } else {
            IncorrectPassword();
        }
    }

    private void IncorrectPassword() {
        incorrectScreen.SetActive(true);
    }

    public void CloseIncorrectPassword() {
        mainInputField.text = "";
        incorrectScreen.SetActive(false);
        gameObject.SetActive(false);
    }

    public void Close() {
        mainInputField.text = "";
        incorrectScreen.SetActive(false);
        gameObject.SetActive(false);
    }
}
