using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulController : BaseController
{
    [SerializeField] private SoulMovement soulMovement;

    public override void OnBodyStateChange(BodyState newBodyState)
    {
        base.OnBodyStateChange(newBodyState);

        if (newBodyState == BodyState.Soul) 
        {
            soulMovement.CenterOnBody();
            gameObject.SetActive(true);
        }
        else 
        {
            gameObject.SetActive(false);
            soulMovement.CenterOnBody();
        }
        
        GetRigidbody().velocity = Vector3.zero;
    }
}
