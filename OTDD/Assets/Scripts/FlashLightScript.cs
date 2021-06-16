using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightScript : MonoBehaviour
{

    public bool isOn = false;

    public float FlashBattery = 100f;

    int switchOff = 1;

    public GameObject lightSource;
    public AudioSource clickSound;

    PlayerScript Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if(switchOff != Player.currentDir) {
            isOn = true;

            if (isOn) {

            lightSource.SetActive(true);
            //clickSound.Play();
            //FlashBattery--;
            //Debug.Log("Battery left: " + FlashBattery);
        }

        } else {
            isOn = false;
            lightSource.SetActive(false);
        }

    }
}
