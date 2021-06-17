using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{

    private Image ProgressBar;
    public float CurrentProgress;
    private float MaxProgress = 100f;
    PlayerScript Player;

    private void Start() {
        ProgressBar = GetComponent<Image>();
        Player = FindObjectOfType<PlayerScript>();
    }
    

    private void Update() {

        CurrentProgress = Player.DoorProgress;
        ProgressBar.fillAmount = CurrentProgress / MaxProgress;

        if(CurrentProgress >= MaxProgress) {
            SceneSwitcher.ChangeToVictoryScene();
        }
      
    }
}
