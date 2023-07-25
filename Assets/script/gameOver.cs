using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public GameObject Pause;
    public void playAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void quit()
    {
        Application.Quit();
    }
    public void nextLV()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void PauseUI()
    {
        Time.timeScale = 0;
        Pause.gameObject.SetActive(true);
        AudioListener.volume = 0f;
    }
    public void Main()
    {
        SceneManager.LoadScene("main");
        AudioListener.volume = 1f;
    }
    public void resume()
    {
        Time.timeScale = 1;
        Pause.gameObject.SetActive(false);
        AudioListener.volume = 1f;
    }
}
