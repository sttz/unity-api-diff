using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class AvatarMask : Object
{
    public int humanoidBodyPartCount { get; }
    public int transformCount { get; set; }

    public AvatarMask();

    public void AddTransformPath(Transform transform);
    public void AddTransformPath(Transform transform, bool recursive);
    public bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index);
    public bool GetTransformActive(int index);
    public string GetTransformPath(int index);
    public void RemoveTransformPath(Transform transform);
    public void RemoveTransformPath(Transform transform, bool recursive);
    public void SetHumanoidBodyPartActive(AvatarMaskBodyPart index, bool value);
    public void SetTransformActive(int index, bool value);
    public void SetTransformPath(int index, string path);

}

}
