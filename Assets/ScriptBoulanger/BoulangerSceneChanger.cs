using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoulangerSceneChanger : MonoBehaviour
{
    public static bool isPressed = false;

    public void Change(string name)
    {
        SceneManager.LoadScene(name);
        isPressed = true;
    }
}
