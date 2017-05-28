using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class goldinfo
{
    public int gold;
    public int goldsec;
}
public class goldui : MonoBehaviour
{
    
    public goldinfo info;
    float second;
    // Update is called once per frame
    void Update()
    {

        second += Time.deltaTime;
        if (second > 1.0f)
        {
            info.gold += info.goldsec;
            second = 0.0f;

        }
        GetComponent<UnityEngine.UI.Text>().text
            = info.gold.ToString();


    }

}