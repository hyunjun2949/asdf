using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockspawn : MonoBehaviour
{
   
    public GameObject block;
    float YGap = 3.09f;
    public GameObject Topblock;
	void Update ()

    {

        if (transform.position.y - Topblock.transform.position.y > YGap) 
        {
            GameObject newblock =Instantiate(block);
            newblock.transform.position = Topblock.transform.position;
            newblock.transform.Translate(0.0f, YGap, 0.0f);
            Topblock = newblock;
    }
  }
}
