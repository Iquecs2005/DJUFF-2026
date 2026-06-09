using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeverController : MonoBehaviour
{
    [Header("Variables")]
    [SerializeField] private bool activated = false;

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
        print("a");
        activated = !activated;
        if (activated)
            ActivateEffect();
        else
            DeactivateEffect();
    }

    private void ActivateEffect() 
    {
        LeverActivated.Invoke();
    }

    private void DeactivateEffect() 
    {
        LeverDeactivated.Invoke();
    }
}
