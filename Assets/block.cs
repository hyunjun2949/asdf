﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour {

    float time;
    public GameObject blo;
    float spawnTime;
    void Start ()
    {
        spawnTime = Random.Range(1.0f, 2.5f);

    }
    void Update () {

        time += Time.deltaTime;
        if (time >  spawnTime)
        {
            GameObject newblock=Instantiate(blo);
            newblock.transform.position = transform.position;
            time = 0;
            spawnTime = Random.Range(1.0f, 2.5f);
        }


	}
}
