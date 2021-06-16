using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    
    public static void ChangeToVictoryScene() {
        Debug.Log("Moved to Victory scene!");
    }

    public static void ChangeToGameOver() {
        Debug.Log("Moved to Game Over scene!");
    }

    public static void ChangeToMainMenu() {
        Debug.Log("Moved to Main Menu!");
    }
}
