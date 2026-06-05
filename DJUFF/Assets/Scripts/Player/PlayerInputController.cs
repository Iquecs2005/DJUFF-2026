using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;

public class PlayerInputController : MonoBehaviour
{
    [Header("Events")]
    [SerializeField] private UnityEvent<Vector2> OnMoveEvent;
    [SerializeField] private UnityEvent<float> OnFloatEvent;
    [SerializeField] private UnityEvent OnAstralProjectionEvent;
    [SerializeField] private UnityEvent OnJumpStartEvent;
    [SerializeField] private UnityEvent OnJumpEndEvent;

    private void OnEnable()
    {
        InputManager.OnMoveEvent.AddListener(OnMoveInput);
        InputManager.OnAstralProjectionEvent.AddListener(OnAstralProjection);
        InputManager.OnFloatEvent.AddListener(OnFloat);
        InputManager.OnJumpStartEvent.AddListener(OnJumpStart);
        InputManager.OnJumpEndEvent.AddListener(OnJumpEnd);
    }

    private void OnDisable()
    {
        InputManager.OnMoveEvent.RemoveListener(OnMoveInput);
        InputManager.OnAstralProjectionEvent.RemoveListener(OnAstralProjection);
        InputManager.OnFloatEvent.RemoveListener(OnFloat);
        InputManager.OnJumpStartEvent.RemoveListener(OnJumpStart);
        InputManager.OnJumpEndEvent.AddListener(OnJumpEnd);
    }

    private void OnMoveInput(Vector2 newMoveInput)
    {
        OnMoveEvent.Invoke(newMoveInput);
    }

    private void OnAstralProjection() 
    {
        OnAstralProjectionEvent.Invoke();
    }

    private void OnFloat(float floatValue) 
    {
        OnFloatEvent.Invoke(floatValue);
    }

    private void OnJumpStart() 
    {
        OnJumpStartEvent.Invoke();
    }

    private void OnJumpEnd()
    {
        OnJumpEndEvent.Invoke();
    }
}
