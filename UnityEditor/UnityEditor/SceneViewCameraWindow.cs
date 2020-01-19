using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class SceneViewCameraWindow : UnityEditor.PopupWindowContent
{
    static public event Action<UnityEditor.SceneView> additionalSettingsGui;

    public SceneViewCameraWindow(UnityEditor.SceneView sceneView);

    public Vector2 GetWindowSize();
    public void OnGUI(Rect rect);

}

}
