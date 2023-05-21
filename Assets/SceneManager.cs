using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void SwitchToStory()
    {
        Debug.Log("Switching to story");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Story");
    }

    public void SwitchToMenu()
    {
        Debug.Log("Switching to menu");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }
}
