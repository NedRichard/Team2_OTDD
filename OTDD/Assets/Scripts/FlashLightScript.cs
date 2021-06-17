using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightScript : MonoBehaviour
{

    public bool isOn = false;

    public float FlashBattery = 100f;

    //Position for opening the door
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
        ActivateLight();
    }

    void ActivateLight() {

        if(switchOff != Player.currentDir) {
            isOn = true;
            lightSource.SetActive(isOn);
        } else {
            clickSound.Play();
            isOn = false;
            lightSource.SetActive(isOn);
        }

    }
}
