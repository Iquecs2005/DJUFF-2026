using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Camera cameraComponent;
    [SerializeField] private CinemachineVirtualCamera cinemachineCamera;

    [Header("Variables")]
    [SerializeField] private LayerMask normalLayers;
    [SerializeField] private LayerMask spiritLayers;

    private ViewMode currentView;

    private void OnEnable()
    {
        GameManager.LockMouse();
    }

    private void OnDisable()
    {
        GameManager.UnlockMouse();
    }

    private void OnValidate()
    {
        SetNormalView();
    }

    public void SetCameraFollow(Transform newFollow) 
    {
        cinemachineCamera.Follow = newFollow;
    }

    public void ToggleViewMode() 
    {
        if (currentView == ViewMode.Normal)
            SetSpiritualView();
        else
            SetNormalView();
    }

    public void SetNormalView() 
    {
        cameraComponent.cullingMask = normalLayers;
    }

    public void SetSpiritualView()
    {
        cameraComponent.cullingMask = spiritLayers;
    }

    public Transform GetCameraTransform() 
    {
        return cameraComponent.transform;
    }
}

public enum ViewMode 
{
    Normal, Spiritual
}