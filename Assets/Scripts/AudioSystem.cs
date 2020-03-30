using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSystem : MonoBehaviour
{
    public static AudioSystem instance = null;

    public AudioSource sfx;

    private void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(this);
        } else if (instance != this) {
            Destroy(gameObject);
        }
    }

    public void PlaySfx() {
        sfx.Play();
    }
}
