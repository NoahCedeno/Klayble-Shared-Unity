using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GoToMainMenuScene()
    {
        SceneManager.LoadScene(sceneName: "MainMenu");
    }

    public void GoToBattleScene()
    {
        SceneManager.LoadScene(sceneName: "BattleScene");
    }
}
