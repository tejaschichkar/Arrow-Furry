using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowInventory : MonoBehaviour
{
    public int Arrows;
    public int shot;
    public int target;
    public Text Result;
    public Text arrows;
    public ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Arrows == shot && scoreManager.Score == target || scoreManager.Score == target && Arrows >= shot)
        {
            Result.text = "You Won";
        }
        else if(Arrows < 0 && scoreManager.Score != target)
        {
            scoreManager.lost = true;
            Result.text = "You Lost";
            if (scoreManager.timeElapsed > scoreManager.delayBeforeReLoading)
            {
                scoreManager.scenecontroller.Replay();
            }
        }
        arrows.text = "Arrows : " + Arrows;
    }
}
