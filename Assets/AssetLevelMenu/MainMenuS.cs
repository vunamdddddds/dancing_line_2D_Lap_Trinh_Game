using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuS : MonoBehaviour
{
    public GameObject musicButtonOff;
    public GameObject musicButtonOn;
    private bool EnableMusic = true;
    public void Playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit");
    }

    public void MusicOn()
    {
        //kode untuk toggle musik
        if (EnableMusic == true)
        {
            EnableMusic = false;
            AudioListener.pause = true;
            musicButtonOn.SetActive(false);
            musicButtonOff.SetActive(true);
            Debug.Log("Music Off");
        }
        else
        {
            EnableMusic = true;
            AudioListener.pause = false;
            musicButtonOn.SetActive(true);
            musicButtonOff.SetActive(false);
            Debug.Log("Music On");
        }
    }
}
