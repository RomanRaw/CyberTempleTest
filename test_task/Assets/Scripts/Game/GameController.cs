using System;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static Action RefillLives;
    public static Action BackToMainMenu;
    public static Action ResetLives;

    public void CallRefillLIves()
    {
        RefillLives?.Invoke();
    }
    public void CallBackToMainMenu()
    {
        BackToMainMenu?.Invoke();
    }
    public void CallResetLives()
    {
        ResetLives?.Invoke();
    }
}
