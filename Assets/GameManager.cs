using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    public GameObject endGame;
    public Transform player;

    public void Play()
    {
        Restart();
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        CompleteLevel();
        Pause();
    }
    public void Restart()
    {

    }


}
