using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GroundCheck : MonoBehaviour
{
    [Header("Variables")]
    [SerializeField] private Transform referenceTransform;
    [SerializeField] private float rayDistance;
    [SerializeField] private LayerMask groundLayer;

    [Header("Events")]
    [SerializeField] private UnityEvent<bool> OnGroundedValueChange;

    public bool grounded { get; private set; }

    private void FixedUpdate()
    {
        CheckGround();
    }

    private void CheckGround() 
    {
        bool hit = Physics.Raycast(referenceTransform.position, Vector3.down, rayDistance, groundLayer);
        if (hit != grounded) 
        {
            grounded = hit;
        }    
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawRay(referenceTransform.position, Vector3.down * rayDistance);
    }
}
