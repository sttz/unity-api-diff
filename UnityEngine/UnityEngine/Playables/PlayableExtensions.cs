using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Playables
{

public static class PlayableExtensions
{
    static public int AddInput<U, V>(U playable, V sourcePlayable, int sourceOutputIndex, float weight = 0);
    static public bool CanChangeInputs<U>(U playable);
    static public bool CanDestroy<U>(U playable);
    static public bool CanSetWeights<U>(U playable);
    static public void ConnectInput<U, V>(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex);
    static public void ConnectInput<U, V>(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex, float weight);
    static public void Destroy<U>(U playable);
    static public void DisconnectInput<U>(U playable, int inputPort);
    static public double GetDelay<U>(U playable);
    static public double GetDuration<U>(U playable);
    static public Playables.PlayableGraph GetGraph<U>(U playable);
    static public Playables.Playable GetInput<U>(U playable, int inputPort);
    static public int GetInputCount<U>(U playable);
    static public float GetInputWeight<U>(U playable, int inputIndex);
    static public float GetLeadTime<U>(U playable);
    static public Playables.Playable GetOutput<U>(U playable, int outputPort);
    static public int GetOutputCount<U>(U playable);
    static public Playables.PlayState GetPlayState<U>(U playable);
    static public double GetPreviousTime<U>(U playable);
    static public bool GetPropagateSetTime<U>(U playable);
    static public double GetSpeed<U>(U playable);
    static public double GetTime<U>(U playable);
    static public Playables.PlayableTraversalMode GetTraversalMode<U>(U playable);
    static public bool IsDelayed<U>(U playable);
    static public bool IsDone<U>(U playable);
    static public bool IsNull<U>(U playable);
    static public bool IsValid<U>(U playable);
    static public void Pause<U>(U playable);
    static public void Play<U>(U playable);
    static public void SetDelay<U>(U playable, double delay);
    static public void SetDone<U>(U playable, bool value);
    static public void SetDuration<U>(U playable, double value);
    static public void SetInputCount<U>(U playable, int value);
    static public void SetInputWeight<U>(U playable, int inputIndex, float weight);
    static public void SetInputWeight<U, V>(U playable, V input, float weight);
    static public void SetLeadTime<U>(U playable, float value);
    static public void SetOutputCount<U>(U playable, int value);
    static public void SetPlayState<U>(U playable, Playables.PlayState value);
    static public void SetPropagateSetTime<U>(U playable, bool value);
    static public void SetSpeed<U>(U playable, double value);
    static public void SetTime<U>(U playable, double value);
    static public void SetTraversalMode<U>(U playable, Playables.PlayableTraversalMode mode);

}

}
