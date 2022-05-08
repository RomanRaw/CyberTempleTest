using System;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public static Action PlayGame;
    public static Action QuitGame;

    public void CallPlayGame()
    {
        PlayGame?.Invoke();
    }
    public void CallQuitGame()
    {
        QuitGame?.Invoke();
    }
}