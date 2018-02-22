using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelector : MonoBehaviour
{
	public SceneFader m_Fader;

	public void SelectLevel(string levelName)
	{
		m_Fader.FadeTo (levelName);
	}
}
