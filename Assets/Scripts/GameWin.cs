using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
    public GameObject endgameUI;

    // Brings up the UI to congratulate the player and return them to the main menu.
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            endgameUI.SetActive(true);
            Debug.Log("You won!");
        }
    }

    // Returns to the main menu from easy difficulty.
    public void MainMenuEasy()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    // Returns to the main menu from medium difficulty.
    public void MainMenuMedium()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    // Returns to the main menu from hard difficulty.
    public void MainMenuHard()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
