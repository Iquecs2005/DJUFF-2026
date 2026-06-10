using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    private static PlayerController playerController;
    private static CameraController cameraController;

    private void Awake()
    {
        if (instance != null && instance != this) 
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public static PlayerController GetPlayerController() 
    {
        if (playerController == null)
            playerController = GameObject.FindWithTag("Player")?.GetComponent<PlayerController>();
        return playerController;
    }

    public static CameraController GetCameraController() 
    {
        if (cameraController == null)
            cameraController = GameObject.FindWithTag("CameraHolder").GetComponent<CameraController>();
        return cameraController;
    }

    public static void LockMouse() 
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public static void UnlockMouse() 
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public static void PauseGame() 
    {
        Time.timeScale = 0;
    }

    public static void UnpauseGame()
    {
        Time.timeScale = 1;
    }
}
