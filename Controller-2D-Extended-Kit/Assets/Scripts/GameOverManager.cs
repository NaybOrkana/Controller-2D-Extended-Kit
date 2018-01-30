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

	public string m_LevelToLoad;


	public void OnGameOver()
	{
		m_GOBackground.SetActive (true);
	}

	public void Retry()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}

	public void OnSuccess()
	{
		m_SuccessBackground.SetActive (true);
	}

	public void Next()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}
}
