using UnityEngine;
using System.Collections;

public class GUIAudio : MonoBehaviour {

    public AudioSource manager;
    public AudioClip button_click;

    public void Button_Click()
    {
        manager.clip = button_click;
        manager.Play();
    }
}
