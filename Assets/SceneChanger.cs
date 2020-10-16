using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene("Level", LoadSceneMode.Single);
    }

    public void ExitScene()
    {
        Application.Quit();
    }
}
