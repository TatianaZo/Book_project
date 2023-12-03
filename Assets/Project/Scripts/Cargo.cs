using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cargo : MonoBehaviour
{
    public Action<bool> onblock;    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Block") || other.gameObject.CompareTag("Taken"))
        {
            onblock?.Invoke(true);
            Debug.Log("Блок");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        onblock?.Invoke(false);
    }

}
