using System;
using UnityEngine;

namespace UnityEngine.Playables
{

public static class PlayableExtensions
{
    static public int AddInput(U playable, V sourcePlayable, int sourceOutputIndex, float weight = 0);
    static public bool CanChangeInputs(U playable);
    static public bool CanDestroy(U playable);
    static public bool CanSetWeights(U playable);
    static public void ConnectInput(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex);
    static public void ConnectInput(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex, float weight);
    static public void Destroy(U playable);
    static public void DisconnectInput(U playable, int inputPort);
    static public double GetDelay(U playable);
    static public double GetDuration(U playable);
    static public Playables.PlayableGraph GetGraph(U playable);
    static public Playables.Playable GetInput(U playable, int inputPort);
    static public int GetInputCount(U playable);
    static public float GetInputWeight(U playable, int inputIndex);
    static public float GetLeadTime(U playable);
    static public Playables.Playable GetOutput(U playable, int outputPort);
    static public int GetOutputCount(U playable);
    static public Playables.PlayState GetPlayState(U playable);
    static public double GetPreviousTime(U playable);
    static public bool GetPropagateSetTime(U playable);
    static public double GetSpeed(U playable);
    static public double GetTime(U playable);
    static public Playables.PlayableTraversalMode GetTraversalMode(U playable);
    static public bool IsDelayed(U playable);
    static public bool IsDone(U playable);
    static public bool IsNull(U playable);
    static public bool IsValid(U playable);
    static public void Pause(U playable);
    static public void Play(U playable);
    static public void SetDelay(U playable, double delay);
    static public void SetDone(U playable, bool value);
    static public void SetDuration(U playable, double value);
    static public void SetInputCount(U playable, int value);
    static public void SetInputWeight(U playable, int inputIndex, float weight);
    static public void SetInputWeight(U playable, V input, float weight);
    static public void SetLeadTime(U playable, float value);
    static public void SetOutputCount(U playable, int value);
    static public void SetPlayState(U playable, Playables.PlayState value);
    static public void SetPropagateSetTime(U playable, bool value);
    static public void SetSpeed(U playable, double value);
    static public void SetTime(U playable, double value);
    static public void SetTraversalMode(U playable, Playables.PlayableTraversalMode mode);

}

}
