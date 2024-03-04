using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public KeyCode PauseKey;
    public KeyCode UnpauseKey;
    private Canvas cnv;

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoToLevelMenu()
    {
        SceneManager.LoadScene("LevelMenu");
    }

    public void GoToHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void GoToNickname()
    {
        SceneManager.LoadScene("Nickname");
    }

    public void GoToLeaderboard()
    {
        SceneManager.LoadScene("Leaderboard");
    }

    public void GoToLevel1()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1;
    }

    public void GoToLevel3()
    {
        SceneManager.LoadScene("Level3");
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        Time.timeScale = 1;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Destroy(GameObject.Find("ScoreCounter"));
        Destroy(GameObject.Find("Name"));
    }

    public void PauseGame()
    {
        if (Input.GetKeyDown(PauseKey))
        {
            Time.timeScale = 0;
            cnv.enabled = true;
        }

        if (Input.GetKeyDown(UnpauseKey))
        {
            Time.timeScale = 1;
            cnv.enabled = false;    
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        cnv = GetComponent<Canvas>();

        SaveData saveData = SaveManager.LoadGameState();
        if(saveData != null)
        {
            Leaderboard.Instance.names[0] = saveData.savednames[0];
            Leaderboard.Instance.names[1] = saveData.savednames[1];
            Leaderboard.Instance.names[2] = saveData.savednames[2];

            Leaderboard.Instance.scores[0] = saveData.savedscores[0];
            Leaderboard.Instance.scores[1] = saveData.savedscores[1];
            Leaderboard.Instance.scores[2] = saveData.savedscores[2];
        }
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
    }
}
