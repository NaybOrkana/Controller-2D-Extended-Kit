using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverManager : MonoBehaviour
{
	public GameObject m_GOBackground;
	public GameObject m_SuccessBackground;

	public SceneFader m_SceneFader;
	public string m_LevelToLoad;

	public void OnGameOver()
	{
		m_GOBackground.SetActive (true);
		PauseMenu.m_CanGameBePaused = false;
	}

	public void Retry()
	{
		PauseMenu.m_CanGameBePaused = true;
		m_SceneFader.FadeTo (SceneManager.GetActiveScene().name);
	}

	public void OnSuccess()
	{
		m_SuccessBackground.SetActive (true);
		PauseMenu.m_CanGameBePaused = false;
	}

	public void Next()
	{
		PauseMenu.m_CanGameBePaused = true;
		GoalManager.m_ReachedGoal = false;
		m_SceneFader.FadeTo(m_LevelToLoad);
	}
}
