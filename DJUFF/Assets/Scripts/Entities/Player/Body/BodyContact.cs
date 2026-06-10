using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyContact : MonoBehaviour, ISpiritual
{
    [SerializeField] private PlayerController controller;

    public void OnContactEffect() 
    {
        print("Possesed");
        print("You lose");
        controller.Die();
    }
}
