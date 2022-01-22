using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject gameoverPanel;
    [SerializeField] Text scoreText;
    [SerializeField] Text finalScoreText;
   // [SerializeField] Text highScoreText;
    [SerializeField] Text newHighscoreText;
    public static int highScore;
    public int score;
    public bool hasGameStarted;
    // Start is called before the first frame update
    void Start()
    {
        LoadData();
      //  Debug.Log("HighScore: " + highScore);
        hasGameStarted = true;
        gameoverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasGameStarted)
            Gameover();
        scoreText.text = score.ToString();
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("highscore", highScore);
    }
    public void LoadData()
    {

        highScore = PlayerPrefs.GetInt("highscore");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Gameover()
    {
        
        gameoverPanel.SetActive(true);
        //hasGameStarted = false;
        if (score > highScore)
        {
            newHighscoreText.gameObject.SetActive(true);
            highScore = score;
            SaveData();
        }
        //highScoreText.text = highScore.ToString();
        finalScoreText.text = score.ToString();
        
        
        gameoverPanel.SetActive(true);
       // StopAllCoroutines();
        
    }
}
