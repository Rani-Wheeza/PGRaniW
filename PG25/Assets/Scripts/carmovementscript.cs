using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class carmovementscript : MonoBehaviour
{

    float speed = 0f;
    private float speedMultiplier = 0f;
    private float accerationTime = 5f;
    private float elapsedTime = 0f;
    float accelation = 5;
    float turningSpeed = 45f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Initialize movement direction to zero
        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            speed += accelation * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            speed -= accelation * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -turningSpeed* Time.deltaTime); // turn left
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime); // turn right
        }

        // Normalize to ensure consistent movement speed when moving diagonally
 
       
        // Apply movement
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);

        //// Apply forward/backward movement
        //transform.Translate(moveDirection * speed * Time.deltaTime, Space.Self);

        // Rotation (Turning) - Left and Right with A and S
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime); // Turn left
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);  // Turn right
        }

        ////Speed
        ////Will gradually incerase the speed multiper over 5 seconds
        //if (elapsedTime < accerationTime) {
        //    elapsedTime = Time.deltaTime;
        //    speedMultiplier = Mathf.Min(elapsedTime / accerationTime, 1f);
                    
        //}


  

    }
}
