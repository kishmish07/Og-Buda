using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_music : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AudioSource audioSource;
    float musicVolume = 1f;
    void Update()
    {
        audioSource.volume = musicVolume;
    }
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
    public void DeActivate()
    {
        gameObject.SetActive(false);
    }
}
