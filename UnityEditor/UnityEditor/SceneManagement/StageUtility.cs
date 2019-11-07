using System;
using UnityEngine;

namespace UnityEditor.SceneManagement
{

public static class StageUtility
{
    static public UnityEditor.SceneManagement.StageHandle GetCurrentStageHandle();
    static public UnityEditor.SceneManagement.StageHandle GetMainStageHandle();
    static public UnityEditor.SceneManagement.StageHandle GetStageHandle(GameObject gameObject);
    static public UnityEditor.SceneManagement.StageHandle GetStageHandle(SceneManagement.Scene scene);
    static public void GoBackToPreviousStage();
    static public void GoToMainStage();
    static public void GoToStage(UnityEditor.SceneManagement.Stage stage, bool setAsFirstItemAfterMainStage);
    static public bool IsGameObjectRenderedByCamera(GameObject gameObject, Camera camera);
    static public bool IsGameObjectRenderedByCameraAndPartOfEditableScene(GameObject gameObject, Camera camera);
    static public void PlaceGameObjectInCurrentStage(GameObject gameObject);

}

}
