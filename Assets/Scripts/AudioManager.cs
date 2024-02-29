using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AudioManager : MonoBehaviour
{
    
    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource;
    public GameObject sfXAudioSource2;
	private void Start()
	{
		PlayBGM();
	}
	
	public void PlayBGM() { 
        bgmAudioSource.Play();
    }
	
	public void PlaySFX(Vector3 spawnPosition) { 
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySFX2(Vector3 spawnPosition) { 
        GameObject.Instantiate(sfXAudioSource2, spawnPosition, Quaternion.identity);
    }
}