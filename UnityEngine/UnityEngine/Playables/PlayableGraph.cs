using System;
using UnityEngine;

namespace UnityEngine.Playables
{

public struct PlayableGraph
{
    static public Playables.PlayableGraph Create();
    static public Playables.PlayableGraph Create(string name);

    public bool Connect(U source, int sourceOutputPort, V destination, int destinationInputPort);
    public void Destroy();
    public void DestroyOutput(U output);
    public void DestroyPlayable(U playable);
    public void DestroySubgraph(U playable);
    public void Disconnect(U input, int inputPort);
    public void Evaluate();
    public void Evaluate(float deltaTime);
    public string GetEditorName();
    public Playables.PlayableOutput GetOutput(int index);
    public Playables.PlayableOutput GetOutputByType(int index);
    public int GetOutputCount();
    public int GetOutputCountByType();
    public int GetPlayableCount();
    public IExposedPropertyTable GetResolver();
    public Playables.Playable GetRootPlayable(int index);
    public int GetRootPlayableCount();
    public Playables.DirectorUpdateMode GetTimeUpdateMode();
    public bool IsDone();
    public bool IsPlaying();
    public bool IsValid();
    public void Play();
    public void SetResolver(IExposedPropertyTable value);
    public void SetTimeUpdateMode(Playables.DirectorUpdateMode value);
    public void Stop();

}

}
