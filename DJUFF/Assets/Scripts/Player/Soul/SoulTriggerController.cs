using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulTriggerController : MonoBehaviour
{
    [SerializeField] private PlayerController controller;

    private bool soulIsOut;

    private void OnTriggerEnter(Collider other)
    {
        if (soulIsOut) 
        {
            controller.SwitchState(true);
            soulIsOut = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        soulIsOut = true;
    }
}
