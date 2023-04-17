using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform cameraTarget;
    [SerializeField] Transform lookTarget;
    [SerializeField] float cameraSpeed;
    void Update() 
    {
        transform.position = Vector3.Lerp(transform.position, cameraTarget.position, cameraSpeed * Time.deltaTime);
        transform.LookAt(lookTarget, -lookTarget.up);
    }
}
