﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leveldisplay : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<UnityEngine.UI.Text>().text =
        player.GetComponent<Player>().Info.level.ToString();
	}
}
