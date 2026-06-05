using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyController : BaseController
{
    [SerializeField] private GroundCheck groundCheck;

    public bool IsGrounded() 
    {
        return groundCheck.grounded;
    }
}
