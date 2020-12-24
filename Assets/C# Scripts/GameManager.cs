using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float delayTime = 3.0f; 
    public GameObject Image;

    public void endGame(){
        if (gameHasEnded ==  false) {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Image.SetActive(true);
            Invoke("Restart", delayTime);
        }
        
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
