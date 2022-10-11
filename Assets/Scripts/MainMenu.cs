using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() { 
        Debug.Log("Play Pressed!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame() {
        Debug.Log("Game Closed!");
        Application.Quit();
    }

    public void SettingGame() {
        Debug.Log("Settings Pressed!");
    }
}
