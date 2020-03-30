using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClippyHints : MonoBehaviour
{
    [TextArea]
    [SerializeField]
    public string[] dialogue;

    public int index = 0;
    private bool dialogueStarted = false;
    private bool canAdvance = false;

    private Transform YesButton;
    private Text ButtonText;

    private bool dialogueFinished = false;

    private Dialogue textbox;

    private void Start()
    {
        textbox = GetComponent<Dialogue>();
        YesButton = this.transform.GetChild(1);
        ButtonText = YesButton.GetChild(0).GetComponent<Text>();

        StartDialogue();
    }

    public void StartDialogue()
    {
        dialogueStarted = true;
        NextLine();
    }

    public void TryNext()
    {
        if ( index > 1 && canAdvance == false)
        {
            YesButton.gameObject.SetActive(false);
            canAdvance = true;
            gameObject.SetActive(false);
        }
        
        else if (canAdvance && dialogueStarted)
        {
            NextLine();
            YesButton.gameObject.SetActive(false);
        }
    }

    public void TryIndex(int indexGiven)
    {
        canAdvance = true;
        index = indexGiven;
        if (canAdvance) {
            gameObject.SetActive(true);
            YesButton.gameObject.SetActive(false);
            NextLine();
        }
    }

    private void NextLine()
    {
        textbox.DisplayText(dialogue[index]);
        index++;
        canAdvance = false;

        if (index == dialogue.Length)
        {
            canAdvance = false;
            dialogueStarted = false;
        }
    }

    public void CanAdvance()
    {
        canAdvance = true;
        YesButton.gameObject.SetActive(true);
        if (index == 1) {
        }
        if (index == 2) {

            ButtonText.text = "Close";
            canAdvance = false;
        }
        if (index == 3 || index == 5 || index == 7 || index == 11) {
            ButtonText.text = "Close";
            canAdvance = false;
        }
        if (index == 4 || index == 6 || index == 8 || index == 9 || index == 10)
        {
            ButtonText.text = "Thanks!";
            canAdvance = false;
        }
    }

}
