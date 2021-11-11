using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    public GameObject prologue;
    public Button start;

    void Start()
    {
        start.onClick.AddListener(StartGame);
    }

    public void StartGame()
    {
        prologue.gameObject.SetActive(true);
    }

    public void Quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}