using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Leaderboard : MonoBehaviour
{
    public static Leaderboard Instance; //just to store the score

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public string[] names = new string[3];
    public float[] scores = new float[3];

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tes leaderboard");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
