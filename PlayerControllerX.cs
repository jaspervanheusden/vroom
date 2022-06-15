using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    private float verticalInput;
   

    void FixedUpdate()
    {

        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed);
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * 2);

    }
}
