using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInputController : MonoBehaviour
{
    [SerializeField] private UnityEvent<Vector2> OnMoveEvent;
    [SerializeField] private UnityEvent<float> OnFloatEvent;
    [SerializeField] private UnityEvent OnAstralProjectionEvent;
    [SerializeField] private UnityEvent OnJumpEvent;

    private void OnEnable()
    {
        InputManager.OnMoveEvent.AddListener(OnMoveInput);
        InputManager.OnAstralProjectionEvent.AddListener(OnAstralProjection);
        InputManager.OnFloatEvent.AddListener(OnFloat);
        InputManager.OnJumpEvent.AddListener(OnJump);
    }

    private void OnDisable()
    {
        InputManager.OnMoveEvent.RemoveListener(OnMoveInput);
        InputManager.OnAstralProjectionEvent.RemoveListener(OnAstralProjection);
        InputManager.OnFloatEvent.RemoveListener(OnFloat);
        InputManager.OnJumpEvent.RemoveListener(OnJump);
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

    private void OnJump() 
    {
        OnJumpEvent.Invoke();
    }
}
