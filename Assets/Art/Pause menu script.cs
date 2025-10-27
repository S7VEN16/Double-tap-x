using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenuscript : MonoBehaviour
{

    // A reference to the entire pause menu UI panel
    public GameObject pauseMenuUI;

    // A static boolean to check the game state from anywhere
    public static bool GameIsPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check for the escape key or other designated pause button
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

        // Function to resume the game
    public void Resume()
    {
        // 1. Hide the pause menu UI
        pauseMenuUI.SetActive(false);
        // 2. Set the time scale back to normal (1 = real-time)
        Time.timeScale = 1f;
        // 3. Update the game state flag
        GameIsPaused = false;
    }

    // Function to pause the game
    void Pause()
    {
        // 1. Show the pause menu UI
        pauseMenuUI.SetActive(true);
        // 2. Set the time scale to zero (stops all movement/physics/updates that rely on Time.deltaTime)
        Time.timeScale = 0f;
        // 3. Update the game state flag
        GameIsPaused = true;
    }

    // Function to handle loading the main menu scene
    public void LoadMenu()
    {
        // Make sure to unpause time before leaving the scene
        Time.timeScale = 1f;
        // Replace "MainMenuSceneName" with the actual name of your main menu scene
        SceneManager.LoadScene("Start"); 
    }

    // Function to handle quitting the application (only works in a built game)
    public void QuitGame()
    {
        Application.Quit();
        // For testing in the Unity Editor:
        // Debug.Log("Quitting game..."); 
    }
}
