using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public Text HSInt;


    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Exit(){
        Debug.Log("EXIT");
        Application.Quit();
    }

    public void resetHS(){
        PlayerPrefs.DeleteKey("Score");
        HSInt.text = "0";
    }

    public void toMainMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Time.timeScale = 1;
    }

}
