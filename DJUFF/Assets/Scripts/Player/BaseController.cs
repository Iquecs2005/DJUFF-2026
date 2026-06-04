using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    [SerializeField] protected PlayerController pc;

    [SerializeField] private Rigidbody rb;

    [SerializeField] private BodyState body;

    public BodyState GetCurrentState()
    {
        return pc.currentState;
    }

    public Rigidbody GetRigidbody() 
    {
        return rb;
    }

    public BodyState GetBodyVariable() 
    {
        return body;
    }
}
