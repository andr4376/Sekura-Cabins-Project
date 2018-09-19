using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    /// <summary>
    /// loads a scene depending on the index
    /// </summary>
    /// <param name="SceneIndex"></param>
    public void LoadByIndex(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }
}
