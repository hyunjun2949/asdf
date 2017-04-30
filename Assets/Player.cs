using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerInfo
{
    public int level;
    public int clickup;
    public int gauge;
    public int maxgauge;
}

public class Player : MonoBehaviour
{
    public PlayerInfo Info;
   

	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Info.gauge += Info.clickup;
        }
      
        if(Info.gauge>=Info.maxgauge)
        {
            Info.level += 1;
            Info.gauge = 0;
        }
	}
}
