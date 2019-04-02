using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public void ChangeScene() {
        SceneManager.LoadScene("Game");
    }

    public void GoToCredits()
    {

        SceneManager.LoadScene("Credits");
    }

    public void GoToMenu() {
        SceneManager.LoadScene("Preloader");
    }


}
