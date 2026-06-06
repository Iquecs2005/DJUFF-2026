using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    [Header("Variables")]
    [SerializeField] private Transform bodyPOVTransform;
    [SerializeField] private Transform soulPOVTransform;

    private CameraController cameraController;

    private void Start()
    {
        cameraController = GameManager.GetCameraController();
    }

    public void OnBodyStateChange(BodyState newBodyState) 
    {
        Transform newFollow;

        if (newBodyState == BodyState.Body)
        {
            newFollow = bodyPOVTransform;
            cameraController.SetNormalView();
        }
        else
        {
            newFollow = soulPOVTransform;
            cameraController.SetSpiritualView();
        }

        cameraController.SetCameraFollow(newFollow);
    }

    public Transform GetCameraTransform() 
    {
        return cameraController.GetCameraTransform();
    }
}
