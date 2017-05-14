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

    public int GetMaxGauge()
    {
        return maxgauge * level;
    }
}

public class Player : MonoBehaviour
{
    public PlayerInfo Info;
   

	void Update ()
    {      
        if(Info.gauge>=Info.GetMaxGauge())
        {
            Info.level += 1;
            Info.gauge = 0;
        }
	}

    public void GaugeUp()
    {
        Info.gauge += Info.clickup;
    }
}
