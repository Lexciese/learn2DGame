using UnityEngine;
using UnityEngine.UI;

public class getHSInt : MonoBehaviour
{

    int m_Score;
    public Text HSInt;

    // Start is called before the first frame update
    void Start()
    {
        getHS();
    }
    
    void getHS()
    {
        //Fetch the score from the PlayerPrefs (set these Playerprefs in another script). 
        // If no Int of this name exists, the default is 0.
        m_Score = PlayerPrefs.GetInt("Score", 0);
        HSInt.text = m_Score.ToString();
    }
}
