using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebas : MonoBehaviour
{
    void OnEnable()
    {
        EventsGameManager.OnEnterKeyPressed += Cosa;
    }


    void OnDisable()
    {
        EventsGameManager.OnEnterKeyPressed -= Cosa;
    }
    public void Cosa()
    {
        Debug.Log("Hola");
    }
}
