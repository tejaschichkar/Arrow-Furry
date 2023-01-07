using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public SceneController scenecontroller;
    public Text Result;
    public AdManager adManager;

    [SerializeField]
    public float delayBeforeLoading = 2f;
    [SerializeField]
    public float delayBeforeReLoading = 1f;
    [SerializeField]
    public float timeElapsed;

    [HideInInspector]
    public int Score = 0;

    [SerializeField]
    private Text Scoretxt;

    public bool win = false;
    public bool lost = false;

    void Update()
    {
        SetScore(Score);
        if(win)
        {
            timeElapsed += Time.deltaTime;
            adManager.ShowAd();
        }
        else if(lost)
        {
            timeElapsed += Time.deltaTime;
            adManager.ShowAd();
        }
        LostText();
        WonText();
        
        
    }
    void SetScore(int Score)
    {
        Scoretxt.text = "Score: " + Score; 
    }
    public void LostText()
    {
        if (Score < 0)
        {
            lost = true;
            Result.text = "You Lost";
            if (timeElapsed > delayBeforeReLoading)
            {
                if (scenecontroller.Scene == 1)
                {
                    scenecontroller.PlayScene();
                }
                else 
                {
                    scenecontroller.CurrentScene();
                }
            }
        }
    }
    public void WonText()
    {
        if(scenecontroller.Scene == 1)
        {
            if(Score >= 5)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.SecScene();
                }
            }
        }
        else if(scenecontroller.Scene == 2)
        {
            if(Score >= 7)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.ThirdScene();
                }
            }
        }
        else if(scenecontroller.Scene == 3)
        {
            if(Score >= 8)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.FourthScene();
                }
            }
        }
        else if(scenecontroller.Scene == 4)
        {
            if(Score >= 9)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.FifthScene();
                }
            }
        }
        else if(scenecontroller.Scene == 5)
        {
            if(Score >= 10)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.SixthScene();
                }
            }
        }
        else if(scenecontroller.Scene == 6)
        {
            if(Score >= 11)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.SeventhScene();
                }
            }
        }
        else if(scenecontroller.Scene == 7)
        {
            if(Score >= 12)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.EigthScene();
                }
            }
        }
        else if(scenecontroller.Scene == 8)
        {
            if(Score >= 13)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.NinthScene();
                }
            }
        }
        else if(scenecontroller.Scene == 9)
        {
            if(Score >= 14)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.TenthScene();
                }
            }
        }
        else if(scenecontroller.Scene == 10)
        {
            if(Score >= 15)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.EleventhScene();
                }
            }
        }
        else if(scenecontroller.Scene == 11)
        {
            if(Score >= 16)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.TwelthScene();
                }
            }
        }
        else if(scenecontroller.Scene == 12)
        {
            if(Score >= 35)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.ThirteenthScene();
                }
            }
        }
        else if(scenecontroller.Scene == 13)
        {
            if(Score >= 17)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.FourteenthScene();
                }
            }
        }
        else if(scenecontroller.Scene == 14)
        {
            if(Score >= 45)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.FifteenthScene();
                }
            }
        }
        else if(scenecontroller.Scene == 15)
        {
            if(Score >= 18)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.SixteenthScene();
                }
            }
        }
        else if(scenecontroller.Scene == 16)
        {
            if(Score >= 20)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.SeventeenthScene();
                }
            }
        }
        else if(scenecontroller.Scene == 17)
        {
            if(Score >= 19)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.EighteenthScene();
                }
            }
        }
        else if(scenecontroller.Scene == 18)
        {
            if(Score >= 15)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.NineteenthScene();
                }
            }
        }
        else if(scenecontroller.Scene == 19)
        {
            if(Score >= 20)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.TwentythScene();
                }
            }
        }
        else if(scenecontroller.Scene == 20)
        {
            if(Score >= 50)
            {
                win = true;
                Result.text = "You Won";
                if (timeElapsed > delayBeforeLoading)
                {
                    scenecontroller.MainScene();
                }
            }
        }
    }

}
