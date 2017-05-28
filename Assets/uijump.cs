using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uijump : MonoBehaviour {
    public GameObject ball;
    public void click()
    {
        ball.GetComponent<balljump>().state = State.jump;
    }
}
