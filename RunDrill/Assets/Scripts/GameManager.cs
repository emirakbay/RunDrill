using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool gameHasEnded = false;

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

    void LoadSceneAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
