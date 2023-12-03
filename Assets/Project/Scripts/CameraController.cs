using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Camera camera;
    public float sense = 1;

    private void Start()
    {
        camera = Camera.main;

    }

    private void Update()
    {
        camera.transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * sense;
        
    }
}
