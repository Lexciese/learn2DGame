using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenu : MonoBehaviour
{

    bool isPaused = false;
    public GameObject inGameMenu;
    public GameObject inGameMenuButton;

    // Start is called before the first frame update
    void Start()
    {
        inGameMenuButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused == false)
            {
                isPaused = true;
                Time.timeScale = 0;
                inGameMenu.SetActive(true);
                inGameMenuButton.SetActive(false);
            }
            else{
                Time.timeScale = 1;
                isPaused = false;
                inGameMenu.SetActive(false);
                inGameMenuButton.SetActive(true);
            }
        }
    }

    public void Resume(){
        Time.timeScale = 1;
        isPaused = false;
        inGameMenu.SetActive(false);
        inGameMenuButton.SetActive(true);
    }

    public void ActivateMenu(){
        isPaused = true;
        Time.timeScale = 0;
        inGameMenuButton.SetActive(false);
        inGameMenu.SetActive(true);

    }

    


}
