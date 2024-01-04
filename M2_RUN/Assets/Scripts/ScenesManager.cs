using UnityEngine;
using UnityEngine.SceneManagement;


public class ScenesManager: MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }


    public void RestartGame()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
