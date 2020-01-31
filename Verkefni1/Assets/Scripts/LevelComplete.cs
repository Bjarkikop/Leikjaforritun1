using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        //loadar næsta leveli
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
