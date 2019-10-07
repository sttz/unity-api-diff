using System;
using UnityEngine;

namespace UnityEngine
{

public class HumanPoseHandler : IDisposable
{
    public HumanPoseHandler(Avatar avatar, Transform root);
    public HumanPoseHandler(Avatar avatar, string[] jointPaths);

    public void Dispose();
    public void GetHumanPose(HumanPose humanPose);
    public void GetInternalAvatarPose(Unity.Collections.NativeArray<float> avatarPose);
    public void GetInternalHumanPose(HumanPose humanPose);
    public void SetHumanPose(HumanPose humanPose);
    public void SetInternalAvatarPose(Unity.Collections.NativeArray<float> avatarPose);
    public void SetInternalHumanPose(HumanPose humanPose);

}

}
