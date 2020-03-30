using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteFlower : MonoBehaviour
{
    public DialogueManager dialogue;

    public void GiveToClippy() {
        dialogue.StartSeductionDialogue();

        Destroy(gameObject);
    }
}
