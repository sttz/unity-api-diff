using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Animations
{

public sealed class AimConstraint : Behaviour, Animations.IConstraint, Animations.IConstraintInternal
{
    public Vector3 aimVector { get; set; }
    public bool constraintActive { get; set; }
    public bool locked { get; set; }
    public Vector3 rotationAtRest { get; set; }
    public Animations.Axis rotationAxis { get; set; }
    public Vector3 rotationOffset { get; set; }
    public int sourceCount { get; }
    public Vector3 upVector { get; set; }
    public float weight { get; set; }
    public Transform worldUpObject { get; set; }
    public WorldUpType worldUpType { get; set; }
    public Vector3 worldUpVector { get; set; }

    public int AddSource(Animations.ConstraintSource source);
    public Animations.ConstraintSource GetSource(int index);
    public void GetSources(List<Animations.ConstraintSource> sources);
    public void RemoveSource(int index);
    public void SetSource(int index, Animations.ConstraintSource source);
    public void SetSources(List<Animations.ConstraintSource> sources);

    public enum WorldUpType
    {
        SceneUp = 0,
        ObjectUp = 1,
        ObjectRotationUp = 2,
        Vector = 3,
        None = 4,
    }

}

}
