using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    public int Scene;

    public void Start()
    {
        Scene = SceneManager.GetActiveScene().buildIndex;
    }

    public void MainScene()
    {
        SceneManager.LoadScene(0);
    }
    public void PlayScene()
    {
        SceneManager.LoadScene(1);
    }
    public void SecScene()
    {
        SceneManager.LoadScene(2);
    }
    public void ThirdScene()
    {
        SceneManager.LoadScene(3);
    }
    public void FourthScene()
    {
        SceneManager.LoadScene(4);
    }
    public void FifthScene()
    {
        SceneManager.LoadScene(5);
    }
    public void SixthScene()
    {
        SceneManager.LoadScene(6);
    }
    public void SeventhScene()
    {
        SceneManager.LoadScene(7);
    }
    public void EigthScene()
    {
        SceneManager.LoadScene(8);
    }
    public void NinthScene()
    {
        SceneManager.LoadScene(9);
    }
    public void TenthScene()
    {
        SceneManager.LoadScene(10);
    }
    public void EleventhScene()
    {
        SceneManager.LoadScene(11);
    }
    public void TwelthScene()
    {
        SceneManager.LoadScene(12);
    }
    public void ThirteenthScene()
    {
        SceneManager.LoadScene(13);
    }
    public void FourteenthScene()
    {
        SceneManager.LoadScene(14);
    }
    public void FifteenthScene()
    {
        SceneManager.LoadScene(15);
    }
    public void SixteenthScene()
    {
        SceneManager.LoadScene(16);
    }
    public void SeventeenthScene()
    {
        SceneManager.LoadScene(17);
    }
    public void EighteenthScene()
    {
        SceneManager.LoadScene(18);
    }
    public void NineteenthScene()
    {
        SceneManager.LoadScene(19);
    }
    public void TwentythScene()
    {
        SceneManager.LoadScene(20);
    }
    public void InstScene()
    {
        SceneManager.LoadScene(21);
    }
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void CurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
