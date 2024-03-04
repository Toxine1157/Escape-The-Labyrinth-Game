using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public PatrolPoints patrolpoints;

    public float speed;

    //LEVEL 1
    public bool isBot1_1;
    public bool isBot1_2;
    public bool isBot1_3;

    public int bot1_1Mover;
    public int bot1_2Mover;
    public int bot1_3Mover;

    // Start is called before the first frame update
    void Start()
    {

        bot1_1Mover = 0;
        bot1_2Mover = 0;
        bot1_3Mover = 0;
        //moveSpeed = speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        moveTo();
    }

    void moveTo()
    {
        //LEVEL 1

        if (isBot1_1)//(bot1)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints[bot1_1Mover], speed * Time.deltaTime);
        }

        if (isBot1_2)//(bot2)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints2[bot1_2Mover], speed * Time.deltaTime);
        }

        if (isBot1_3)//(bot3)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints3[bot1_3Mover], speed * Time.deltaTime);
        }

        // Code diatas buat gerakin bot

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints[bot1_1Mover]) < 0.001f)
        {
            //Debug.Log("Nilai i = " + bot1_1Mover);
            bot1_1Mover++;
        }

        if (bot1_1Mover > 3)
        {
            bot1_1Mover = 0;
        }

        
        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints2[bot1_2Mover]) < 0.001f)
        {
            //Debug.Log("Nilai j = " + bot1_2Mover);
            bot1_2Mover++;
        }

        if (bot1_2Mover > 1)
        {
            bot1_2Mover = 0;
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints3[bot1_3Mover]) < 0.001f)
        {
            //Debug.Log("Nilai k = " + bot1_3Mover);
            bot1_3Mover++;
        }

        if (bot1_3Mover > 1)
        {
            bot1_3Mover = 0;
        }
    }
}
