using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class Microphone
{
    static public string[] devices { get; }

    static public void End(string deviceName);
    static public void GetDeviceCaps(string deviceName, out int minFreq, out int maxFreq);
    static public int GetPosition(string deviceName);
    static public bool IsRecording(string deviceName);
    static public AudioClip Start(string deviceName, bool loop, int lengthSec, int frequency);

    public Microphone();

}

}
