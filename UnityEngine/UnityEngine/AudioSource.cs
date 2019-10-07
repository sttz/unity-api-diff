using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class AudioSource : AudioBehaviour
{
    static public void PlayClipAtPoint(AudioClip clip, Vector3 position);
    static public void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume);

    public bool bypassEffects { get; set; }
    public bool bypassListenerEffects { get; set; }
    public bool bypassReverbZones { get; set; }
    public AudioClip clip { get; set; }
    public float dopplerLevel { get; set; }
    public bool ignoreListenerPause { get; set; }
    public bool ignoreListenerVolume { get; set; }
    public bool isPlaying { get; }
    public bool isVirtual { get; }
    public bool loop { get; set; }
    public float maxDistance { get; set; }
    public float maxVolume { get; set; }
    public float minDistance { get; set; }
    public float minVolume { get; set; }
    public bool mute { get; set; }
    public Audio.AudioMixerGroup outputAudioMixerGroup { get; set; }
    public float pan { get; set; }
    public float panLevel { get; set; }
    public float panStereo { get; set; }
    public float pitch { get; set; }
    public bool playOnAwake { get; set; }
    public int priority { get; set; }
    public float reverbZoneMix { get; set; }
    public float rolloffFactor { get; set; }
    public AudioRolloffMode rolloffMode { get; set; }
    public float spatialBlend { get; set; }
    public bool spatialize { get; set; }
    public bool spatializePostEffects { get; set; }
    public float spread { get; set; }
    public float time { get; set; }
    public int timeSamples { get; set; }
    public AudioVelocityUpdateMode velocityUpdateMode { get; set; }
    public float volume { get; set; }

    public AudioSource();

    public bool GetAmbisonicDecoderFloat(int index, out float value);
    public AnimationCurve GetCustomCurve(AudioSourceCurveType type);
    public float[] GetOutputData(int numSamples, int channel);
    public void GetOutputData(float[] samples, int channel);
    public bool GetSpatializerFloat(int index, out float value);
    public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window);
    public void GetSpectrumData(float[] samples, int channel, FFTWindow window);
    public void Pause();
    public void Play();
    public void Play(ulong delay);
    public void PlayDelayed(float delay);
    public void PlayOneShot(AudioClip clip);
    public void PlayOneShot(AudioClip clip, float volumeScale);
    public void PlayScheduled(double time);
    public bool SetAmbisonicDecoderFloat(int index, float value);
    public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve);
    public void SetScheduledEndTime(double time);
    public void SetScheduledStartTime(double time);
    public bool SetSpatializerFloat(int index, float value);
    public void Stop();
    public void UnPause();

}

}
