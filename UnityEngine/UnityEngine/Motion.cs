using System;
using UnityEngine;

namespace UnityEngine
{

public class Motion : Object
{
    public float apparentSpeed { get; }
    public float averageAngularSpeed { get; }
    public float averageDuration { get; }
    public Vector3 averageSpeed { get; }
    public bool isAnimatorMotion { get; }
    public bool isHumanMotion { get; }
    public bool isLooping { get; }
    public bool legacy { get; }

    protected Motion();

    public bool ValidateIfRetargetable(bool val);

}

}
