using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SceneTemplate
{

public class SceneTemplatePipelineAdapter : UnityEditor.SceneTemplate.ISceneTemplatePipeline
{
    public SceneTemplatePipelineAdapter();

    public void AfterTemplateInstantiation(UnityEditor.SceneTemplate.SceneTemplateAsset sceneTemplateAsset, SceneManagement.Scene scene, bool isAdditive, string sceneName);
    public void BeforeTemplateInstantiation(UnityEditor.SceneTemplate.SceneTemplateAsset sceneTemplateAsset, bool isAdditive, string sceneName);
    public bool IsValidTemplateForInstantiation(UnityEditor.SceneTemplate.SceneTemplateAsset sceneTemplateAsset);

}

}
