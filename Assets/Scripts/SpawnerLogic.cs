using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLogic : MonoBehaviour {

     public GameObject Targetprefab;
     public float tSec;
     public bool isSpawning = true;
	
	void Start () {
        StartCoroutine(Spawner());
	}
	

    IEnumerator Spawner()
    {
        while (isSpawning)
        {
            yield return new WaitForSeconds(tSec);
            transform.position = RandomizePos();
            Spawn();
            
        }
    }

    void Spawn()
    {
        Instantiate(Targetprefab,transform.position,Quaternion.identity);
    }

    Vector3 RandomizePos()
    {
        Vector3 pos = new Vector3(Random.Range(-2f, 2f), Random.Range(-0.4f, 3.4f), 0f);
        return pos;
    }
	
}
