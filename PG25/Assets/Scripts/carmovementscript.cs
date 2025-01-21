using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class carmovementscript : MonoBehaviour
{

    float speed = 3f;
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
            moveDirection += transform.forward; // Move forward
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveDirection += Vector3.back; // Move backward
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveDirection += Vector3.left; // Move left
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveDirection += Vector3.right; // Move right
        }

        // Normalize to ensure consistent movement speed when moving diagonally
        if (moveDirection.magnitude > 1)
        {
            moveDirection.Normalize();
        }

        // Apply movement
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);

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
    }
}
