using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


   public class SceneLoader : MonoBehaviour
{
    // This function will be called by your Start button's OnClick() event.
    // The 'sceneName' parameter allows you to specify which scene to load.
    public void LoadGameScene(string sceneName)
    {
        // Use the static LoadScene method from the SceneManager class.
        // It takes the name of the scene you want to load as an argument.
        SceneManager.LoadScene(sceneName);
    }
    
    // An optional function for quitting the game (often paired with a Quit button)
    public void QuitGame()
    {
        // This only works in a built game (not always in the editor).
        Application.Quit();
        
        // You can add a Debug log for testing in the Unity Editor:
        // Debug.Log("Quitting game..."); 
    }
}
