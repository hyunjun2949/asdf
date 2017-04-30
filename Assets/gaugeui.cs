using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gaugeui : MonoBehaviour
{
    public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 size = GetComponent<RectTransform>().sizeDelta;
        size.x = Player.GetComponent<Player>().Info.gauge;
        GetComponent<RectTransform>().sizeDelta = size;

    }
}
