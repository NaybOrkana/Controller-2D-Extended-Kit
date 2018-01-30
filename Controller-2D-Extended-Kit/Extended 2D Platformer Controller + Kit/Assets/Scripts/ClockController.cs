using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClockController : MonoBehaviour
{
	public float m_InitialTime;
	[HideInInspector]
	public float m_CurrentTime;
	[HideInInspector]
	public bool m_StopTheClock = false; 

	public TextMeshProUGUI m_TimeDisplay;

	private GameOverManager m_GameOverManager;


	private void Awake()
	{
		m_CurrentTime = m_InitialTime;
	}

	private void Start()
	{
		m_GameOverManager = GetComponent<GameOverManager> ();

		m_TimeDisplay.text = m_InitialTime.ToString ("F");
		Player.m_CanMove = true;
	}

	private void Update()
	{
		if (m_CurrentTime <= 0f)
		{
			m_CurrentTime = 0f;
			Player.m_CanMove = false;

			m_GameOverManager.OnGameOver ();
		} 
		else if (m_CurrentTime > 0f)
		{
			if (!m_StopTheClock)
			{
				m_CurrentTime -= Time.deltaTime;
			} 
			else 
			{
				Player.m_CanMove = false;

			}
		}
		
		m_TimeDisplay.text = m_CurrentTime.ToString ("0:00.0");
	}
}
