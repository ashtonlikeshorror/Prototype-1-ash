using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  // creating a variable for speed = 20
  float speed = 20.0f;
  float turnSpeed = 45.0f;
  float horizontalInput;
  float forwardInput;
  float GetAxis;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
      horizontalInput = Input.GetAxis("Horizontal");
     forwardInput = Input.GetAxis("Vertical");
     // Moves the car foward based on vertical
     transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
     //rotates car based on horizontal input
     transform.Rotate(Vector3.up,turnSpeed * horizontalInput * Time.deltaTime);

    }
}
