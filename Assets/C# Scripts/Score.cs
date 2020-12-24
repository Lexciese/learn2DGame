using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Movements movement;
    public Text scoreText;
    public int scoreCounter = 0;


    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Passing")
        {
            // Debug.Log("Pass Trough");
            scoreCounter++;
            scoreText.text = scoreCounter.ToString();
            if (scoreCounter >= PlayerPrefs.GetInt("Score", 0)) {
                PlayerPrefs.SetInt("Score", scoreCounter);
            }
            
        }
    }
}
