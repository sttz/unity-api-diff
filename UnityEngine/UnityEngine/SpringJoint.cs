using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class SpringJoint : Joint
{
    public float damper { get; set; }
    public float maxDistance { get; set; }
    public float minDistance { get; set; }
    public float spring { get; set; }
    public float tolerance { get; set; }

    public SpringJoint();

}

}
