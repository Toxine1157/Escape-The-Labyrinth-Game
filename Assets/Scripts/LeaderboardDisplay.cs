using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LeaderboardDisplay : MonoBehaviour
{
    public TextMeshProUGUI savedname1; //highest
    public TextMeshProUGUI savedname2;
    public TextMeshProUGUI savedname3; //lowest

    public TextMeshProUGUI savedscore1; //highest
    public TextMeshProUGUI savedscore2;
    public TextMeshProUGUI savedscore3; //lowest

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Destroy(GameObject.Find("ScoreCounter"));
        Destroy(GameObject.Find("Name"));
    }

    public void CompareScore()
    {
        if (ScoreCounter.Instance == null)
        {
            return;
        }

        if (ScoreCounter.Instance.score > Leaderboard.Instance.scores[0]) //skor tertinggi
        {
            Debug.Log("ngitung 1");

            Leaderboard.Instance.scores[2] = Leaderboard.Instance.scores[1];
            Leaderboard.Instance.scores[1] = Leaderboard.Instance.scores[0];
            Leaderboard.Instance.scores[0] = ScoreCounter.Instance.score;

            Leaderboard.Instance.names[2] = Leaderboard.Instance.names[1];
            Leaderboard.Instance.names[1] = Leaderboard.Instance.names[0];
            Leaderboard.Instance.names[0] = Nickname.Instance.RealPlayerName;
            Debug.Log("Nama juara 1");
        }

        if (ScoreCounter.Instance.score > Leaderboard.Instance.scores[1] &&
            ScoreCounter.Instance.score < Leaderboard.Instance.scores[0]) //skor tengah
        {
            Debug.Log("ngitung 2");

            Leaderboard.Instance.scores[2] = Leaderboard.Instance.scores[1];
            Leaderboard.Instance.scores[1] = ScoreCounter.Instance.score;

            Leaderboard.Instance.names[2] = Leaderboard.Instance.names[1];
            Leaderboard.Instance.names[1] = Nickname.Instance.RealPlayerName;
            Debug.Log("Nama juara 2");
        }

        if (ScoreCounter.Instance.score > Leaderboard.Instance.scores[2] &&
            ScoreCounter.Instance.score < Leaderboard.Instance.scores[1]) //skor terendah
        {
            Debug.Log("ngitung 3");

            Leaderboard.Instance.scores[2] = ScoreCounter.Instance.score;

            Leaderboard.Instance.names[2] = Nickname.Instance.RealPlayerName;
            Debug.Log("Nama juara 3");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        CompareScore();

        savedname1.text = Leaderboard.Instance.names[0];
        savedname2.text = Leaderboard.Instance.names[1];
        savedname3.text = Leaderboard.Instance.names[2];

        savedscore1.text = Leaderboard.Instance.scores[0].ToString("f1");
        savedscore2.text = Leaderboard.Instance.scores[1].ToString("f1");
        savedscore3.text = Leaderboard.Instance.scores[2].ToString("f1");

        // Percobaan ngesave
        SaveData saveData = new SaveData();
        saveData.savednames[0] = Leaderboard.Instance.names[0];
        saveData.savednames[1] = Leaderboard.Instance.names[1];
        saveData.savednames[2] = Leaderboard.Instance.names[2];

        saveData.savedscores[0] = Leaderboard.Instance.scores[0];
        saveData.savedscores[1] = Leaderboard.Instance.scores[1];
        saveData.savedscores[2] = Leaderboard.Instance.scores[2];
        SaveManager.SaveGameState(saveData);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
