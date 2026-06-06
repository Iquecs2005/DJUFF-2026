using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerPossesionController : MonoBehaviour
{
    [SerializeField] private float possesionTime;

    [SerializeField] private UnityEvent OnPossesion; 

    private bool beingPossesed = false;
    private float currentPossesionTime = 0;

    private void FixedUpdate()
    {
        if (beingPossesed)
        {
            currentPossesionTime += Time.deltaTime;
            if (currentPossesionTime >= possesionTime)
            {
                Possesion();
            }
        }
    }

    public void OnBodyStateChange(BodyState newBodyState)
    {
        if (newBodyState == BodyState.Body) 
        {
            beingPossesed = false;
            currentPossesionTime = 0;
        }
        else 
        {
            beingPossesed = true;
        }
    }

    public float PossesionRatio() 
    {
        return currentPossesionTime / possesionTime;
    }

    private void Possesion() 
    {
        print("You lose!");
        OnPossesion.Invoke();
    } 
}
