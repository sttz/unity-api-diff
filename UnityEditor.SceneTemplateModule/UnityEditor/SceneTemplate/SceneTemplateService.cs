using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SceneTemplate
{

public static class SceneTemplateService
{
    static public event NewTemplateInstantiated newSceneTemplateInstantiated;
    static public event NewTemplateInstantiating newSceneTemplateInstantiating;

    static public UnityEditor.SceneTemplate.SceneTemplateAsset CreateSceneTemplate(string sceneTemplatePath);
    static public UnityEditor.SceneTemplate.SceneTemplateAsset CreateTemplateFromScene(UnityEditor.SceneAsset sourceSceneAsset, string sceneTemplatePath);
    static public UnityEditor.SceneTemplate.InstantiationResult Instantiate(UnityEditor.SceneTemplate.SceneTemplateAsset sceneTemplate, bool loadAdditively, string newSceneOutputPath = null);

    public delegate void NewTemplateInstantiated(UnityEditor.SceneTemplate.SceneTemplateAsset sceneTemplateAsset, SceneManagement.Scene scene, UnityEditor.SceneAsset sceneAsset, bool additiveLoad);

    public delegate void NewTemplateInstantiating(UnityEditor.SceneTemplate.SceneTemplateAsset sceneTemplateAsset, string newSceneOutputPath, bool additiveLoad);

}

}
