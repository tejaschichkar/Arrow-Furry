using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Arrow")
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
            GameObject.Find("_UI_Manager").GetComponent<ScoreManager>().Score += 5;
        }
    }
}
