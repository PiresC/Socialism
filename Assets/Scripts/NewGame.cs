using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
	public GameObject MainMenu;
	public GameObject OptionsMenu;
    public GameObject miniGameMenu;

	public void LoadByIndex(){
		SceneManager.LoadScene(9);
	}

    public void BacktoMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void options() {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }
 
    public void back() {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
    }

	public void quit(){
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#else
			Application.Quit();
		#endif
	}

    public void miniGame()
    {
        MainMenu.SetActive(false);
        miniGameMenu.SetActive(true);
    }

    public void miniGameBack()
    {
        miniGameMenu.SetActive(false);
        MainMenu.SetActive(true);
    }


    public void normal()
    {
        SceneManager.LoadScene(4);
    }

    public void hard()
    {
        SceneManager.LoadScene(5);
    }

}
