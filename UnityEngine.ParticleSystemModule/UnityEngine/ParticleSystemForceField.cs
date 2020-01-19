using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class ParticleSystemForceField : Component
{
    static public ParticleSystemForceField[] FindAll();

    public MinMaxCurve directionX { get; set; }
    public MinMaxCurve directionY { get; set; }
    public MinMaxCurve directionZ { get; set; }
    public MinMaxCurve drag { get; set; }
    public float endRange { get; set; }
    public MinMaxCurve gravity { get; set; }
    public float gravityFocus { get; set; }
    public float length { get; set; }
    public bool multiplyDragByParticleSize { get; set; }
    public bool multiplyDragByParticleVelocity { get; set; }
    public MinMaxCurve rotationAttraction { get; set; }
    public Vector2 rotationRandomness { get; set; }
    public MinMaxCurve rotationSpeed { get; set; }
    public ParticleSystemForceFieldShape shape { get; set; }
    public float startRange { get; set; }
    public Texture3D vectorField { get; set; }
    public MinMaxCurve vectorFieldAttraction { get; set; }
    public MinMaxCurve vectorFieldSpeed { get; set; }

    public ParticleSystemForceField();

}

}
