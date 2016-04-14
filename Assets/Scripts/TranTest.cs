using UnityEngine;
using System.Collections;

public class TranTest: MonoBehaviour {
    
	void Start ()
    {

	}

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Tran.AudioPlay.Shuffle();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Tran.AudioPlay.Win();
        }
    }
}
