using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyContact : MonoBehaviour, ISpiritual
{
    public void OnContactEffect() 
    {
        print("Possesed");
        print("You lose");
    }
}
