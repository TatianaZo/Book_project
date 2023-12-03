using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountController : MonoBehaviour
{
    [HideInInspector] public bool within, held; //within - колайдер вошЄл в контакт с грузом; held - груз прицеплен и удерживаетс€
    protected GameObject cargo; //здесь будет хранитьс€ переменна€ груза
    [HideInInspector] public bool block;


    //провер€ем коснулс€ ли коллайдер груза
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Taken"))
        {
            within = true;
            cargo = collider.gameObject; //груз который мы пересекли коллайдером
            Debug.Log("¬ошЄл");
        }
    }

    //провер€ем вышел ли коллайдер из контакта с грузом
    private void OnTriggerExit(Collider other)
    {        
        within = false;
        cargo = null;
        Debug.Log("¬ышел");        
    }

    //«ацепление груза (общее дл€ всех детишек, вызываетс€ из кран менеджера)
    virtual public void Grab()
    {        
    }
}
