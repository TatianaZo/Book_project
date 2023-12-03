using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapleController : MountController
{
    public override void Grab()
    {
        if (within)
        {
            if (!held)
            {
                GrabOn();
            }
            else
            {
                Ungrab();
            }           
        }
    }

    private void GrabOn()
    {
        //логика для хватания грейфера
    }

    private void Ungrab()
    {
        //логика для бросания из грейфера
    }
}
