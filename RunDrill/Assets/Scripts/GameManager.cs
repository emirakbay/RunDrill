using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool gameHasEnded = false;
    public bool levelHasEnded = false;

    public float restartDelay = 3f;

    public void RestartGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GameOver");
            Invoke(nameof(LoadSceneAgain), restartDelay);
        }
    }

    public void NextLevel()
    {
        if (levelHasEnded == false)
        {
            levelHasEnded = true;
            Debug.Log("LevelOver");
            Invoke(nameof(LoadNextLevel), restartDelay);
        }
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void LoadSceneAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
