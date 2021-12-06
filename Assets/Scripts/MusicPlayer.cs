using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource aSource;
    public float musicVolume = 1f;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        aSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        aSource.volume = musicVolume;
    }

    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }
}
