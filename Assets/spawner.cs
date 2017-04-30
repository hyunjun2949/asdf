using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class spawndate
{
   public  Vector3 position;
   public GameObject prefab;
}
public class spawner : MonoBehaviour
{
    public List<spawndate> date;

	void Start ()
    {
        foreach(spawndate d in date)
        {
            GameObject obj = Instantiate(d.prefab);
            obj.transform.position = d.position;
        }
	}
	
	
	void Update ()
    {
		
	}
}
