using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenController : MonoBehaviour
{
    [Header("Reference")]
    [SerializeField] private GameObject holder;

    [Header("Variables")]
    [SerializeField] private string mainMenuSceneName;

    private void OnEnable()
    {
        GameManager.GetPlayerController()?.OnDeathEvent.AddListener(ActivateDeathScreen);
    }

    private void OnDisable()
    {
        GameManager.GetPlayerController()?.OnDeathEvent.RemoveListener(ActivateDeathScreen);
    }

    public void ActivateDeathScreen() 
    {
        holder.SetActive(true);
        GameManager.UnlockMouse();
        GameManager.PauseGame();
    }

    public void Continue() 
    {
        GameManager.UnpauseGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu() 
    {
        GameManager.UnpauseGame();
        SceneManager.LoadScene(mainMenuSceneName);
    }
}
