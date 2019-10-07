using System;
using UnityEngine;

namespace UnityEngine.Audio
{

public struct AudioMixerPlayable : Playables.IPlayable, IEquatable<Audio.AudioMixerPlayable>
{
    static public Audio.AudioMixerPlayable Create(Playables.PlayableGraph graph, int inputCount = 0, bool normalizeInputVolumes = false);

    public bool Equals(Audio.AudioMixerPlayable other);
    public Playables.PlayableHandle GetHandle();

}

}
