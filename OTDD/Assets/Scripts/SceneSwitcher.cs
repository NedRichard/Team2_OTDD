using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    
    public static void ChangeToVictoryScene() {
        Debug.Log("Moved to Victory scene!");
        SceneManager.LoadScene("VictoryScene");
    }

    public static void ChangeToGameOver() {
        Debug.Log("Moved to Game Over scene!");
        SceneManager.LoadScene("GameOver");
    }

    public static void ChangeToGameView() {
        Debug.Log("Moved to Main Menu!");
        SceneManager.LoadScene("NedScene");
    }

    public static void QuitGame() {
        Application.Quit();
    }
}
