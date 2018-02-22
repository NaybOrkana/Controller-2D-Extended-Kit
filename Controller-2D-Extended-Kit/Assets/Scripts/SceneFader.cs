﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour 
{
	public Image m_Img;
	public AnimationCurve m_FadeCurve;

	private void Start()
	{
		StartCoroutine (FadeIn ());
	}

	public void FadeTo(string scene)
	{
		StartCoroutine (FadeOut (scene));
	}


	private IEnumerator FadeIn()
	{
		float time = 1f;

		while (time > 0f) 
		{
			time -= Time.deltaTime;

			float alpha = m_FadeCurve.Evaluate (time);

			m_Img.color = new Color (0f, 0f, 0f, alpha);
			yield return 0;
		}


	}


	private IEnumerator FadeOut(string scene)
	{
		float time = 0f;

		while (time < 1f) 
		{
			time += Time.deltaTime;

			float alpha = m_FadeCurve.Evaluate (time);

			m_Img.color = new Color (0f, 0f, 0f, alpha);
			yield return 0;
		}

		SceneManager.LoadScene (scene);
	}


}
