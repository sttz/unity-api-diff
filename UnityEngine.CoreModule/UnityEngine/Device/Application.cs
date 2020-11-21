using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Device
{

public static class Application
{
    static public string absoluteURL { get; }
    static public ThreadPriority backgroundLoadingPriority { get; set; }
    static public string buildGUID { get; }
    static public string cloudProjectId { get; }
    static public string companyName { get; }
    static public string consoleLogPath { get; }
    static public string dataPath { get; }
    static public bool genuine { get; }
    static public bool genuineCheckAvailable { get; }
    static public string identifier { get; }
    static public string installerName { get; }
    static public ApplicationInstallMode installMode { get; }
    static public NetworkReachability internetReachability { get; }
    static public bool isBatchMode { get; }
    static public bool isConsolePlatform { get; }
    static public bool isEditor { get; }
    static public bool isFocused { get; }
    static public bool isMobilePlatform { get; }
    static public bool isPlaying { get; }
    static public string persistentDataPath { get; }
    static public RuntimePlatform platform { get; }
    static public string productName { get; }
    static public bool runInBackground { get; set; }
    static public ApplicationSandboxType sandboxType { get; }
    static public string streamingAssetsPath { get; }
    static public SystemLanguage systemLanguage { get; }
    static public int targetFrameRate { get; set; }
    static public string temporaryCachePath { get; }
    static public string unityVersion { get; }
    static public string version { get; }

    static public event Action<string> deepLinkActivated;
    static public event Action<bool> focusChanged;
    static public event LogCallback logMessageReceived;
    static public event LogCallback logMessageReceivedThreaded;
    static public event LowMemoryCallback lowMemory;
    static public event Events.UnityAction onBeforeRender;
    static public event Action quitting;
    static public event Action unloading;
    static public event Func<bool> wantsToQuit;

    static public bool CanStreamedLevelBeLoaded(int levelIndex);
    static public bool CanStreamedLevelBeLoaded(string levelName);
    static public string[] GetBuildTags();
    static public StackTraceLogType GetStackTraceLogType(LogType logType);
    static public bool HasProLicense();
    static public bool HasUserAuthorization(UserAuthorization mode);
    static public bool IsPlaying(Object obj);
    static public void OpenURL(string url);
    static public void Quit();
    static public void Quit(int exitCode);
    static public bool RequestAdvertisingIdentifierAsync(AdvertisingIdentifierCallback delegateMethod);
    static public AsyncOperation RequestUserAuthorization(UserAuthorization mode);
    static public void SetBuildTags(string[] buildTags);
    static public void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType);
    static public void Unload();

}

}
