using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class TakeTurn : MonoBehaviour
{

    [SerializeField]
    private enum takeTurn { Dealer, Player };
    takeTurn Turn = takeTurn.Dealer;


    List<string> player = new List<string>();
    string currentPlayer;
    int index;
    public float timer, delay;

    void Start()
    {
        player.Add("Player1");
        player.Add("Player2");
        player.Add("Player3");
        player.Add("Player4");

        index = 0;
        delay = 4f;
    }

    void Update()
    {
        currentPlayer = player[index];
        timer += Time.deltaTime;
        switch (Turn)
        {
            case takeTurn.Dealer:
                if (timer > delay)
                {
                    DrawCard("Dealer");
                    PlayCard();
                    Turn = takeTurn.Player;
                    timer = 0;
                }
                break;
            case takeTurn.Player: // current player
                if (timer > delay)
                {
                    DrawCard(currentPlayer);
                    PlayCard();

                    index++;
                    if (index > 3) { index = 0; }

                    // call resolve
                    // next player
                    Turn = takeTurn.Dealer;
                    timer = 0;
                }
                break;
        }
    }

    // put a card in hand
    void DrawCard(string name)
    {
        print(name.ToString() + " Draw card");
    }

    // put the card they pick in either bad guy or good guy list
    void PlayCard()
    {
        if (Turn.ToString() == "Dealer")
            print("Bad guy list");
        else
            print("Good guy list");
    }
}
