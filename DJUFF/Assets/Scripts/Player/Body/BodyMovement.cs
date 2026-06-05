using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyMovement : BaseMovement
{
    [SerializeField] private float jumpForce;

    private void FixedUpdate()
    {
        ApplyMovement();
    }

    public void Jump() 
    {
        if (controller.GetCurrentState() != BodyState.Body)
            return;

        bool grounded = ((BodyController)controller).IsGrounded();     
        if (!grounded) 
            return;

        Rigidbody rb = controller.GetRigidbody();
        rb.AddForce(Vector3.up * jumpForce);
    }
}
