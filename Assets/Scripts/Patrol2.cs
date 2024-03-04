using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol2 : MonoBehaviour
{
    public PatrolPoints patrolpoints;

    public float speed;


    public bool isBot2_1;
    public bool isBot2_2;
    public bool isBot2_3;
    public bool isBot2_4;
    public bool isBot2_5;
    public bool isBot2_6;
    public bool isBot2_7;
    public bool isBot2_8;
    public bool isBot2_9;
    public bool isBot2_10;


    public int bot2_1Mover;
    public int bot2_2Mover;
    public int bot2_3Mover;
    public int bot2_4Mover;
    public int bot2_5Mover;
    public int bot2_6Mover;
    public int bot2_7Mover;
    public int bot2_8Mover;
    public int bot2_9Mover;
    public int bot2_10Mover;

    // Start is called before the first frame update
    void Start()
    {
        bot2_1Mover = 0;
        bot2_2Mover = 0;
        bot2_3Mover = 0;
        bot2_4Mover = 0;
        bot2_5Mover = 0;
        bot2_6Mover = 0;
        bot2_7Mover = 0;
        bot2_8Mover = 0;
        bot2_9Mover = 0;
        bot2_10Mover = 0;
    }

    // Update is called once per frame
    void Update()
    {
        moveTo();
    }

    void moveTo()
    {
        if (isBot2_1)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints2_1[bot2_1Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints2_1[bot2_1Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot21mov = " + bot2_1Mover);
            bot2_1Mover++;
        }

        if (bot2_1Mover > 3)
        {
            bot2_1Mover = 0;
        }


        if (isBot2_2)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints2_2[bot2_2Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints2_2[bot2_2Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot22mov = " + bot2_2Mover);
            bot2_2Mover++;
        }

        if (bot2_2Mover > 3)
        {
            bot2_2Mover = 0;
        }


        if (isBot2_3)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints2_3[bot2_3Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints2_3[bot2_3Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot23mov = " + bot2_3Mover);
            bot2_3Mover++;
        }

        if (bot2_3Mover > 1)
        {
            bot2_3Mover = 0;
        }


        if (isBot2_4)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints2_4[bot2_4Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints2_4[bot2_4Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot24mov = " + bot2_4Mover);
            bot2_4Mover++;
        }

        if (bot2_4Mover > 1)
        {
            bot2_4Mover = 0;
        }


        if (isBot2_5)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints2_5[bot2_5Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints2_5[bot2_5Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot25mov = " + bot2_5Mover);
            bot2_5Mover++;
        }

        if (bot2_5Mover > 1)
        {
            bot2_5Mover = 0;
        }


        if (isBot2_6)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints2_6[bot2_6Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints2_6[bot2_6Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot26mov = " + bot2_6Mover);
            bot2_6Mover++;
        }

        if (bot2_6Mover > 1)
        {
            bot2_6Mover = 0;
        }


        if (isBot2_7)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints2_7[bot2_7Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints2_7[bot2_7Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot27mov = " + bot2_7Mover);
            bot2_7Mover++;
        }

        if (bot2_7Mover > 1)
        {
            bot2_7Mover = 0;
        }


        if (isBot2_8)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints2_8[bot2_8Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints2_8[bot2_8Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot28mov = " + bot2_8Mover);
            bot2_8Mover++;
        }

        if (bot2_8Mover > 1)
        {
            bot2_8Mover = 0;
        }


        if (isBot2_9)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints2_9[bot2_9Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints2_9[bot2_9Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot29mov = " + bot2_9Mover);
            bot2_9Mover++;
        }

        if (bot2_9Mover > 1)
        {
            bot2_9Mover = 0;
        }


        if (isBot2_10)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints2_10[bot2_10Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints2_10[bot2_10Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot210mov = " + bot2_10Mover);
            bot2_10Mover++;
        }

        if (bot2_10Mover > 1)
        {
            bot2_10Mover = 0;
        }
    }
}
