using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager instance { get; private set; }

    public static UnityEvent<Vector2> OnMoveEvent { get; private set; } = new UnityEvent<Vector2>();
    public static UnityEvent<float> OnFloatEvent { get; private set; } = new UnityEvent<float>();
    public static UnityEvent OnAstralProjectionEvent { get; private set; } = new UnityEvent();

    private void Awake()
    {
        if (instance != null && instance != this) 
        {
            Destroy(this);
            return;
        }
        instance = this;
    }

    public static void OnMove(InputAction.CallbackContext callbackContext) 
    {
        Vector2 moveInput = callbackContext.ReadValue<Vector2>();
        OnMoveEvent.Invoke(moveInput);
    }

    public static void OnAstralProjection(InputAction.CallbackContext callbackContext) 
    {
        if (callbackContext.performed) 
        {
            OnAstralProjectionEvent.Invoke();
        }
    }

    public static void OnFloat(InputAction.CallbackContext callbackContext) 
    {
        float floatInput = callbackContext.ReadValue<float>();
        OnFloatEvent.Invoke(floatInput);
    }
}
