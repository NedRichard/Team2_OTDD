using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HordeScript : MonoBehaviour
{

    public float hordeSpeed = 1f;

    public int HordeDir = 3;

    PlayerScript Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(HordeDir != Player.currentDir) {
            MoveHorde();
            //Debug.Log("Horde is moving!");
        }
        
    }

    void MoveHorde() {

        Vector3 newPos = transform.position;

        newPos += new Vector3(0, 0, 1) * hordeSpeed * Time.deltaTime;
        transform.position = newPos;
    }
}
