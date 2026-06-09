using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SoulTriggerController : MonoBehaviour
{
    [SerializeField] private UnityEvent OnSoulEnter;
    [SerializeField] private UnityEvent OnSoulExit;

    private bool soulIsOut;

    private void OnTriggerEnter(Collider other)
    {
        if (soulIsOut) 
        {
            OnSoulEnter.Invoke();
            soulIsOut = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        soulIsOut = true;
        OnSoulExit.Invoke();
    }
}
