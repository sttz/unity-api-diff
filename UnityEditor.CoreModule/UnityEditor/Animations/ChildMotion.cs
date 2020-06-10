using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Animations
{

public struct ChildMotion
{
    public float cycleOffset { get; set; }
    public string directBlendParameter { get; set; }
    public bool mirror { get; set; }
    public Motion motion { get; set; }
    public Vector2 position { get; set; }
    public float threshold { get; set; }
    public float timeScale { get; set; }

}

}
