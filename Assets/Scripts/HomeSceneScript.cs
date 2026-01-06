using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeSceneScript : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }
    public void JetEngineScene()
    {
        SceneManager.LoadScene(1);
    }
    public void CarScene()
    {
        SceneManager.LoadScene(2);
    }

}
