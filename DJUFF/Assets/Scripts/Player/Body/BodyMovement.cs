using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyMovement : BaseMovement
{
    private void FixedUpdate()
    {
        ApplyMovement();
    }
}
