using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0f, 0f, 10f * Time.deltaTime);
    }
}
