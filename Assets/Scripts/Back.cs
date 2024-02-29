using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Back : MonoBehaviour
{
  public Button MenuButton;

  private void Start()
  {
    MenuButton.onClick.AddListener(MainMenu);
  }

  public void MainMenu()
  {
    SceneManager.LoadScene("MainMenu");
  }
}