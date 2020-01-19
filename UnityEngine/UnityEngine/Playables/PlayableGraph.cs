using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Playables
{

public struct PlayableGraph
{
    static public Playables.PlayableGraph Create();
    static public Playables.PlayableGraph Create(string name);

    public bool Connect<U, V>(U source, int sourceOutputPort, V destination, int destinationInputPort);
    public void Destroy();
    public void DestroyOutput<U>(U output);
    public void DestroyPlayable<U>(U playable);
    public void DestroySubgraph<U>(U playable);
    public void Disconnect<U>(U input, int inputPort);
    public void Evaluate();
    public void Evaluate(float deltaTime);
    public string GetEditorName();
    public Playables.PlayableOutput GetOutput(int index);
    public Playables.PlayableOutput GetOutputByType<T>(int index);
    public int GetOutputCount();
    public int GetOutputCountByType<T>();
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
