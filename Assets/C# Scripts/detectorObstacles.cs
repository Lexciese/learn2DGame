using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorObstacles : MonoBehaviour
{

    public float minH = -2f;
    public float maxH = 4f;

    public GameObject Obstacles;
    public GameObject Obstacles2;
    public GameObject Obstacles3;

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.tag == "Obstacles")
        {

            Debug.Log("Detectors " + collision.gameObject.name);
            // FindObjectOfType<GameManager>().endGame();

            var randY = UnityEngine.Random.Range(minH, maxH);
            if (collision.gameObject.name == "Obstacles") {
                Obstacles.transform.position = new Vector3(19, randY, 0);
            }
            else if (collision.gameObject.name == "Obstacles2") {
                Obstacles2.transform.position = new Vector3(19, randY, 0);
            }
            else if (collision.gameObject.name == "Obstacles3") {
                Obstacles3.transform.position = new Vector3(19, randY, 0);
            }

        }
    }
}
