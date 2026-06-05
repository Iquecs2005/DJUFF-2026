using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour
{
    [SerializeField] protected BaseController controller;

    [SerializeField] private Transform cameraTransform;

    [SerializeField] private float maxSpeed;
    [SerializeField] private float accelRate;
    [SerializeField] private float desaccelRate;

    private Vector2 moveInput;

    public void SetMoveInput(Vector2 newMoveInput)
    {
        moveInput = newMoveInput;
    }

    protected void ApplyMovement()
    {
        Rigidbody rb = controller.GetRigidbody();

        Vector3 movementInput = cameraTransform.forward * moveInput.y + cameraTransform.right * moveInput.x;
        movementInput.y = 0;
        movementInput.Normalize();

        if (controller.GetCurrentState() != controller.GetBodyVariable())
            movementInput = Vector3.zero;

        Vector3 targetSpeed = movementInput * maxSpeed;

        Vector3 speedDif = targetSpeed - rb.velocity;

        float currentAccelRate;
        if (targetSpeed.magnitude > 0.01f)
        {
            currentAccelRate = accelRate;
        }
        else
        {
            currentAccelRate = desaccelRate;
        }

        speedDif.y = 0;
        rb.AddForce(speedDif * currentAccelRate);
    }
}
