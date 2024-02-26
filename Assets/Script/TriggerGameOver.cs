using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TriggerGameOver : MonoBehaviour
{
  public Collider bola;
  public GameObject gameOverCanvas;
  

  private void OnTriggerEnter(Collider other)
  {
    if (other == bola)
    {
			// kembali ke main menu
	    gameOverCanvas.SetActive(true);
    }
  }
}