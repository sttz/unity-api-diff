using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal.VR
{

public sealed class VREditor
{
    static public void ClearDeviceListDirty(UnityEditor.BuildTargetGroup targetGroup);
    static public UnityEditorInternal.VR.VRDeviceInfoEditor[] GetAllVRDeviceInfo(UnityEditor.BuildTargetGroup targetGroup);
    static public UnityEditorInternal.VR.VRDeviceInfoEditor[] GetAllVRDeviceInfoByTarget(UnityEditor.BuildTarget target);
    static public string[] GetAvailableVirtualRealitySDKs(UnityEditor.BuildTargetGroup targetGroup);
    static public UnityEditorInternal.VR.VRDeviceInfoEditor[] GetEnabledVRDeviceInfo(UnityEditor.BuildTarget target);
    static public UnityEditorInternal.VR.VRDeviceInfoEditor[] GetEnabledVRDeviceInfo(UnityEditor.BuildTargetGroup targetGroup);
    static public string[] GetVirtualRealitySDKs(UnityEditor.BuildTargetGroup targetGroup);
    static public string[] GetVREnabledDevicesOnTarget(UnityEditor.BuildTarget target);
    static public string[] GetVREnabledDevicesOnTargetGroup(UnityEditor.BuildTargetGroup targetGroup);
    static public bool GetVREnabledOnTargetGroup(UnityEditor.BuildTargetGroup targetGroup);
    static public bool IsDeviceListDirty(UnityEditor.BuildTargetGroup targetGroup);
    static public bool IsVRDeviceEnabledForBuildTarget(UnityEditor.BuildTarget target, string deviceName);
    static public void NativeSetVREnabledDevicesOnTargetGroup(UnityEditor.BuildTargetGroup targetGroup, string[] devices);
    static public void SetVirtualRealitySDKs(UnityEditor.BuildTargetGroup targetGroup, string[] sdks);
    static public void SetVREnabledDevicesOnTargetGroup(UnityEditor.BuildTargetGroup targetGroup, string[] devices);
    static public void SetVREnabledOnTargetGroup(UnityEditor.BuildTargetGroup targetGroup, bool value);

    public VREditor();

}

}
