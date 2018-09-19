using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneString : MonoBehaviour
{

    // Function to load a scene by a scene name
    public void LoadByString(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
