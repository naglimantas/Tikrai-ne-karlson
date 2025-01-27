using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string sceneName;
    void Start()
    {
        Cursor.lockState = CursorLockMode.None; 
        Cursor.visible = true;                  
        Time.timeScale = 1f;                    
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(sceneName);
    }
}
