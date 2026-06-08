using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyMovement : BaseMovement
{
    [Header("Body Variables")]
    [SerializeField] private float jumpForce;
    [SerializeField] private float jumpCooldown;
    [SerializeField] private float jumpBufferTime;

    private bool shouldJump;
    private float currentBufferTime;
    private float currentCooldown;

    private void FixedUpdate()
    {
        ApplyMovement();
        if (currentBufferTime > 0) 
        {
            Jump();
            currentBufferTime -= Time.deltaTime;
        }
        else if (shouldJump) 
        {
            Jump();
        }

        if (currentCooldown > 0)
            currentCooldown -= Time.deltaTime;
    }

    public void StartJump() 
    {
        shouldJump = true;
    }

    public void EndJump() 
    {
        shouldJump = false;
        currentBufferTime = jumpBufferTime;
    }

    public bool Jump() 
    {
        if (controller.GetCurrentState() != BodyState.Body)
            return false;

        if (currentCooldown > 0)
            return false;

        bool grounded = ((BodyController)controller).IsGrounded();     
        if (!grounded)
            return false;

        Rigidbody rb = controller.GetRigidbody();
        rb.AddForce(Vector3.up * jumpForce);

        currentCooldown = jumpCooldown;
        currentBufferTime = jumpBufferTime;
        return true;
    }
}
