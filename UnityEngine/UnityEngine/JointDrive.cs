using System;
using UnityEngine;

namespace UnityEngine
{

public struct JointDrive
{
    public float maximumForce { get; set; }
    public JointDriveMode mode { get; set; }
    public float positionDamper { get; set; }
    public float positionSpring { get; set; }

}

}
