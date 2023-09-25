using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneLoader
{
    public static void LoadScene(int index)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(index);
    }

    public static void ReloadScene()
    {
        LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
