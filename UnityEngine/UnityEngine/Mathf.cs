using System;
using UnityEngine;

namespace UnityEngine
{

public struct Mathf
{
    static public float Deg2Rad = 0.017453292;
    static public float Epsilon;
    static public float Infinity = ∞;
    static public float NegativeInfinity = -∞;
    static public float PI = 3.1415927;
    static public float Rad2Deg = 57.29578;

    static public float Abs(float f);
    static public int Abs(int value);
    static public float Acos(float f);
    static public bool Approximately(float a, float b);
    static public float Asin(float f);
    static public float Atan(float f);
    static public float Atan2(float y, float x);
    static public float Ceil(float f);
    static public int CeilToInt(float f);
    static public float Clamp(float value, float min, float max);
    static public int Clamp(int value, int min, int max);
    static public float Clamp01(float value);
    static public int ClosestPowerOfTwo(int value);
    static public Color CorrelatedColorTemperatureToRGB(float kelvin);
    static public float Cos(float f);
    static public float DeltaAngle(float current, float target);
    static public float Exp(float power);
    static public ushort FloatToHalf(float val);
    static public float Floor(float f);
    static public int FloorToInt(float f);
    static public float Gamma(float value, float absmax, float gamma);
    static public float GammaToLinearSpace(float value);
    static public float HalfToFloat(ushort val);
    static public float InverseLerp(float a, float b, float value);
    static public bool IsPowerOfTwo(int value);
    static public float Lerp(float a, float b, float t);
    static public float LerpAngle(float a, float b, float t);
    static public float LerpUnclamped(float a, float b, float t);
    static public float LinearToGammaSpace(float value);
    static public float Log(float f, float p);
    static public float Log(float f);
    static public float Log10(float f);
    static public float Max(float a, float b);
    static public float Max(float[] values);
    static public int Max(int a, int b);
    static public int Max(int[] values);
    static public float Min(float a, float b);
    static public float Min(float[] values);
    static public int Min(int a, int b);
    static public int Min(int[] values);
    static public float MoveTowards(float current, float target, float maxDelta);
    static public float MoveTowardsAngle(float current, float target, float maxDelta);
    static public int NextPowerOfTwo(int value);
    static public float PerlinNoise(float x, float y);
    static public float PingPong(float t, float length);
    static public float Pow(float f, float p);
    static public float Repeat(float t, float length);
    static public float Round(float f);
    static public int RoundToInt(float f);
    static public float Sign(float f);
    static public float Sin(float f);
    static public float SmoothDamp(float current, float target, float currentVelocity, float smoothTime, float maxSpeed);
    static public float SmoothDamp(float current, float target, float currentVelocity, float smoothTime);
    static public float SmoothDamp(float current, float target, float currentVelocity, float smoothTime, float maxSpeed, float deltaTime);
    static public float SmoothDampAngle(float current, float target, float currentVelocity, float smoothTime, float maxSpeed);
    static public float SmoothDampAngle(float current, float target, float currentVelocity, float smoothTime);
    static public float SmoothDampAngle(float current, float target, float currentVelocity, float smoothTime, float maxSpeed, float deltaTime);
    static public float SmoothStep(float from, float to, float t);
    static public float Sqrt(float f);
    static public float Tan(float f);

}

}
