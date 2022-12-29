using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject Obstacleprefab;
    public float Osec;
    public bool isAppearing = true;
	
	void Start () {
        StartCoroutine(Spawner());
	}
	

    IEnumerator Spawner()
    {
        while (isAppearing)
        {
            yield return new WaitForSeconds(Osec);
            transform.position = RandomizePos();
            Spawn();
            
        }
    }

    void Spawn()
    {
        Instantiate(Obstacleprefab,transform.position,Quaternion.identity);
    }

    Vector3 RandomizePos()
    {
        Vector3 pos = new Vector3(Random.Range(-3f, 3f), Random.Range(-0.4f, 3.4f), 0f);
        return pos;
    }
}
