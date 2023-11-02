using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitching : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SceneManager.sceneCountInBuildSettings);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GetNextScene();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            GetPreviousScene();
        }
    }

    void GetNextScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        int nextScene = currentScene + 1;

        if(nextScene >= SceneManager.sceneCountInBuildSettings)
        {
            nextScene = 0;
        }
        
        SceneManager.LoadScene(nextScene);
    }

    void GetPreviousScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        int prevScene = currentScene - 1;

        if(prevScene < 0)
        {
            prevScene = SceneManager.sceneCountInBuildSettings - 1;
        }

        SceneManager.LoadScene(prevScene);
    }

}
