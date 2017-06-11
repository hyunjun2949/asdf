using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour {
    public GameObject GameOver;
	void Update () {
        if(GameOver.activeSelf)
        { return; }



        transform.Translate(0.0f, -5.0f * Time.deltaTime, 0.0f);	}
}
