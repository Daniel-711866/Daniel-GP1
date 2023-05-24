using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_Respawn : MonoBehaviour
{

    public void update()
    {
        ResetTheGame();
    }

   public void ResetTheGame()
    {
        if (Health.currentHealth == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
