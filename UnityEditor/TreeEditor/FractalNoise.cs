using System;
using UnityEngine;

namespace TreeEditor
{

public class FractalNoise
{
    public FractalNoise(float inH, float inLacunarity, float inOctaves);
    public FractalNoise(float inH, float inLacunarity, float inOctaves, TreeEditor.Perlin noise);

    public float BrownianMotion(float x, float y);
    public float HybridMultifractal(float x, float y, float offset);
    public float RidgedMultifractal(float x, float y, float offset, float gain);

}

}
