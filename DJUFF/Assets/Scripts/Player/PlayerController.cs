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
    [SerializeField] private PlayerCameraController cameraController;

    [SerializeField] private UnityEvent<BodyState> OnBodyStateChange;

    public BodyState currentState { get; private set; }

    public void SwitchState(bool force = false) 
    {
        if (currentState == BodyState.Body) 
        {
            currentState = BodyState.Soul;
        }
        else 
        {
            if (!force)
                return;
            currentState = BodyState.Body;
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

    public Transform GetCameraTransform() 
    {
        return cameraController.GetCameraTransform();
    }
}

public enum BodyState
{
    Body, Soul
}