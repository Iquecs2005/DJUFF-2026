using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodySpriteController : MonoBehaviour
{
    [SerializeField] private GameObject sprite;

    private void Start()
    {
        sprite.SetActive(false);
    }

    public void OnBodyStateChange(BodyState newBodyState)
    {
        if (newBodyState == BodyState.Soul)
        {
            sprite.SetActive(true);
        }
        else
        {
            sprite.SetActive(false);
        }
    }
}
