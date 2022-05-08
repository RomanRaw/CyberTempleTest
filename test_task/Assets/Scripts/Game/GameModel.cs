using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameModel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI livesCountText;

    private int livesCount;
    public void Start()
    {
        GameController.RefillLives += RefillLives;
        GameController.BackToMainMenu += LoadMenu;
        GameController.ResetLives += ResetLives;
        livesCount = PlayerPrefs.GetInt("lives");
        livesCountText.text = livesCount.ToString();
    }
    public void RefillLives()
    {
        livesCount++;
        PlayerPrefs.SetInt("lives", livesCount);
        livesCountText.text = livesCount.ToString();
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void ResetLives()
    {
        livesCount = 0;
        livesCountText.text = livesCount.ToString();
        PlayerPrefs.SetInt("lives", livesCount);
    }
}
