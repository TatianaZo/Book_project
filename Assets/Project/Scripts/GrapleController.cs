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
        //������ ��� �������� ��������
    }

    private void Ungrab()
    {
        //������ ��� �������� �� ��������
    }
}
