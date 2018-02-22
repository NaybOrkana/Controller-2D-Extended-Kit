using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public static bool m_IsGamePaused = false;
	public static bool m_CanGameBePaused = true;

	public GameObject m_PauseMenuUI;
	public SceneFader m_SceneFader;
	public string m_SceneToLoad;

	private void Update()
	{
		if (m_CanGameBePaused) 
		{
			if (Input.GetKeyDown(KeyCode.Escape)) 
			{
				if (m_IsGamePaused) 
				{
					Resume ();
				} 
				else
				{
					Pause ();
				}
			}
		}
	}

	public void Resume()
	{
		m_PauseMenuUI.SetActive (false);

		Time.timeScale = 1f;

		m_IsGamePaused = false;
	}

	private void Pause()
	{
		m_PauseMenuUI.SetActive (true);

		Time.timeScale = 0f;

		m_IsGamePaused = true;
	}

	public void LoadMenu()
	{
		GoalManager.m_ReachedGoal = false;
		m_CanGameBePaused = true;
		
		Resume ();

		m_SceneFader.FadeTo(m_SceneToLoad);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}

}
