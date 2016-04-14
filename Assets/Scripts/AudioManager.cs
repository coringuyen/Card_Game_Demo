using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour
{
    public AudioSource audio_manager;
    public AudioClip shuffle;
    public AudioClip win;
    public AudioClip draw_card;
    public AudioClip card_flip;

    void Start()
    {
        Tran.AudioPlay.manager = audio_manager;
        Tran.AudioPlay.shuffle = shuffle;
        Tran.AudioPlay.win = win;
        Tran.AudioPlay.draw_card = draw_card;
        Tran.AudioPlay.card_flip = card_flip;
    }
}
