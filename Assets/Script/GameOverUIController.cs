using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{
    public Button mainMenuButton;

    // Start is called before the first frame update
    private void Start()
    {
        // setup event saat button di klik
        mainMenuButton.onClick.AddListener(MainMenu);
    }

    // Update is called once per frame
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
