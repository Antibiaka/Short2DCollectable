using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textScore;

    public void Update() {
        textScore.text = "" + PlayerMovement.Score;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        PlayerMovement.Score = 0;
    }
    public void resetScore() {
        PlayerMovement.Score = 0;
    }

    public void doExitGame() {
        Application.Quit();
    }
}
