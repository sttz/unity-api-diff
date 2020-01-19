using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Animations
{

public sealed class ScaleConstraint : Behaviour, Animations.IConstraint, Animations.IConstraintInternal
{
    public bool constraintActive { get; set; }
    public bool locked { get; set; }
    public Vector3 scaleAtRest { get; set; }
    public Vector3 scaleOffset { get; set; }
    public Animations.Axis scalingAxis { get; set; }
    public int sourceCount { get; }
    public float weight { get; set; }

    public int AddSource(Animations.ConstraintSource source);
    public Animations.ConstraintSource GetSource(int index);
    public void GetSources(List<Animations.ConstraintSource> sources);
    public void RemoveSource(int index);
    public void SetSource(int index, Animations.ConstraintSource source);
    public void SetSources(List<Animations.ConstraintSource> sources);

}

}