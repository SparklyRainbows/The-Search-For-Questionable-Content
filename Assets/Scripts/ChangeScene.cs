using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public Text username;
    public Image welcome;

    private bool playingWelcome;

    private void Start() {
        if (username != null) {
            username.text = System.Environment.UserName;
        }
    }

    public void Play() {
        if (playingWelcome) {
            return;
        }

        GameObject.Find("Audio").GetComponent<AudioSystem>().PlaySfx();

        StartCoroutine(PlayWelcome());
    }

    private IEnumerator PlayWelcome() {
        playingWelcome = true;

        while (welcome.color.a < 1) {
            Color temp = welcome.color;
            temp.a += .1f;
            welcome.color = temp;

            yield return new WaitForSeconds(.1f);
        }

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Jasmine");
    }

    public void BackToMenu() {
        SceneManager.LoadScene("Menu");
    }

    public void Quit() {
        if (playingWelcome) {
            return;
        }

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
              Application.Quit();
        #endif
    }
}
