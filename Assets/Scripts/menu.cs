using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    public void PalypenguinsGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void PlayHummingBirdGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void PalindromeWorld()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void MatchingParenthesisWorld()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void Quit()
    {
        #if UNITY_EDITOR                UnityEditor.EditorApplication.isPlaying = false;        #else                Application.Quit();        #endif        //UnityEditor.EditorApplication.isPlaying = false;    }

    
    public void OpenLink()
    {
        
        Application.OpenURL("http://www.niazilab.com");
    }
}


