using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenEscPushed : MonoBehaviour
{
    private bool isPaused = false;
    public AudioSource musicSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            {
                if (isPaused)
                {
                    ResumeGame();
                }
                else
                {
                    PauseTheGame();
                }
            }
        }


    }
    void PauseTheGame()
    {
        Time.timeScale = 0f;  // 時間を停止
        musicSource.Pause();
        isPaused = true;
    }

    void ResumeGame()
    {
        Time.timeScale = 1f;  // 時間を再開
        musicSource.Play();
        isPaused = false;
    }
}
