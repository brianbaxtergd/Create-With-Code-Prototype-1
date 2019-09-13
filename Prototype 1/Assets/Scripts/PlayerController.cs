using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 20f;
    float turnSpeed = 75f;
    float horizontalInput;
    float forwardInput;


    private void FixedUpdate()
    {
        // Collect user input.
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move vehicle forward/backward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Turn vehicle left/right.
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
