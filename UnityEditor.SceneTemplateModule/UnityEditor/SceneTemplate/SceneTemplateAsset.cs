using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SceneTemplate
{

public class SceneTemplateAsset : ScriptableObject
{
    public bool addToDefaults;
    public UnityEditor.SceneTemplate.DependencyInfo[] dependencies;
    public string description;
    public Texture2D preview;
    public string templateName;
    public UnityEditor.MonoScript templatePipeline;
    public UnityEditor.SceneAsset templateScene;

    public bool isValid { get; }

    public SceneTemplateAsset();

}

}
