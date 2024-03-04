using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance;

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

    public float score;

    public void decreaseScore()
    {
        score -= Time.deltaTime;
    }


    // Start is called before the first frame update
    void Start()
    {
        score = 2000;
    }

    // Update is called once per frame
    void Update()
    {
        decreaseScore();
    }
}
