using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("stage");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void LV1()
    {
        SceneManager.LoadScene("level0");
    }
    public void LV2()
    {
        SceneManager.LoadScene("level1");
    }
    public void LV3()
    {
        SceneManager.LoadScene("level2");
    }
    public void LV4()
    {
        SceneManager.LoadScene("level0.5");
    }
}
