using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera cinemachineCamera;

    public void SetCameraFollow(Transform newFollow) 
    {
        cinemachineCamera.Follow = newFollow;
    }
}
