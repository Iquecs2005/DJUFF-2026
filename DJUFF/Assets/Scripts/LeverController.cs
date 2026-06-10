using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeverController : MonoBehaviour
{
    [Header("Variables")]
    [SerializeField] private GameObject leverHandle;
    [SerializeField] private bool activated = false;
    [SerializeField] private float activatedAngle = -30;
    [SerializeField] private float deactivatedAngle = -150;

    [Header("Events")]
    [SerializeField] private UnityEvent LeverActivated;
    [SerializeField] private UnityEvent LeverDeactivated;

    private bool previousState;

    private void OnValidate()
    {
        if (activated != previousState) 
        {
            previousState = activated;
            if (activated)
                ActivateEffect();
            else
                DeactivateEffect();
        }
    }

    public void ToggleInteract() 
    {
        activated = !activated;
        if (activated)
            ActivateEffect();
        else
            DeactivateEffect();
    }

    private void ActivateEffect() 
    {
        LeverActivated.Invoke();
        Quaternion rotation = Quaternion.Euler(activatedAngle,
                                               leverHandle.transform.rotation.y,
                                               leverHandle.transform.rotation.z);
        leverHandle.transform.localRotation = rotation;
    }

    private void DeactivateEffect() 
    {
        LeverDeactivated.Invoke();
        Quaternion rotation = Quaternion.Euler(deactivatedAngle,
                                               leverHandle.transform.rotation.y,
                                               leverHandle.transform.rotation.z); 
        leverHandle.transform.localRotation = rotation;
    }
}
