using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulSafety : MonoBehaviour
{
    [SerializeField] private SoulController controller;

    private bool isSafe = true;

    public void OnSafeZoneEnter(Collider other) 
    {
        if (other.tag != "SafeZone")
            return;

        if (isSafe)
            return;

        isSafe = true;
        controller.OnSafetyChangeEvent.Invoke(isSafe);
    }

    public void OnSafeZoneExit(Collider other)
    {
        if (other.tag != "SafeZone")
            return;

        if (!isSafe)
            return;

        isSafe = false;
        controller.OnSafetyChangeEvent.Invoke(isSafe);
    }
}
