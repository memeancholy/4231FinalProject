using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
    public GameObject endgameUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            endgameUI.SetActive(true);
            Debug.Log("You won!");
        }
    }

    // Returns to the main menu
    public void MainMenuEasy()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    // Returns to the main menu
    public void MainMenuMedium()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    // Returns to the main menu
    public void MainMenuHard()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
