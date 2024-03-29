﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public LevelComplete LevelSelesai;
    
    public void EndGame() 
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");

            // Restart game
            Invoke("Restart", restartDelay);
        }   
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        StartCoroutine(delay());
    }

    IEnumerator delay()
    {
        completeLevelUI.SetActive(true);
        yield return new WaitForSeconds(1);
        LevelSelesai.LoadNextLevel();
    }
}