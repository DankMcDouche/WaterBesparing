using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneSwitcher : MonoBehaviour
{
    public void Start()
    {
        DontDestroyOnLoad(this.gameObject);

    }
    public void GotoStartScene()
    {
        SceneManager.LoadScene("Start");
    }

    public void GotoGameScene()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void GotoEndScene()
    {
        SceneManager.LoadScene("End");
    }

    public void GotoCreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }
}
