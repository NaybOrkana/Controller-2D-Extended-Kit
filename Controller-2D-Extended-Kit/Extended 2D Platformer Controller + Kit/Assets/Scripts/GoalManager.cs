using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
	[HideInInspector]
	public static bool m_ReachedGoal = false; 

	public GameOverManager m_GOM;
	public ClockController m_ClockManager;

	private void Update()
	{
		if (m_ReachedGoal) 
		{
			m_GOM.OnSuccess ();
			m_ClockManager.m_StopTheClock = true;
		}
	}
}
