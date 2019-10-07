using System;
using UnityEngine;

namespace UnityEngine
{

public class AvatarBuilder
{
    static public Avatar BuildGenericAvatar(GameObject go, string rootMotionTransformName);
    static public Avatar BuildHumanAvatar(GameObject go, HumanDescription humanDescription);

    public AvatarBuilder();

}

}
