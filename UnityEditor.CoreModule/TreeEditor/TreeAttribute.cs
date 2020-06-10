using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TreeEditor
{

public class TreeAttribute : Attribute
{
    public string uiCurve;
    public float uiCurveMax;
    public float uiCurveMin;
    public string uiGadget;
    public string uiLabel;
    public float uiMax;
    public float uiMin;
    public GUIContent[] uiOptions;
    public string uiRequirement;

    public TreeAttribute(string uiLabel, string uiGadget, string uiOptions);
    public TreeAttribute(string uiLabel, string uiGadget, float uiMin, float uiMax);
    public TreeAttribute(string uiLabel, string uiGadget, float uiMin, float uiMax, string uiRequirement);
    public TreeAttribute(string uiLabel, string uiGadget, float uiMin, float uiMax, string uiCurve, float uiCurveMin, float uiCurveMax);
    public TreeAttribute(string uiLabel, string uiGadget, string uiOptions, string uiCurve, float uiCurveMin, float uiCurveMax, string uiRequirement);
    public TreeAttribute(string uiLabel, string uiGadget, float uiMin, float uiMax, string uiCurve, float uiCurveMin, float uiCurveMax, string uiRequirement);

    public string ToString();

}

}
