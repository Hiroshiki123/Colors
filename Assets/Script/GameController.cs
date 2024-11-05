using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public int totalScore;
    public Text scoreText;

    public GameObject gameOver;
    public GameObject gameOver2;
    public GameObject PF;
    public GameObject DEMO;

    public static GameController instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }
    public void showGameOver()
    {
        gameOver.SetActive(true);
    } 
    public void showGameOver2()
    {
        gameOver2.SetActive(true);
    }
    public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }
    public void showProximafase()
    {
        PF.SetActive(true);
    } 
    public void showDemo()
    {
        DEMO.SetActive(true);
    } 
}
