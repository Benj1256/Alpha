using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    private PlayerController playC;
    private Button button;


    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(clicked);

        playC = GameObject.Find("Hammer").GetComponent<PlayerController>();

        //titleScr.gameObject.SetActive(false);

    }

private void clicked(){
    Debug.Log(gameObject.name + " was clicked");

     playC.StartGame();
}


    // Update is called once per frame
   /* void Update()
    {
        if (isGameActive)
        {
            timeLeft -= Time.deltaTime;
            timerText.SetText("Time: " + Mathf.Round(timeLeft));
            if (timeLeft < 0)
            {
                GameOver();
            }
        }
    }*/
    

/*public void Distance (int scoreToAdd)
 {
     score += scoreToAdd;
     scoreText.text = "Score" + score;
 }*/

 // Stop game, bring up game over text and restart button
 /*public void GameOver()
 {
        if(playC.gameOver = true)
        {
            //gameOverText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
        }
        
 }*/

 // Restart game by reloading the scene
/* public void RestartGame()
 {
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
 }*/



}
