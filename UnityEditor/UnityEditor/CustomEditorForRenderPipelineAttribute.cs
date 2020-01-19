using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class CustomEditorForRenderPipelineAttribute : UnityEditor.CustomEditor
{
    public CustomEditorForRenderPipelineAttribute(Type inspectedType, Type renderPipeline);
    public CustomEditorForRenderPipelineAttribute(Type inspectedType, Type renderPipeline, bool editorForChildClasses);

}

}
