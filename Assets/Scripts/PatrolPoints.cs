using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolPoints : MonoBehaviour
{
    //LEVEL 1
    public Vector3[] patrolPoints = new Vector3[4];

    public Vector3[] patrolPoints2 = new Vector3[2];

    public Vector3[] patrolPoints3 = new Vector3[2];

    //LEVEL 2
    public Vector3[] patrolPoints2_1 = new Vector3[4];
    public Vector3[] patrolPoints2_2 = new Vector3[4];
    public Vector3[] patrolPoints2_3 = new Vector3[2];
    public Vector3[] patrolPoints2_4 = new Vector3[2];
    public Vector3[] patrolPoints2_5 = new Vector3[2];
    public Vector3[] patrolPoints2_6 = new Vector3[2];
    public Vector3[] patrolPoints2_7 = new Vector3[2];
    public Vector3[] patrolPoints2_8 = new Vector3[2];
    public Vector3[] patrolPoints2_9 = new Vector3[2];
    public Vector3[] patrolPoints2_10 = new Vector3[2];

    //LEVEL 3
    public Vector3[] patrolPoints3_1 = new Vector3[2];
    public Vector3[] patrolPoints3_2 = new Vector3[2];
    public Vector3[] patrolPoints3_3 = new Vector3[2];
    public Vector3[] patrolPoints3_4 = new Vector3[2];
    public Vector3[] patrolPoints3_5 = new Vector3[2];
    public Vector3[] patrolPoints3_6 = new Vector3[2];
    public Vector3[] patrolPoints3_7 = new Vector3[2];
    public Vector3[] patrolPoints3_8 = new Vector3[2];
    public Vector3[] patrolPoints3_9 = new Vector3[2];
    public Vector3[] patrolPoints3_10 = new Vector3[2];
    public Vector3[] patrolPoints3_11 = new Vector3[2];
    public Vector3[] patrolPoints3_12 = new Vector3[2];
    public Vector3[] patrolPoints3_13 = new Vector3[2];



    // Start is called before the first frame update
    void Start()
    {
        //LEVEL 1
        patrolPoints[0] = new Vector3(8f, 4.25f, -1);
        patrolPoints[1] = new Vector3(8f, -4.25f, -1);
        patrolPoints[2] = new Vector3(-8f, -4.25f, -1);
        patrolPoints[3] = new Vector3(-8f, 4.25f, -1);

        patrolPoints2[0] = new Vector3(0, 3, -1);
        patrolPoints2[1] = new Vector3(0, -3, -1);

        patrolPoints3[0] = new Vector3(6.75f, 0, -1);
        patrolPoints3[1] = new Vector3(-6.75f, 0, -1);

        //LEVEL 2
        patrolPoints2_1[0] = new Vector3(-17.3f, 5.27f, -1);
        patrolPoints2_1[1] = new Vector3(-17.3f, 7.31f, -1);
        patrolPoints2_1[2] = new Vector3(-13.42f, 7.31f, -1);
        patrolPoints2_1[3] = new Vector3(-13.42f, 5.27f, -1);

        patrolPoints2_2[0] = new Vector3(-13.47f, 1.01f, -1);
        patrolPoints2_2[1] = new Vector3(-13.47f, -0.97f, -1);
        patrolPoints2_2[2] = new Vector3(-17.39f, -0.97f, -1);
        patrolPoints2_2[3] = new Vector3(-17.39f, 1.01f, -1);

        patrolPoints2_3[0] = new Vector3(20.17f, 7.36f, -1);
        patrolPoints2_3[1] = new Vector3(-12.11f, 7.36f, -1);

        patrolPoints2_4[0] = new Vector3(-8.58f, 0.87f, -1);
        patrolPoints2_4[1] = new Vector3(-0.91f, 0.87f, -1);

        patrolPoints2_5[0] = new Vector3(-0.92f, 6.24f, -1);
        patrolPoints2_5[1] = new Vector3(-0.92f, -0.98f, -1);

        patrolPoints2_6[0] = new Vector3(-7.45f, 5.25f, -1);
        patrolPoints2_6[1] = new Vector3(4.65f, 5.25f, -1);

        patrolPoints2_7[0] = new Vector3(4.63f, 0.23f, -1);
        patrolPoints2_7[1] = new Vector3(4.71f, 6.03f, -1);

        patrolPoints2_8[0] = new Vector3(9.27f, 6.1f, -1);
        patrolPoints2_8[1] = new Vector3(9.27f, -0.96f, -1);

        patrolPoints2_9[0] = new Vector3(14.78f, -3.97f, -1);
        patrolPoints2_9[1] = new Vector3(14.78f, 6.05f, -1);

        patrolPoints2_10[0] = new Vector3(20.29f, 1.26f, -1);
        patrolPoints2_10[1] = new Vector3(20.29f, -4, -1);

        //LEVEL 3
        patrolPoints3_1[0] = new Vector3(-2.15f, 1.02f, -1);
        patrolPoints3_1[1] = new Vector3(-5.32f, 1.02f, -1);

        patrolPoints3_2[0] = new Vector3(-5.27f, 3.29f, -1);
        patrolPoints3_2[1] = new Vector3(-2.3f, 3.29f, -1);

        patrolPoints3_3[0] = new Vector3(-5.13f, 4.34f, -1);
        patrolPoints3_3[1] = new Vector3(-5.13f, 11.56f, -1);

        patrolPoints3_4[0] = new Vector3(-2.44f, 11.25f, -1);
        patrolPoints3_4[1] = new Vector3(-2.44f, 4.53f, -1);
        
        patrolPoints3_5[0] = new Vector3(3.45f, 0.95f, -1);
        patrolPoints3_5[1] = new Vector3(-0.61f, 0.95f, -1);

        patrolPoints3_6[0] = new Vector3(3.3f, 11.48f, -1);
        patrolPoints3_6[1] = new Vector3(3.3f, 3.08f, -1);

        patrolPoints3_7[0] = new Vector3(-1.09f, 6.31f, -1);
        patrolPoints3_7[1] = new Vector3(2.24f, 6.31f, -1);

        patrolPoints3_8[0] = new Vector3(9.22f, 10.31f, -1);
        patrolPoints3_8[1] = new Vector3(18.79f, 10.31f, -1);

        patrolPoints3_9[0] = new Vector3(6.44f, 11.57f, -1);
        patrolPoints3_9[1] = new Vector3(6.44f, 3, -1);

        patrolPoints3_10[0] = new Vector3(9.33f, 2.8f, -1);
        patrolPoints3_10[1] = new Vector3(9.33f, 11.45f, -1);

        patrolPoints3_11[0] = new Vector3(14.16f, 10.29f, -1);
        patrolPoints3_11[1] = new Vector3(14.16f, 0.29f, -1);

        patrolPoints3_12[0] = new Vector3(18.77f, -1.1f, -1);
        patrolPoints3_12[1] = new Vector3(18.77f, 10.21f, -1);

        patrolPoints3_13[0] = new Vector3(13.2f, 0.3f, -1);
        patrolPoints3_13[1] = new Vector3(18.82f, 0.3f, -1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
