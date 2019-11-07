using System;
using UnityEngine;

namespace UnityEditorInternal
{

public static class RenderDoc
{
    static public void BeginCaptureRenderDoc(UnityEditor.EditorWindow window);
    static public void EndCaptureRenderDoc(UnityEditor.EditorWindow window);
    static public bool IsInstalled();
    static public bool IsLoaded();
    static public bool IsSupported();
    static public void Load();

}

}
