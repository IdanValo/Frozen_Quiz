using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCategories : MonoBehaviour
{
    public void LoadLevels(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
