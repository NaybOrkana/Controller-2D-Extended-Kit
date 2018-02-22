using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
	public static CameraShake m_Instance;

	private Vector3 m_OriginalPosition;
	private float m_TimeAtCurrentFrame;
	private float m_TimeAtLastFrame;
	private float m_FakeDelta;

	private void Awake()
	{
		m_Instance = this;
	}

	private void Update()
	{
		m_TimeAtCurrentFrame = Time.realtimeSinceStartup;

		m_FakeDelta = m_TimeAtCurrentFrame - m_TimeAtLastFrame;
		m_TimeAtLastFrame = m_TimeAtCurrentFrame;
	}

	public static void Shake(float duration, float amount)
	{
		m_Instance.m_OriginalPosition = m_Instance.gameObject.transform.position;

		m_Instance.StopAllCoroutines ();
		m_Instance.StartCoroutine (m_Instance.cShake(duration, amount));
	}

	private IEnumerator cShake(float duration, float amount)
	{

		while (duration > 0) {
			transform.localPosition = m_OriginalPosition + Random.insideUnitSphere * amount;

			duration -= m_FakeDelta;

			yield return null;
		}

		transform.localPosition = m_OriginalPosition;
	}

}
