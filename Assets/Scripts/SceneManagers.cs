	using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagers : MonoBehaviour {

	
	
	// Update is called once per frame
	void FixedUpdate () {
		if(PlayerHealth.currentHealth <= 0 && PlayerHealth.gameStart)
		{
			PlayerHealth.gameStart = false;
			LoseScene();
		}else if(Score.score == 30 && PlayerHealth.gameStart)
		{
			PlayerHealth.gameStart = false;
			SurviveScene();
		}
		if(Input.GetKeyUp(KeyCode.Escape) && !PlayerHealth.gameStart)
		{
			MainMenu();
		}
	}

	public void SurviveScene () {
		SceneManager.LoadScene("SurviveScene");
	}

	public void LoseScene () {
		SceneManager.LoadScene("LoseScene");
	}

	public void StartGame () {
		SceneManager.LoadScene("GameScene");
	}

	public void MainMenu () {
		SceneManager.LoadScene("MainMenu");
	}

	public void ExitGame () {
		Application.Quit();
	}
}
