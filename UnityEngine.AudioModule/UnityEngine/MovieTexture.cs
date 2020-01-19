using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class MovieTexture : Texture
{
    public AudioClip audioClip { get; }
    public float duration { get; }
    public bool isPlaying { get; }
    public bool isReadyToPlay { get; }
    public bool loop { get; set; }

    public void Pause();
    public void Play();
    public void Stop();

}

}
