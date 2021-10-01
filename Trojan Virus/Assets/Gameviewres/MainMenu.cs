using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT DIS BICH");
        Application.Quit();
    }

    public void GoToLev()
    {
        SceneManager.LoadScene(2);
    }
}
