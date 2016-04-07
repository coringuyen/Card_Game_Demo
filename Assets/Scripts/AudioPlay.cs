using UnityEngine;
using System.Collections;

public class AudioPlay
{
    static public AudioSource manager;
    static public AudioClip shuffle;
    static public AudioClip win;
    static public AudioClip button_click;
    static public AudioClip draw_card;
    static public AudioClip card_flip;
    static public AudioClip hover_on_card;

    static public void Shuffle()
    {
        manager.volume = 1;
        manager.clip = shuffle;
        manager.Play();
    }

    static public void Win()
    {
        manager.clip = win;
        manager.volume = 0.3f;
        manager.Play();
    }

    static public void CardFlip()
    {
        manager.volume = 1;
        manager.clip = card_flip;
        manager.Play();
    }

    static public void HoverOnCard()
    {
        manager.volume = 1;
        manager.clip = hover_on_card;
        manager.Play();
    }

    static public void DrawCard()
    {
        manager.volume = 1;
        manager.clip = draw_card;
        manager.Play();
    }

    public void ButtonClick()
    {
        manager.volume = 1;
        manager.clip = button_click;
        manager.Play();
    }
}
