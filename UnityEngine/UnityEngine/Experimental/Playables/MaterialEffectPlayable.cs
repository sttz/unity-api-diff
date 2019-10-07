using System;
using UnityEngine;

namespace UnityEngine.Experimental.Playables
{

public struct MaterialEffectPlayable : Playables.IPlayable, IEquatable<Experimental.Playables.MaterialEffectPlayable>
{
    static public Experimental.Playables.MaterialEffectPlayable Create(Playables.PlayableGraph graph, Material material, int pass = -1);

    public bool Equals(Experimental.Playables.MaterialEffectPlayable other);
    public Playables.PlayableHandle GetHandle();
    public Material GetMaterial();
    public int GetPass();
    public void SetMaterial(Material value);
    public void SetPass(int value);

}

}
