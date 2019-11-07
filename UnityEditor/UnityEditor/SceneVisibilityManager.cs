using System;
using UnityEngine;

namespace UnityEditor
{

public class SceneVisibilityManager : UnityEditor.ScriptableSingleton<UnityEditor.SceneVisibilityManager>
{
    static public event Action visibilityChanged;

    public SceneVisibilityManager();

    public bool AreAllDescendantsHidden(SceneManagement.Scene scene);
    public bool AreAllDescendantsHidden(GameObject gameObject);
    public bool AreAllDescendantsVisible(GameObject gameObject);
    public bool AreAnyDescendantsHidden(SceneManagement.Scene scene);
    public void ExitIsolation();
    public void Hide(GameObject gameObject, bool includeDescendants);
    public void Hide(SceneManagement.Scene scene);
    public void Hide(GameObject[] gameObjects, bool includeDescendants);
    public void HideAll();
    public bool IsCurrentStageIsolated();
    public bool IsHidden(GameObject gameObject, bool includeDescendants = false);
    public void Isolate(GameObject gameObject, bool includeDescendants);
    public void Isolate(GameObject[] gameObjects, bool includeDescendants);
    public void Show(GameObject gameObject, bool includeDescendants);
    public void Show(SceneManagement.Scene scene);
    public void Show(GameObject[] gameObjects, bool includeDescendants);
    public void ShowAll();
    public void ToggleVisibility(GameObject gameObject, bool includeDescendants);

}

}
