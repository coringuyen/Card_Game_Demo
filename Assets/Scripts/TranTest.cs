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
            AudioPlay.Win();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            AudioPlay.Shuffle();
        }
    }
}
