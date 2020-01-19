using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class PhysicMaterial : Object
{
    public PhysicMaterialCombine bounceCombine { get; set; }
    public float bounciness { get; set; }
    public float bouncyness { get; set; }
    public float dynamicFriction { get; set; }
    public float dynamicFriction2 { get; set; }
    public PhysicMaterialCombine frictionCombine { get; set; }
    public Vector3 frictionDirection { get; set; }
    public Vector3 frictionDirection2 { get; set; }
    public float staticFriction { get; set; }
    public float staticFriction2 { get; set; }

    public PhysicMaterial();
    public PhysicMaterial(string name);

}

}
