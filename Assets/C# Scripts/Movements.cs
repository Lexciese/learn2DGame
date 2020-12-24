using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{

    public Rigidbody2D Move;
    public float Force = 500f;
    public float speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        Move = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        Control();
    }

    void Control(){

        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis ("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis ("Vertical");

        if(Input.GetKey(KeyCode.Space)){
            Vector2 movement = new Vector2 (moveHorizontal, moveVertical + Force + 3);

            //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
            Move.AddForce (movement * speed * Time.deltaTime);
        }
        // Touchscreen support
        if (Input.GetMouseButton(0))
        {
            // Debug.Log("Pressed left click.");
            Vector2 movement = new Vector2(moveHorizontal, moveVertical + Force + 3);
            Move.AddForce(movement * speed * Time.deltaTime);
        }
        
    }
}

