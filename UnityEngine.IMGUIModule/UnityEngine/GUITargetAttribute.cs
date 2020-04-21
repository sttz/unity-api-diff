using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public class GUITargetAttribute : Attribute
{
    public GUITargetAttribute();
    public GUITargetAttribute(int displayIndex);
    public GUITargetAttribute(int displayIndex, int displayIndex1);
    public GUITargetAttribute(int displayIndex, int displayIndex1, int[] displayIndexList);

}

}
