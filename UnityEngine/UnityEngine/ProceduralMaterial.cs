using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class ProceduralMaterial : Material
{
    static public bool isSupported { get; }
    static public ProceduralProcessorUsage substanceProcessorUsage { get; set; }

    static public void StopRebuilds();

    public int animationUpdateRate { get; set; }
    public ProceduralCacheSize cacheSize { get; set; }
    public bool isCachedDataAvailable { get; }
    public bool isFrozen { get; }
    public bool isLoadTimeGenerated { get; set; }
    public bool isProcessing { get; }
    public bool isReadable { get; set; }
    public ProceduralLoadingBehavior loadingBehavior { get; }
    public string preset { get; set; }

    public void CacheProceduralProperty(string inputName, bool value);
    public void ClearCache();
    public void FreezeAndReleaseSourceData();
    public ProceduralTexture GetGeneratedTexture(string textureName);
    public Texture[] GetGeneratedTextures();
    public bool GetProceduralBoolean(string inputName);
    public Color GetProceduralColor(string inputName);
    public int GetProceduralEnum(string inputName);
    public float GetProceduralFloat(string inputName);
    public ProceduralPropertyDescription[] GetProceduralPropertyDescriptions();
    public string GetProceduralString(string inputName);
    public Texture2D GetProceduralTexture(string inputName);
    public Vector4 GetProceduralVector(string inputName);
    public bool HasProceduralProperty(string inputName);
    public bool IsProceduralPropertyCached(string inputName);
    public bool IsProceduralPropertyVisible(string inputName);
    public void RebuildTextures();
    public void RebuildTexturesImmediately();
    public void SetProceduralBoolean(string inputName, bool value);
    public void SetProceduralColor(string inputName, Color value);
    public void SetProceduralEnum(string inputName, int value);
    public void SetProceduralFloat(string inputName, float value);
    public void SetProceduralString(string inputName, string value);
    public void SetProceduralTexture(string inputName, Texture2D value);
    public void SetProceduralVector(string inputName, Vector4 value);

}

}
