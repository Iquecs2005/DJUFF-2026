using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EvilSpiritController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] EvilSpiritMovement movement;

    [Header("Variables")]
    [SerializeField] private GameObject holder;
    [field: SerializeField] public float possesionTime {  get; private set; }

    [Header("Events")]
    [SerializeField] private UnityEvent OnHauntingStart;
    [SerializeField] private UnityEvent OnHauntingEnd;

    public bool haunting { get; private set; }

    private PlayerController playerController;

    private void OnEnable()
    {
        if (playerController == null)
            playerController = GameManager.GetPlayerController();

        playerController.soul.OnSafetyChangeEvent.AddListener(SetHaunting);
        movement.SetGoal(playerController.body.transform);
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
            OnHauntingEnd.Invoke();
        }
        else 
        {
            holder.SetActive(true);
            haunting = true;
            OnHauntingStart.Invoke();
        }
    }
}
