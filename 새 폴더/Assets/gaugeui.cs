using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gaugeui : MonoBehaviour
{
    public GameObject Player;
    public float Height;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 size = GetComponent<RectTransform>().sizeDelta;
        size.y = Height *
            ((float)Player.GetComponent<Player>().Info.gauge /
              Player.GetComponent<Player>().Info.GetMaxGauge()) ;
        GetComponent<RectTransform>().sizeDelta = size;

    }
}
