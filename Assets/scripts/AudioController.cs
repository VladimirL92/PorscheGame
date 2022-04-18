using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource Menu;
    public AudioSource Noise;
    private bool Mute;

    private void Update()
    {
        if (Mute && Menu.volume > 0 )
        {
            Menu.volume -= Time.deltaTime;
        }
        else if (Menu.volume == 0)
        {
            Menu.Stop();
        }
        
    }
    public void StartGame()
    {
        Mute = true;
        Noise.Play();
    }
}
