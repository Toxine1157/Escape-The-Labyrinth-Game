using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform PlayerPosition; //Take player's position

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Camera Follows Player
        transform.position = new Vector3(PlayerPosition.position.x, PlayerPosition.position.y, -10);
    }
}
