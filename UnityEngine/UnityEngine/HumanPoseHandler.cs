using System;
using UnityEngine;

namespace UnityEngine
{

public class HumanPoseHandler : IDisposable
{
    public HumanPoseHandler(Avatar avatar, Transform root);

    public void Dispose();
    public void GetHumanPose(HumanPose humanPose);
    public void SetHumanPose(HumanPose humanPose);

}

}
