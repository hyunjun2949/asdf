using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoretext : MonoBehaviour {

	void Update () {
        GetComponent<UnityEngine.UI.Text>().text
           = GetComponent<score>().score1.ToString();
    }
}
