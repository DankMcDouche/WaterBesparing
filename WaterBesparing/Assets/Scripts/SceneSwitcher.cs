using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneSwitcher : MonoBehaviour
{


    public void GotoStartScene()
    {
        SceneManager.LoadScene("Start");
    }

    public void GotoGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void GotoEndScene()
    {
        SceneManager.LoadScene("End");
    }

}
