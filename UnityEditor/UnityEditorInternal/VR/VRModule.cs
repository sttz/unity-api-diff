using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal.VR
{

public class VRModule
{
    static public void SetupBuildSettings(UnityEditor.BuildTarget target, int osVerMajor);
    static public bool ShouldInjectVRDependenciesForBuildTarget(UnityEditor.BuildTarget target);

    public VRModule();

}

}
