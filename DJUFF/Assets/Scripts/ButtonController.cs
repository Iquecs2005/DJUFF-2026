using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private UnityEvent ButtonPress;
    [SerializeField] private UnityEvent ButtonUnpressed;

    public void OnActivation() 
    {
        ButtonPress.Invoke();
    }

    public void OnDeactivation() 
    {
        ButtonUnpressed.Invoke();
    }
}
