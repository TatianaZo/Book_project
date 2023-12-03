using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CraneManager : MonoBehaviour
{    
    public GameObject frame, carriage, hook;
    public float sense = 0.002f;
    public Vector2 frameClamp, carriageClamp, hookClamp;
    public MountController mountController;

    void FixedUpdate()
    {        
        Frame();
        Carriage();
        Hook();
    }

    void Frame()
    {
        frame.transform.localPosition += (new Vector3(0, 0, Input.GetAxis("Horizontal")) * -sense);

        if (frame.transform.localPosition.z <= frameClamp.x || mountController.block)
        {
            frame.transform.localPosition += (new Vector3(0, 0, sense));
        }
        else if (frame.transform.localPosition.z >= frameClamp.y || mountController.block)
        {
            frame.transform.localPosition -= (new Vector3(0, 0, sense));
        }
    }

    void Carriage()
    {
        carriage.transform.localPosition += (new Vector3(Input.GetAxis("Vertical"), 0, 0) * sense);

        if (carriage.transform.localPosition.x <= carriageClamp.x || mountController.block)
        {
            carriage.transform.localPosition += (new Vector3(sense, 0, 0));
        }
        else if (carriage.transform.localPosition.x >= carriageClamp.y || mountController.block)
        {
            carriage.transform.localPosition -= (new Vector3(sense, 0, 0));
        }
    }

    void Hook()
    {
        hook.transform.localPosition += (new Vector3(0, -Input.GetAxis("HookControll"), 0) * sense);

        if (hook.transform.localPosition.y <= hookClamp.x || mountController.block)
        {
            hook.transform.localPosition += (new Vector3(0, sense, 0));
        }
        else if (hook.transform.localPosition.y >= hookClamp.y)
        {
            hook.transform.localPosition -= (new Vector3(0, sense, 0));
        }       
    }

    void Update()
    {
        if( Input.GetKeyDown(KeyCode.JoystickButton0) || (Input.GetKeyDown(KeyCode.Space)))
        {
            mountController.Grab();
        }
    }
}
