using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class AudioClip : Object
{
    static public AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream);
    static public AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream);
    static public AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, PCMReaderCallback pcmreadercallback);
    static public AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, PCMReaderCallback pcmreadercallback);
    static public AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, PCMReaderCallback pcmreadercallback, PCMSetPositionCallback pcmsetpositioncallback);
    static public AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, PCMReaderCallback pcmreadercallback, PCMSetPositionCallback pcmsetpositioncallback);

    public bool ambisonic { get; }
    public int channels { get; }
    public int frequency { get; }
    public bool isReadyToPlay { get; }
    public float length { get; }
    public bool loadInBackground { get; }
    public AudioDataLoadState loadState { get; }
    public AudioClipLoadType loadType { get; }
    public bool preloadAudioData { get; }
    public int samples { get; }

    public bool GetData(float[] data, int offsetSamples);
    public bool LoadAudioData();
    public bool SetData(float[] data, int offsetSamples);
    public bool UnloadAudioData();

    public delegate void PCMReaderCallback(float[] data);

    public delegate void PCMSetPositionCallback(int position);

}

}
