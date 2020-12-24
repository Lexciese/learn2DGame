using UnityEngine;
using UnityEngine.UI;

public class obstacleMover : MonoBehaviour
{
    public Text scoreText;

    public GameObject Obstacles;
    public GameObject Obstacles2;
    public GameObject Obstacles3;

    public float minH = -2f;
    public float maxH = 4f;

    //movement speed in units per second
    public float movementSpeed = 3.0f;

    public void Start(){
        var randY1 = UnityEngine.Random.Range(minH, maxH);
        var randY2 = UnityEngine.Random.Range(minH, maxH);
        var randY3 = UnityEngine.Random.Range(minH, maxH);
        //update the position
        Obstacles.transform.position = new Vector3(13, randY1, 0);
        Obstacles2.transform.position = new Vector3(20, randY2, 0);
        Obstacles3.transform.position = new Vector3(27, randY3, 0);
    }

    // Update is called once per frame
    public void Update()
    {
        Obs1();
        Obs2();
        Obs3();

        if(scoreText.text == "5"){
            movementSpeed = 3.3f;
        }
        else if(scoreText.text == "10"){
            movementSpeed = 3.5f;
        }
        else if(scoreText.text == "15"){
            movementSpeed = 3.7f;
        }
        else if(scoreText.text == "20"){
            movementSpeed = 3.9f;
        }
        else if(scoreText.text == "25"){
            movementSpeed = 4.2f;
        }
        else if(scoreText.text == "30"){
            movementSpeed = 4.5f;
        }
        else if(scoreText.text == "35"){
            movementSpeed = 5.0f;
        }

    }

    void Obs1() {
        Obstacles.transform.position = Obstacles.transform.position + new Vector3(-1 * movementSpeed * Time.deltaTime, 0, 0);
    }

    void Obs2(){
        Obstacles2.transform.position = Obstacles2.transform.position + new Vector3(-1 * movementSpeed * Time.deltaTime, 0, 0);
    }

    void Obs3(){
        Obstacles3.transform.position = Obstacles3.transform.position + new Vector3(-1 * movementSpeed * Time.deltaTime, 0, 0);
    }
}
