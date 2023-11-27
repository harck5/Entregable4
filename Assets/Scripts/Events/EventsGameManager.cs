using System;
using UnityEngine;

public class EventsGameManager : MonoBehaviour
{
    public delegate void DelegadoEnter();
    public static event DelegadoEnter OnEnterKeyPressed;

    public delegate void DelegadoEscape();
    public static event DelegadoEscape OnEscapeKeyPressed;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (OnEnterKeyPressed != null)
            {
                OnEnterKeyPressed();
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (OnEscapeKeyPressed != null)
            {
                OnEscapeKeyPressed();
            }
        }
    }
}