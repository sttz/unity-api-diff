using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct ContactFilter2D
{
    static public float NormalAngleUpperLimit = 359.9999;

    public LayerMask layerMask;
    public float maxDepth;
    public float maxNormalAngle;
    public float minDepth;
    public float minNormalAngle;
    public bool useDepth;
    public bool useLayerMask;
    public bool useNormalAngle;
    public bool useOutsideDepth;
    public bool useOutsideNormalAngle;
    public bool useTriggers;

    public bool isFiltering { get; }

    public void ClearDepth();
    public void ClearLayerMask();
    public void ClearNormalAngle();
    public bool IsFilteringDepth(GameObject obj);
    public bool IsFilteringLayerMask(GameObject obj);
    public bool IsFilteringNormalAngle(float angle);
    public bool IsFilteringNormalAngle(Vector2 normal);
    public bool IsFilteringTrigger(Collider2D collider);
    public ContactFilter2D NoFilter();
    public void SetDepth(float minDepth, float maxDepth);
    public void SetLayerMask(LayerMask layerMask);
    public void SetNormalAngle(float minNormalAngle, float maxNormalAngle);

}

}
