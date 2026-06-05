using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    [SerializeField] private CameraController cameraController;

    [SerializeField] private Transform bodyPOVTransform;
    [SerializeField] private Transform soulPOVTransform;

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
