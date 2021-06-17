using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        Debug.Log("Game Over!");
        SceneSwitcher.ChangeToGameOver();
    }
}
