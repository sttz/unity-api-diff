using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Animations
{

public struct MuscleHandle
{
    static public int muscleHandleCount { get; }

    static public void GetMuscleHandles(out Animations.MuscleHandle[] muscleHandles);

    public int dof { get; private set; }
    public HumanPartDof humanPartDof { get; private set; }
    public string name { get; }

    public MuscleHandle(BodyDof bodyDof);
    public MuscleHandle(HeadDof headDof);
    public MuscleHandle(HumanPartDof partDof, ArmDof armDof);
    public MuscleHandle(HumanPartDof partDof, FingerDof fingerDof);
    public MuscleHandle(HumanPartDof partDof, LegDof legDof);

}

}
