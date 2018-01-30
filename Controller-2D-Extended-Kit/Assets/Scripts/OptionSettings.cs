using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionSettings : MonoBehaviour 
{
	public AudioMixer m_AudioMixer;
	public Dropdown m_ResolutionDropdown;

	private Resolution[] m_Resolutions;

	private void Start()
	{
		m_Resolutions = Screen.resolutions;

		m_ResolutionDropdown.ClearOptions ();

		List <string> options = new List <string> ();

		int currentResolutionIndex = 0;

		for (int i = 0; i < m_Resolutions.Length; i++)
		{
			string option = m_Resolutions [i].width + "x" + m_Resolutions [i].height;
			options.Add (option);

			if (m_Resolutions[i].width == Screen.currentResolution.width && m_Resolutions[i].height == Screen.currentResolution.height) 
			{
				currentResolutionIndex = i;
			}
		}

		m_ResolutionDropdown.AddOptions (options);
		m_ResolutionDropdown.value = currentResolutionIndex;
		m_ResolutionDropdown.RefreshShownValue ();
	}

	public void SetResolution(int resolutionIndex)
	{
		Resolution resolution = m_Resolutions [resolutionIndex];

		Screen.SetResolution (resolution.width, resolution.height, Screen.fullScreen);
	}

	public void SetVolume(float volume)
	{
		m_AudioMixer.SetFloat ("volume", volume);
	}

	public void SetQuality(int qualityIndex)
	{
		QualitySettings.SetQualityLevel (qualityIndex);
	}

	public void SetFullscreen(bool isFullscreen)
	{
		Screen.fullScreen = isFullscreen;
	}
}
