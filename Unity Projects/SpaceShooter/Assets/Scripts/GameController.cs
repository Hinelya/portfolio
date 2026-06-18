using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public GameObject hazard;
    public int spawnCount;
    public float spawnCooldown;
    public int startCooldown;
    public int waveCooldown;

    public Text scoreText;
    public Text gameoverText;
    public Text restartText;
    public int score;

    private bool gameOver;
    private bool restart;

    void Update()
    {
        if(restart == true)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }
             if (Input.GetKeyDown(KeyCode.Q))
            {
                Application.Quit();
            }
        }
    }

    IEnumerator SpawnValues()
    {
        yield return new WaitForSeconds(startCooldown);
        while(true) {
            
            for(int i = 0; i < spawnCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-3,3), 0, 6);
                Instantiate(hazard, spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(spawnCooldown);
            }
            yield return new WaitForSeconds(waveCooldown);
            if(gameOver == true)
            {
                restartText.text = "Press 'R' to Restart\nPress 'Q' to Quit";
                restart = true;
                break;
            }
        }
    }

    public void UpdateScore()
    {
        score += 10;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOver = true;
        gameoverText.text = "Game Over";
    }
    void Start()
    {
        gameoverText.text = "";
        restartText.text = "";
        gameOver = false;
        restart = false;
        StartCoroutine(SpawnValues());
    }
}
