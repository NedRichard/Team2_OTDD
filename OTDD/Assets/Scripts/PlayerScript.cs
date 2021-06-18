using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    public float turnSpeed = 1f;

    public float DoorProgress = 0f;

    //Position direction labels
    public int currentDir = 1;
    public int turnDir1 = 1;
    public int turnDir2 = 2;
    public int turnDir3 = 3;
    public int turnDir4 = 4;

    //Position angles
    float doorPos = 180f;
    float downRight = 330f;
    float downLeft = 30f;
    float down = 0f;

    //Boolean for rotation
    bool rotatePlayer = false;

    // Start is called before the first frame update
    void Start()
    {
        currentDir = turnDir1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Turn();

        if(Input.GetButtonDown("Jump") && currentDir == 1) {
            OpenDoor();
        }

        //ChangeDir();
    }

    void OpenDoor() {      
        DoorProgress++;      
        //Debug.Log("Increased door progress by 1!");
    }

    //Currently not used
    void Turn() {

        if (Input.GetKey(KeyCode.UpArrow)) {
            currentDir = turnDir1;
            Debug.Log("Pushing up!");
            transform.localRotation = Quaternion.Euler(0, doorPos, 0);

        } else if (Input.GetKey(KeyCode.DownArrow)) {
            currentDir = turnDir3;
            Debug.Log("Pushing down!");
            transform.localRotation = Quaternion.Euler(0, down, 0);

        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            currentDir = turnDir2;
            Debug.Log("Pushing left!");
            transform.localRotation = Quaternion.Euler(0, downLeft, 0);

        } else if (Input.GetKey(KeyCode.RightArrow)) {
            currentDir = turnDir4;
            Debug.Log("Pushing right!");
            transform.localRotation = Quaternion.Euler(0, downRight, 0);
        }

    }

    void ChangeDir() {

        float rotPlayer = Time.fixedDeltaTime * turnSpeed;
        float fromAngle = transform.rotation.y;

        if (Input.GetKey(KeyCode.UpArrow) && !rotatePlayer) {
            Debug.Log("Pushing up!");

            float toAngle = doorPos;
    
            rotatePlayer = true;

            if(rotatePlayer) {




                if(fromAngle == doorPos) {
                    rotatePlayer = false;
                    currentDir = turnDir3;                   
                    Debug.Log("Looking at the door!");
                }       

            }
                //transform.Rotate(0f, rotPlayer, 0f);  

                //fromAngle += rotPlayer;
                
                //transform.rotation.y += new Vector3(0, turnSpeed, 0) * rotPlayer;

        } 

    }

}
