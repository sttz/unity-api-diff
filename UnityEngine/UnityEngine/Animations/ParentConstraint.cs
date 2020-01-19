using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Animations
{

public sealed class ParentConstraint : Behaviour, Animations.IConstraint, Animations.IConstraintInternal
{
    public bool constraintActive { get; set; }
    public bool locked { get; set; }
    public Vector3 rotationAtRest { get; set; }
    public Animations.Axis rotationAxis { get; set; }
    public Vector3[] rotationOffsets { get; set; }
    public int sourceCount { get; }
    public Vector3 translationAtRest { get; set; }
    public Animations.Axis translationAxis { get; set; }
    public Vector3[] translationOffsets { get; set; }
    public float weight { get; set; }

    public int AddSource(Animations.ConstraintSource source);
    public Vector3 GetRotationOffset(int index);
    public Animations.ConstraintSource GetSource(int index);
    public void GetSources(List<Animations.ConstraintSource> sources);
    public Vector3 GetTranslationOffset(int index);
    public void RemoveSource(int index);
    public void SetRotationOffset(int index, Vector3 value);
    public void SetSource(int index, Animations.ConstraintSource source);
    public void SetSources(List<Animations.ConstraintSource> sources);
    public void SetTranslationOffset(int index, Vector3 value);

}

}
