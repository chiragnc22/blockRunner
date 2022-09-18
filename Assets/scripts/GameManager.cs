using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1.5f;
    public GameObject completeLevelUI;
    public movement move;

    public  void completeLevel()
    {
        completeLevelUI.SetActive(true);
        move.enabled = false;    

    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("restart", restartDelay);
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}    
