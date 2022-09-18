using UnityEngine;
using UnityEngine.SceneManagement;


public class StartGame : MonoBehaviour
{
    public void start_Game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Enjoy");
    }    
}
