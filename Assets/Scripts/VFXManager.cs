using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxSource;
    public GameObject vfxSource2;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PlayVFX(Vector3 spawnPosition)
	{
		GameObject.Instantiate(vfxSource, spawnPosition, Quaternion.identity);
	}

    public void PlayVFX2(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxSource2, spawnPosition, Quaternion.identity);
    }
}
