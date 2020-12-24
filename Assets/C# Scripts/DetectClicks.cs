using UnityEngine.SceneManagement;
using UnityEngine;

public class DetectClicks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Click();
    }

    void Click()
    {
        if(Input.anyKey)
        {
            SceneManager.LoadScene("inGameScene");
        }
    }
}
