using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button creditButton;
    // public Button backButton;


    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
        creditButton.onClick.AddListener(CreditMenu);
        // backButton.onClick.AddListener(BackButton);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("5");
    }

      private void ExitGame()
    {
        Application.Quit();
    }

    private void CreditMenu()
    {
        SceneManager.LoadScene("CreditMenu");
    }

    // private void BackButton()
    // {
    //     SceneManager.LoadScene("MainMenu");
    // }
}