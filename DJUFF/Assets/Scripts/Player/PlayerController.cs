using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private BodyController bodyController;
    [SerializeField] private SoulController ghostController;

    public BodyState currentState { get; private set; }

    public void SwitchState() 
    {
        if (currentState == BodyState.Body)
            currentState = BodyState.Soul;
        else
            currentState = BodyState.Body;
    }
}

public enum BodyState
{
    Body, Soul
}