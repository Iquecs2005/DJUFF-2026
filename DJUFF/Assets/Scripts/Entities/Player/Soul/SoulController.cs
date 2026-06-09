using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SoulController : BaseController
{
    [SerializeField] private SoulMovement soulMovement;

    [field: Header("Events")]
    [field: SerializeField] public UnityEvent<bool> OnSafetyChangeEvent
    { get; private set; } = new UnityEvent<bool>();

    public override void OnBodyStateChange(BodyState newBodyState)
    {
        base.OnBodyStateChange(newBodyState);

        if (newBodyState == BodyState.Soul) 
        {
            soulMovement.CenterOnBody();
            gameObject.SetActive(true);
            soulMovement.ApplyExpulsionForce();
        }
        else 
        {
            gameObject.SetActive(false);
            soulMovement.CenterOnBody();
        }
        
        GetRigidbody().velocity = Vector3.zero;
    }
}
