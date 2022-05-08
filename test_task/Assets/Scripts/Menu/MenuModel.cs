using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuModel : MonoBehaviour {
    public void Start()
    {
        MenuController.PlayGame += LoadLevel;
        MenuController.QuitGame += Quit;
    }
    public void LoadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Quit()
    {
        Debug.Log("Quit");
        // Application.Quit();
    }
}
