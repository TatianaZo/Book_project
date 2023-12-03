using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountController : MonoBehaviour
{
    [HideInInspector] public bool within, held; //within - �������� ����� � ������� � ������; held - ���� ��������� � ������������
    protected GameObject cargo; //����� ����� ��������� ���������� �����
    [HideInInspector] public bool block;


    //��������� �������� �� ��������� �����
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Taken"))
        {
            within = true;
            cargo = collider.gameObject; //���� ������� �� ��������� �����������
            Debug.Log("�����");
        }
    }

    //��������� ����� �� ��������� �� �������� � ������
    private void OnTriggerExit(Collider other)
    {        
        within = false;
        cargo = null;
        Debug.Log("�����");        
    }

    //���������� ����� (����� ��� ���� �������, ���������� �� ���� ���������)
    virtual public void Grab()
    {        
    }
}
