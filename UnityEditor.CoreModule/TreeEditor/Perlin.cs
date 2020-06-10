using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TreeEditor
{

public class Perlin
{
    public Perlin();

    public float Noise(float arg);
    public float Noise(float x, float y);
    public float Noise(float x, float y, float z);
    public void SetSeed(int seed);

}

}
