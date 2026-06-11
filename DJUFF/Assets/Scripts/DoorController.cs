using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneName);
    }
}
