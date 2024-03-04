using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI playerScore;
    public TextMeshProUGUI playerName;

    // Start is called before the first frame update
    void Start()
    {
        playerName.text = Nickname.Instance.RealPlayerName;
    }

    // Update is called once per frame
    void Update()
    {
        playerScore.text = ScoreCounter.Instance.score.ToString("f1");
    }
}
