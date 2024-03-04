using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol3 : MonoBehaviour
{
    public PatrolPoints patrolpoints;

    public float speed;


    public bool isBot3_1;
    public bool isBot3_2;
    public bool isBot3_3;
    public bool isBot3_4;
    public bool isBot3_5;
    public bool isBot3_6;
    public bool isBot3_7;
    public bool isBot3_8;
    public bool isBot3_9;
    public bool isBot3_10;
    public bool isBot3_11;
    public bool isBot3_12;
    public bool isBot3_13;

    public int bot3_1Mover;
    public int bot3_2Mover;
    public int bot3_3Mover;
    public int bot3_4Mover;
    public int bot3_5Mover;
    public int bot3_6Mover;
    public int bot3_7Mover;
    public int bot3_8Mover;
    public int bot3_9Mover;
    public int bot3_10Mover;
    public int bot3_11Mover;
    public int bot3_12Mover;
    public int bot3_13Mover;

    // Start is called before the first frame update
    void Start()
    {
        bot3_1Mover = 0;
        bot3_2Mover = 0;
        bot3_3Mover = 0;
        bot3_4Mover = 0;
        bot3_5Mover = 0;
        bot3_6Mover = 0;
        bot3_7Mover = 0;
        bot3_8Mover = 0;
        bot3_9Mover = 0;
        bot3_10Mover = 0;
        bot3_11Mover = 0;
        bot3_12Mover = 0;
        bot3_13Mover = 0;
    }

    // Update is called once per frame
    void Update()
    {
        moveTo();
    }

    void moveTo()
    {
        if (isBot3_1)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints3_1[bot3_1Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints3_1[bot3_1Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot31mov = " + bot3_1Mover);
            bot3_1Mover++;
        }

        if (bot3_1Mover > 1)
        {
            bot3_1Mover = 0;
        }


        if (isBot3_2)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints3_2[bot3_2Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints3_2[bot3_2Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot32mov = " + bot3_2Mover);
            bot3_2Mover++;
        }

        if (bot3_2Mover > 1)
        {
            bot3_2Mover = 0;
        }


        if (isBot3_3)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints3_3[bot3_3Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints3_3[bot3_3Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot33mov = " + bot3_3Mover);
            bot3_3Mover++;
        }

        if (bot3_3Mover > 1)
        {
            bot3_3Mover = 0;
        }


        if (isBot3_4)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints3_4[bot3_4Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints3_4[bot3_4Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot34mov = " + bot3_4Mover);
            bot3_4Mover++;
        }

        if (bot3_4Mover > 1)
        {
            bot3_4Mover = 0;
        }


        if (isBot3_5)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints3_5[bot3_5Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints3_5[bot3_5Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot35mov = " + bot3_5Mover);
            bot3_5Mover++;
        }

        if (bot3_5Mover > 1)
        {
            bot3_5Mover = 0;
        }


        if (isBot3_6)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints3_6[bot3_6Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints3_6[bot3_6Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot36mov = " + bot3_6Mover);
            bot3_6Mover++;
        }

        if (bot3_6Mover > 1)
        {
            bot3_6Mover = 0;
        }


        if (isBot3_7)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints3_7[bot3_7Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints3_7[bot3_7Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot37mov = " + bot3_7Mover);
            bot3_7Mover++;
        }

        if (bot3_7Mover > 1)
        {
            bot3_7Mover = 0;
        }


        if (isBot3_8)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints3_8[bot3_8Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints3_8[bot3_8Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot38mov = " + bot3_8Mover);
            bot3_8Mover++;
        }

        if (bot3_8Mover > 1)
        {
            bot3_8Mover = 0;
        }


        if (isBot3_9)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints3_9[bot3_9Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints3_9[bot3_9Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot39mov = " + bot3_9Mover);
            bot3_9Mover++;
        }

        if (bot3_9Mover > 1)
        {
            bot3_9Mover = 0;
        }


        if (isBot3_10)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints3_10[bot3_10Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints3_10[bot3_10Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot310mov = " + bot3_10Mover);
            bot3_10Mover++;
        }

        if (bot3_10Mover > 1)
        {
            bot3_10Mover = 0;
        }


        if (isBot3_11)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints3_11[bot3_11Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints3_11[bot3_11Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot311mov = " + bot3_11Mover);
            bot3_11Mover++;
        }

        if (bot3_11Mover > 1)
        {
            bot3_11Mover = 0;
        }


        if (isBot3_12)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints3_12[bot3_12Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints3_12[bot3_12Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot312mov = " + bot3_12Mover);
            bot3_12Mover++;
        }

        if (bot3_12Mover > 1)
        {
            bot3_12Mover = 0;
        }


        if (isBot3_13)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                patrolpoints.patrolPoints3_13[bot3_13Mover], speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, 
            patrolpoints.patrolPoints3_13[bot3_13Mover]) < 0.001f /*&& i <= 3*/)
        {
            //Debug.Log("Nilai bot313mov = " + bot3_13Mover);
            bot3_13Mover++;
        }

        if (bot3_13Mover > 1)
        {
            bot3_13Mover = 0;
        }
    }
}
