using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilSpiritContact : MonoBehaviour
{
    public void OnContact(Collider other)
    {
        ISpiritual spiritual = other.GetComponentInParent<ISpiritual>();
        spiritual.OnContactEffect();
    }
}

public interface ISpiritual 
{
    public void OnContactEffect(); 
}
