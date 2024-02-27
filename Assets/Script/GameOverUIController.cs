using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{
    public Button mainMenuButton;
    public Button retryButton;

    // Start is called before the first frame update
    private void Start()
    {
        // setup event saat button di klik
        mainMenuButton.onClick.AddListener(MainMenu);
        retryButton.onClick.AddListener(Retry);
    }

    // Update is called once per frame
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Retry()
    {
        // SceneManager.LoadScene("4");
        RestartScene();

    }

        void RestartScene()
    {
        // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Reload the current scene
        SceneManager.LoadScene(currentSceneIndex);
    }
}
