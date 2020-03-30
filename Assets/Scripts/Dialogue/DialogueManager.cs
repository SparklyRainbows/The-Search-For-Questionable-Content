using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueObject;

    public GameObject flower;

    [TextArea]
    [SerializeField]
    public string[] dialogue;

    [TextArea]
    [SerializeField]
    public string[] seducedDialogue;

    private int index = 0;
    private bool dialogueStarted = false;
    private bool canAdvance = false;

    private int seducedIndex = 0;
    private bool seducedDialogueStarted = false;
    private bool dialogueFinished = false;

    private SexyDialogue textbox;

    private SpaceBar spacebar;

    private void Start() {
        textbox = GetComponent<SexyDialogue>();
        spacebar = GetComponent<SpaceBar>();

        StartDialogue();
    }

    public void StartDialogue() {
        dialogueStarted = true;
        NextLine();
    }

    public void StartSeductionDialogue() {
        seducedDialogueStarted = true;
        SeducedNextLine();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (canAdvance && dialogueStarted) {
                NextLine();
            } else if (canAdvance && seducedDialogueStarted) {
                SeducedNextLine();
            } else if (dialogueFinished) {
                GameManager.instance.HasClippy();
                dialogueObject.SetActive(false);
            }
        }
    }

    private void NextLine() {
        spacebar.HideSpacebar();

        textbox.DisplayText(dialogue[index]);
        index++;
        canAdvance = false;

        if (index == dialogue.Length) {
            canAdvance = false;
            dialogueStarted = false;

            flower.GetComponent<Button>().interactable = true;
        }
    }

    public void CanAdvance() {
        spacebar.ShowSpacebar();
        canAdvance = true;
    }

    private void SeducedNextLine() {
        textbox.DisplayText(seducedDialogue[seducedIndex]);
        seducedIndex++;
        canAdvance = false;

        if (seducedIndex == seducedDialogue.Length) {
            canAdvance = false;
            seducedDialogueStarted = false;
            dialogueFinished = true;
        }
    }
}
