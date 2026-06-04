using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour
{
    [SerializeField] private BaseController controller;

    [SerializeField] private float maxSpeed;

    private Vector2 moveInput;

    public void SetMoveInput(Vector2 newMoveInput)
    {
        moveInput = newMoveInput;
    }

    protected void ApplyMovement()
    {
        Vector3 movementInput = new Vector3(moveInput.x, 0, moveInput.y);

        if (controller.GetCurrentState() != controller.GetBodyVariable())
            movementInput = Vector3.zero;

        controller.GetRigidbody().velocity = movementInput * maxSpeed;
    }
}
