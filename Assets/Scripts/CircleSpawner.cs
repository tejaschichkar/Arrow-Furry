using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public GameObject Circleprefab;
    public float tSec = 7f;
    public bool isSpawning = true;
	
	void Start() 
    {
        StartCoroutine(Spawner());
	}
	
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Arrow")
        {
            StartCoroutine(Spawner());
        }
    }

    IEnumerator Spawner()
    {
        while (isSpawning)
        {
            yield return new WaitForSeconds(tSec);
            transform.position = new Vector3(0f, 2f, 0f);
            Spawn();
        }
    }

    void Spawn()
    {
        Instantiate(Circleprefab,transform.position,Quaternion.identity);
    }
}
