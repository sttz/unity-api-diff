using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public enum BlendOp
{
    Add = 0,
    Subtract = 1,
    ReverseSubtract = 2,
    Min = 3,
    Max = 4,
    LogicalClear = 5,
    LogicalSet = 6,
    LogicalCopy = 7,
    LogicalCopyInverted = 8,
    LogicalNoop = 9,
    LogicalInvert = 10,
    LogicalAnd = 11,
    LogicalNand = 12,
    LogicalOr = 13,
    LogicalNor = 14,
    LogicalXor = 15,
    LogicalEquivalence = 16,
    LogicalAndReverse = 17,
    LogicalAndInverted = 18,
    LogicalOrReverse = 19,
    LogicalOrInverted = 20,
    Multiply = 21,
    Screen = 22,
    Overlay = 23,
    Darken = 24,
    Lighten = 25,
    ColorDodge = 26,
    ColorBurn = 27,
    HardLight = 28,
    SoftLight = 29,
    Difference = 30,
    Exclusion = 31,
    HSLHue = 32,
    HSLSaturation = 33,
    HSLColor = 34,
    HSLLuminosity = 35,
}

}
