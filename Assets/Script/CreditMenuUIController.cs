using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditMenuUIController : MonoBehaviour
{
    public Button backButton;


    private void Start()
    {
        backButton.onClick.AddListener(BackButton);
    }

    private void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}