using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilSpiritController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] EvilSpiritMovement movement;

    [Header("Variables")]
    [SerializeField] private GameObject holder;
    [field: SerializeField] public float possesionTime {  get; private set; }

    public bool haunting { get; private set; }

    private PlayerController playerController;

    private void OnEnable()
    {
        if (playerController == null)
            playerController = GameManager.GetPlayerController();

        playerController.soul.OnSafetyChangeEvent.AddListener(SetHaunting);
        movement.SetGoal(playerController.gameObject.transform);
    }

    private void OnDisable()
    {
        playerController.soul.OnSafetyChangeEvent.RemoveListener(SetHaunting);
    }

    private void SetHaunting(bool value) 
    {
        if (value) 
        {
            holder.SetActive(false);
            haunting = false;
        }
        else 
        {
            movement.SetRandomPos();
            holder.SetActive(true);
            haunting = true;
        }
    }
}
