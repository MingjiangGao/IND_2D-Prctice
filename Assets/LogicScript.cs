using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript: MonoBehaviour


{
    public void GameOver(){
        SceneManager.LoadScene("GameOverScene");
    }
     public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
        [ContextMenu("Increase Score")]
        public void addScore(int toAdd){
            playerScore = playerScore +toAdd;
            scoreText.text = playerScore.ToString();
        }
        public void restartGame(){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        public void gameOver(){
            gameOverScreen.SetActive(true);
        }
    // Start is called before the first frame update
    
}
