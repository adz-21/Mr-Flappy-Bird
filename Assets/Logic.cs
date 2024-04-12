using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Logic : MonoBehaviour
{
   public int score;
   public Text scoreText;
   public AudioSource ding;
   public GameObject GameOverScreen;

    [ContextMenu("Increase Score")]
   public void addScore(int x)
   {
    score = score + x;
    scoreText.text = score.ToString();
    ding = GetComponent<AudioSource>();
    ding.Play(0);
   }

   public void restartGame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   public void gameOver()
   {
      GameOverScreen.SetActive(true);
   }
}
