using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class AudioCurveRendering
{
    static public Color kAudioOrange;

    static public Rect BeginCurveFrame(Rect r);
    static public void DrawCurve(Rect r, AudioCurveEvaluator eval, Color curveColor);
    static public void DrawCurveBackground(Rect r);
    static public Rect DrawCurveFrame(Rect r);
    static public void DrawFilledCurve(Rect r, AudioCurveAndColorEvaluator eval);
    static public void DrawFilledCurve(Rect r, AudioCurveEvaluator eval, Color curveColor);
    static public void DrawGradientRect(Rect r, Color c1, Color c2, float blend, bool horizontal);
    static public void DrawMinMaxFilledCurve(Rect r, AudioMinMaxCurveAndColorEvaluator eval);
    static public void DrawSymmetricFilledCurve(Rect r, AudioCurveAndColorEvaluator eval);
    static public void EndCurveFrame();

    public AudioCurveRendering();

    public delegate float AudioCurveAndColorEvaluator(float x, out Color col);

    public delegate float AudioCurveEvaluator(float x);

    public delegate void AudioMinMaxCurveAndColorEvaluator(float x, out Color col, out float minValue, out float maxValue);

}

}
