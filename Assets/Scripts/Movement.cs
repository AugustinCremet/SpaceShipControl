using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    [SerializeField] float moveSpeed;
    [SerializeField] float speedMultiplier;
    void Update()
    {
        //float mouseX = (Input.mousePosition.x - Screen.width/2)/Screen.width * rotationSpeed;
        float mouseY = -(Input.mousePosition.y - Screen.height/2)/Screen.height * rotationSpeed; 
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        bool warpMode = Input.GetKey(KeyCode.Space);

        // Rotate ship yaw with AD key
        transform.Rotate(new Vector3(0, 0, horizontalInput) * rotationSpeed * Time.deltaTime);

        // Move ship foward with W key
        if(warpMode)
            // Give the ship a moveSpeed increased
            transform.Translate(new Vector3(0, -verticalInput, 0) * moveSpeed * speedMultiplier * Time.deltaTime);
        else
            // Move ship at normal speed
            transform.Translate(new Vector3(0, -verticalInput, 0) * moveSpeed * Time.deltaTime);

        // Rotate ship pîtch with mouse up/down
        transform.Rotate(new Vector3(mouseY, 0, 0) * Time.deltaTime, Space.Self);
    }
}
