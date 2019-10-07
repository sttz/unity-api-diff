using System;
using UnityEngine;

namespace UnityEngine
{

public enum AnimationCullingType
{
    AlwaysAnimate = 0,
    BasedOnRenderers = 1,
    BasedOnClipBounds = 2,
    BasedOnUserBounds = 3,
}

}
