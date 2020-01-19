using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class AudioListener : AudioBehaviour
{
    static public bool pause { get; set; }
    static public float volume { get; set; }

    static public float[] GetOutputData(int numSamples, int channel);
    static public void GetOutputData(float[] samples, int channel);
    static public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window);
    static public void GetSpectrumData(float[] samples, int channel, FFTWindow window);

    public AudioVelocityUpdateMode velocityUpdateMode { get; set; }

    public AudioListener();

}

}
