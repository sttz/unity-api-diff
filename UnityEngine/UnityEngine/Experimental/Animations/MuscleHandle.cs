using System;
using UnityEngine;

namespace UnityEngine.Experimental.Animations
{

public struct MuscleHandle
{
    static public int muscleHandleCount { get; }

    static public void GetMuscleHandles(out Experimental.Animations.MuscleHandle[] muscleHandles);

    public int dof { get; private set; }
    public HumanPartDof humanPartDof { get; private set; }
    public string name { get; }

    public MuscleHandle(BodyDof bodyDof);
    public MuscleHandle(HeadDof headDof);
    public MuscleHandle(HumanPartDof partDof, LegDof legDof);
    public MuscleHandle(HumanPartDof partDof, ArmDof armDof);
    public MuscleHandle(HumanPartDof partDof, FingerDof fingerDof);

}

}
