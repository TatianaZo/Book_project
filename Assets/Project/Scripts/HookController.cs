using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookController : MountController
{
    public override void Grab()
    {
        if (within)
        {
            if (!held)
            {
                HookOn();
            }
            else
            {
                Unhook();
            }
        }
        else Debug.Log("не в коллайдере");
    }

    private void HookOn()
    {
        cargo.GetComponent<Rigidbody>().isKinematic = true;
        cargo.transform.SetParent(transform);
        cargo.GetComponent<Collider>().isTrigger = true;
        held = true;
        Debug.Log("Зацеплен");
        cargo.GetComponent<Cargo>().onblock += CargoOnBlock;
    }

    private void Unhook()
    {
        cargo.transform.SetParent(null);
        cargo.GetComponent<Rigidbody>().isKinematic = false;
        cargo.GetComponent<Collider>().isTrigger = false;
        held = false;
        Debug.Log("Отцеплен");
        cargo.GetComponent<Cargo>().onblock -= CargoOnBlock;
    }       

    private void CargoOnBlock(bool val)
    {
        block = val;
        Debug.Log("Блок" + val);
    } 
}
