using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {

    float time;
    public int score1;
    public GameObject GameOver;
    
	void Update ()
    {
        if(GameOver.activeSelf)
        {
            return;
        }

        if (time > 1.0f)

        {
            score1 += 1;
            time = 0;
        }
        time += Time.deltaTime;

        
	}
}
