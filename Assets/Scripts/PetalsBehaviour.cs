using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetalsBehaviour : MonoBehaviour
{
    public GameObject TopHex;
    public GameObject BottomHex;
    public GameObject LeftHex;
    public GameObject RightHex;
    //private float nInt = -0.69f;
    private float pInt = 0.69f;
    private float pnum = 1.38f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        topUp();
        topDown();
    }
    private void topUp()
    {
        if(TopHex.transform.position.y <= pInt)
        {
            TopHex.transform.position = new Vector3 (0, pnum, 0);
        }
    }
    private void topDown()
    {
        if(TopHex.transform.position.y >= pnum)
        {
            TopHex.transform.position = new Vector3 (0, pInt, 0);
        }
    }
}
