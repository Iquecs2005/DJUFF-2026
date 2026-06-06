using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilSpiritController : MonoBehaviour
{
    private PlayerController playerController;

    private void Start()
    {
        playerController = GameManager.GetPlayerController();

        float ratio = playerController.GetPossetionRatio();
        print(ratio);
    }
}
