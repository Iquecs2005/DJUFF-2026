using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulMovement : BaseMovement
{
    [SerializeField] private float floatSpeed;
    [SerializeField] private float floatAccelRate;
    [SerializeField] private float floatDesaccelRate;
    
    private float floatInput;

    private void FixedUpdate()
    {
        ApplyMovement();
        ApplyFloat();
    }

    public void CenterOnBody() 
    {
        GameObject body = controller.GetBodyObject();
        transform.position = body.transform.position;
    }

    public void SetFloatInput(float floatInput) 
    {
        this.floatInput = floatInput;
    }

    private void ApplyFloat() 
    {
        float desiredMoveDir = floatInput;
        Rigidbody rb = controller.GetRigidbody();

        if (controller.GetCurrentState() != BodyState.Soul) 
            desiredMoveDir = 0;

        float desiredSpeed = desiredMoveDir * floatSpeed;
        float speedDif = desiredSpeed - rb.velocity.y;

        float accelRate;
        if (desiredSpeed * rb.velocity.y >= 0)
        {
            if (Mathf.Abs(desiredSpeed) >= Mathf.Abs(rb.velocity.y))
            {
                accelRate = floatAccelRate;
            }
            else
            {
                accelRate = floatDesaccelRate;
            }
        }
        else
        {
            accelRate = floatDesaccelRate;
        }

        rb.AddForce(Vector2.up * speedDif * accelRate);
    }
}
