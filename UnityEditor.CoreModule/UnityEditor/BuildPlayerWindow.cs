using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class BuildPlayerWindow : UnityEditor.EditorWindow
{
    static public string GetPlaybackEngineDownloadURL(string moduleName);
    static public void RegisterBuildPlayerHandler(Action<UnityEditor.BuildPlayerOptions> func);
    static public void RegisterGetBuildPlayerOptionsHandler(Func<UnityEditor.BuildPlayerOptions, UnityEditor.BuildPlayerOptions> func);
    static public void ShowBuildPlayerWindow();

    public BuildPlayerWindow();

    public class BuildMethodException : Exception
    {
        public BuildMethodException();
        public BuildMethodException(string message);

    }

    public static class DefaultBuildMethods
    {
        static public void BuildPlayer(UnityEditor.BuildPlayerOptions options);
        static public UnityEditor.BuildPlayerOptions GetBuildPlayerOptions(UnityEditor.BuildPlayerOptions defaultBuildPlayerOptions);

    }

}

}
