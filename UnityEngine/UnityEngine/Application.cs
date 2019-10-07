using System;
using UnityEngine;

namespace UnityEngine
{

public class Application
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
    static public bool isLoadingLevel { get; }
    static public bool isMobilePlatform { get; }
    static public bool isPlayer { get; }
    static public bool isPlaying { get; }
    static public bool isShowingSplashScreen { get; }
    static public int levelCount { get; }
    static public int loadedLevel { get; }
    static public string loadedLevelName { get; }
    static public string persistentDataPath { get; }
    static public RuntimePlatform platform { get; }
    static public string productName { get; }
    static public bool runInBackground { get; set; }
    static public ApplicationSandboxType sandboxType { get; }
    static public StackTraceLogType stackTraceLogType { get; set; }
    static public int streamedBytes { get; }
    static public string streamingAssetsPath { get; }
    static public SystemLanguage systemLanguage { get; }
    static public int targetFrameRate { get; set; }
    static public string temporaryCachePath { get; }
    static public string unityVersion { get; }
    static public string version { get; }
    static public bool webSecurityEnabled { get; }

    static public event Action<string> deepLinkActivated;
    static public event Action<bool> focusChanged;
    static public event LogCallback logMessageReceived;
    static public event LogCallback logMessageReceivedThreaded;
    static public event LowMemoryCallback lowMemory;
    static public event Events.UnityAction onBeforeRender;
    static public event Action quitting;
    static public event Func<bool> wantsToQuit;

    static public void CancelQuit();
    static public bool CanStreamedLevelBeLoaded(int levelIndex);
    static public bool CanStreamedLevelBeLoaded(string levelName);
    static public void CaptureScreenshot(string filename, int superSize);
    static public void CaptureScreenshot(string filename);
    static public void DontDestroyOnLoad(Object o);
    static public void ExternalCall(string functionName, object[] args);
    static public void ExternalEval(string script);
    static public void ForceCrash(int mode);
    static public string[] GetBuildTags();
    static public StackTraceLogType GetStackTraceLogType(LogType logType);
    static public float GetStreamProgressForLevel(int levelIndex);
    static public float GetStreamProgressForLevel(string levelName);
    static public bool HasProLicense();
    static public bool HasUserAuthorization(UserAuthorization mode);
    static public bool IsPlaying(Object obj);
    static public void LoadLevel(int index);
    static public void LoadLevel(string name);
    static public void LoadLevelAdditive(int index);
    static public void LoadLevelAdditive(string name);
    static public AsyncOperation LoadLevelAdditiveAsync(int index);
    static public AsyncOperation LoadLevelAdditiveAsync(string levelName);
    static public AsyncOperation LoadLevelAsync(int index);
    static public AsyncOperation LoadLevelAsync(string levelName);
    static public void OpenURL(string url);
    static public void Quit(int exitCode);
    static public void Quit();
    static public void RegisterLogCallback(LogCallback handler);
    static public void RegisterLogCallbackThreaded(LogCallback handler);
    static public bool RequestAdvertisingIdentifierAsync(AdvertisingIdentifierCallback delegateMethod);
    static public AsyncOperation RequestUserAuthorization(UserAuthorization mode);
    static public void SetBuildTags(string[] buildTags);
    static public void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType);
    static public void Unload();
    static public bool UnloadLevel(int index);
    static public bool UnloadLevel(string scenePath);

    public Application();

    public delegate void AdvertisingIdentifierCallback(string advertisingId, bool trackingEnabled, string errorMsg);

    public delegate void LowMemoryCallback();

    public delegate void LogCallback(string condition, string stackTrace, LogType type);

}

}
