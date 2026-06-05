using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject bodyObject;
    [SerializeField] private GameObject soulObject;
    [SerializeField] private BodyController bodyController;
    [SerializeField] private SoulController ghostController;

    [SerializeField] private UnityEvent<BodyState> OnBodyStateChange;

    public BodyState currentState { get; private set; }

    public void SwitchState() 
    {
        if (currentState == BodyState.Body)
            currentState = BodyState.Soul;
        else
            currentState = BodyState.Body;

        OnBodyStateChange.Invoke(currentState);
    }

    public GameObject GetBodyObject() 
    {
        return bodyObject;
    }

    public GameObject GetSoulObject() 
    {
        return soulObject;
    }
}

public enum BodyState
{
    Body, Soul
}