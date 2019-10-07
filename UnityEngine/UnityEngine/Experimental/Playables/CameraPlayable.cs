using System;
using UnityEngine;

namespace UnityEngine.Experimental.Playables
{

public struct CameraPlayable : Playables.IPlayable, IEquatable<Experimental.Playables.CameraPlayable>
{
    static public Experimental.Playables.CameraPlayable Create(Playables.PlayableGraph graph, Camera camera);

    public bool Equals(Experimental.Playables.CameraPlayable other);
    public Camera GetCamera();
    public Playables.PlayableHandle GetHandle();
    public void SetCamera(Camera value);

}

}
