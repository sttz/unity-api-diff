using System;
using UnityEngine;

namespace UnityEngine
{

public class AnimatorUtility
{
    static public void DeoptimizeTransformHierarchy(GameObject go);
    static public void OptimizeTransformHierarchy(GameObject go, string[] exposedTransforms);

    public AnimatorUtility();

}

}
