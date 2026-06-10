using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject mainPage;
    [SerializeField] private GameObject creditsPage;

    [Header("Variables")]
    [SerializeField] private string FirstLevelName;

    public void OnPlay()
    {
        SceneManager.LoadScene(FirstLevelName);
    }

    public void ExitGame() 
    {
        Application.Quit();
    }

    public void ActivateMainPage() 
    {
        DeactivateAllPages();

        mainPage.SetActive(true);
    }

    public void ActivateCreditsPage() 
    {
        DeactivateAllPages();

        creditsPage.SetActive(true);
    }

    private void DeactivateAllPages()
    {
        mainPage.SetActive(false);
        creditsPage.SetActive(false);
    }
}