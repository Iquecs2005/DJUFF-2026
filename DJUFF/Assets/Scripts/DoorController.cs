using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    [SerializeField] private int sceneID;

    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneID);
    }
}
