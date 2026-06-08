using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    [field: Header("References")]
    [field: SerializeField] public BodyController body { get; private set; }
    [field: SerializeField] public SoulController soul { get; private set; }

    [Header("Variables")]
    [SerializeField] private GameObject bodyObject;
    [SerializeField] private GameObject soulObject;

    [field: Header("Events")] 
    [field: SerializeField] public UnityEvent<BodyState> OnBodyStateChange 
                            { get; private set; } = new UnityEvent<BodyState>();
    [field: SerializeField] public UnityEvent OnBodyEvent
                            { get; private set; } = new UnityEvent();
    [field: SerializeField] public UnityEvent OnSoulEvent
                            { get; private set; } = new UnityEvent();

    public BodyState currentState { get; private set; }

    public void SwitchState(bool force = false) 
    {
        if (currentState == BodyState.Body) 
        {
            currentState = BodyState.Soul;
            OnSoulEvent.Invoke();
        }
        else 
        {
            if (!force)
                return;
            currentState = BodyState.Body;
            OnBodyEvent.Invoke();
        }

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