using System;
using UnityEngine;

namespace UnityEngine.Animations
{

public interface IConstraint
{
    public bool constraintActive { get; set; }
    public bool locked { get; set; }
    public int sourceCount { get; }
    public float weight { get; set; }

    public int AddSource(Animations.ConstraintSource source);
    public Animations.ConstraintSource GetSource(int index);
    public void GetSources(System.Collections.Generic.List<Animations.ConstraintSource> sources);
    public void RemoveSource(int index);
    public void SetSource(int index, Animations.ConstraintSource source);
    public void SetSources(System.Collections.Generic.List<Animations.ConstraintSource> sources);

}

}
