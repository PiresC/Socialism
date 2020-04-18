using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public static bool GameIsPaused = false;
	
	public GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){

			if(GameIsPaused){
				Resume();
			}else{
				Pause();
			}

		}
    }

	void Resume(){
		pauseMenu.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	void Pause(){
		pauseMenu.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

    public void BacktoMainMenu()
    {
        SceneManager.LoadScene(0);
    }


}
