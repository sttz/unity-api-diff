using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Video
{

public sealed class VideoPlayer : Behaviour
{
    static public ushort controlledAudioTrackMaxCount { get; }

    public Video.VideoAspectRatio aspectRatio { get; set; }
    public Video.VideoAudioOutputMode audioOutputMode { get; set; }
    public ushort audioTrackCount { get; }
    public bool canSetDirectAudioVolume { get; }
    public bool canSetPlaybackSpeed { get; }
    public bool canSetSkipOnDrop { get; }
    public bool canSetTime { get; }
    public bool canSetTimeSource { get; }
    public bool canStep { get; }
    public Video.VideoClip clip { get; set; }
    public double clockTime { get; }
    public ushort controlledAudioTrackCount { get; set; }
    public double externalReferenceTime { get; set; }
    public long frame { get; set; }
    public ulong frameCount { get; }
    public float frameRate { get; }
    public uint height { get; }
    public bool isLooping { get; set; }
    public bool isPaused { get; }
    public bool isPlaying { get; }
    public bool isPrepared { get; }
    public double length { get; }
    public uint pixelAspectRatioDenominator { get; }
    public uint pixelAspectRatioNumerator { get; }
    public float playbackSpeed { get; set; }
    public bool playOnAwake { get; set; }
    public Video.VideoRenderMode renderMode { get; set; }
    public bool sendFrameReadyEvents { get; set; }
    public bool skipOnDrop { get; set; }
    public Video.VideoSource source { get; set; }
    public Camera targetCamera { get; set; }
    public Video.Video3DLayout targetCamera3DLayout { get; set; }
    public float targetCameraAlpha { get; set; }
    public string targetMaterialProperty { get; set; }
    public Renderer targetMaterialRenderer { get; set; }
    public RenderTexture targetTexture { get; set; }
    public Texture texture { get; }
    public double time { get; set; }
    public Video.VideoTimeReference timeReference { get; set; }
    public Video.VideoTimeSource timeSource { get; set; }
    public string url { get; set; }
    public bool waitForFirstFrame { get; set; }
    public uint width { get; }

    public event TimeEventHandler clockResyncOccurred;
    public event ErrorEventHandler errorReceived;
    public event EventHandler frameDropped;
    public event FrameReadyEventHandler frameReady;
    public event EventHandler loopPointReached;
    public event EventHandler prepareCompleted;
    public event EventHandler seekCompleted;
    public event EventHandler started;

    public VideoPlayer();

    public void EnableAudioTrack(ushort trackIndex, bool enabled);
    public ushort GetAudioChannelCount(ushort trackIndex);
    public string GetAudioLanguageCode(ushort trackIndex);
    public uint GetAudioSampleRate(ushort trackIndex);
    public bool GetDirectAudioMute(ushort trackIndex);
    public float GetDirectAudioVolume(ushort trackIndex);
    public AudioSource GetTargetAudioSource(ushort trackIndex);
    public bool IsAudioTrackEnabled(ushort trackIndex);
    public void Pause();
    public void Play();
    public void Prepare();
    public void SetDirectAudioMute(ushort trackIndex, bool mute);
    public void SetDirectAudioVolume(ushort trackIndex, float volume);
    public void SetTargetAudioSource(ushort trackIndex, AudioSource source);
    public void StepForward();
    public void Stop();

    public delegate void ErrorEventHandler(Video.VideoPlayer source, string message);

    public delegate void EventHandler(Video.VideoPlayer source);

    public delegate void FrameReadyEventHandler(Video.VideoPlayer source, long frameIdx);

    public delegate void TimeEventHandler(Video.VideoPlayer source, double seconds);

}

}
