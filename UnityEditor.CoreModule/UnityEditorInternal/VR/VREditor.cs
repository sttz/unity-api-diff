using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal.VR
{

public sealed class VREditor
{
    static public bool GetVREnabledOnTargetGroup(UnityEditor.BuildTargetGroup targetGroup);
    static public void NativeSetVREnabledDevicesOnTargetGroup(UnityEditor.BuildTargetGroup targetGroup, string[] devices);
    static public void SetVREnabledDevicesOnTargetGroup(UnityEditor.BuildTargetGroup targetGroup, string[] devices);
    static public void SetVREnabledOnTargetGroup(UnityEditor.BuildTargetGroup targetGroup, bool value);

    public VREditor();

}

}
