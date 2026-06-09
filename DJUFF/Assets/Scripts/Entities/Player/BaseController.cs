using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    [Header("Base References")]
    [SerializeField] protected PlayerController pc;
    [SerializeField] private Rigidbody rb;

    [Header("Base Variables")]
    [SerializeField] private BodyState body;

    public virtual void OnBodyStateChange(BodyState newBodyState)
    {

    }

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

    public GameObject GetBodyObject() 
    {
        return pc.GetBodyObject();
    }

    public GameObject GetSoulObject()
    {
        return pc.GetSoulObject();
    }
}
