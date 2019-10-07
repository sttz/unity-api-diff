using System;
using UnityEngine;

namespace UnityEngine
{

public class HumanTrait
{
    static public int BoneCount { get; }
    static public string[] BoneName { get; }
    static public int MuscleCount { get; }
    static public string[] MuscleName { get; }
    static public int RequiredBoneCount { get; }

    static public int BoneFromMuscle(int i);
    static public float GetBoneDefaultHierarchyMass(int i);
    static public float GetMuscleDefaultMax(int i);
    static public float GetMuscleDefaultMin(int i);
    static public int GetParentBone(int i);
    static public int MuscleFromBone(int i, int dofIndex);
    static public bool RequiredBone(int i);

    public HumanTrait();

}

}
