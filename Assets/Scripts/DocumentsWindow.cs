using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocumentsWindow : MonoBehaviour
{
    public GameObject DWindow;
    public GameObject WorkWindow;
    public GameObject TopSecret;
    public GameObject AudioWindow;
    public GameObject RecentFiles;
    public GameObject Images;
    public GameObject CSGO;

    public void SwitchToCS() {
        GameManager.instance.AddHistory(DWindow);
        CSGO.SetActive(true);
        DWindow.SetActive(false);
    }

    public void SwitchToRecent(GameObject source) {
        GameManager.instance.AddHistory(source);
        source.SetActive(false);
        RecentFiles.SetActive(true);
    }

    public void SwitchToImages() {
        GameManager.instance.AddHistory(DWindow);
        Images.SetActive(true);
        DWindow.SetActive(false);
    }

    public void SwitchToAudio() {
        GameManager.instance.AddHistory(DWindow);
        AudioWindow.SetActive(true);
        DWindow.SetActive(false);
    }

    public void CloseAudio() {
        GameManager.instance.DeleteHistory();
        AudioWindow.SetActive(false);
    }

    public void OpenDocuments() {
        DWindow.SetActive(true);
    }

    public void CloseDocuments() {
        GameManager.instance.DeleteHistory();
        DWindow.SetActive(false);
    }

    public void SwitchToWorkStuff() {
        GameManager.instance.AddHistory(DWindow);
        DWindow.SetActive(false);
        WorkWindow.SetActive(true);
    }

    public void SwitchToTopSecret() {
        GameManager.instance.AddHistory(WorkWindow);
        WorkWindow.SetActive(false);
        TopSecret.SetActive(true);
    }

    public void CloseWorkWindow() {
        GameManager.instance.DeleteHistory();
        WorkWindow.SetActive(false);
    }

    public void CloseTopSecret() {
        GameManager.instance.DeleteHistory();
        TopSecret.SetActive(false);
    }
}
