using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class EditorSettings : Object
{
    static public UnityEditor.AssetPipelineMode assetPipelineMode { get; }
    static public bool asyncShaderCompilation { get; set; }
    static public bool cacheServerEnableAuth { get; set; }
    static public bool cacheServerEnableDownload { get; set; }
    static public bool cacheServerEnableTls { get; set; }
    static public bool cacheServerEnableUpload { get; set; }
    static public string cacheServerEndpoint { get; set; }
    static public UnityEditor.CacheServerMode cacheServerMode { get; set; }
    static public string cacheServerNamespacePrefix { get; set; }
    static public bool cachingShaderPreprocessor { get; set; }
    static public UnityEditor.EditorBehaviorMode defaultBehaviorMode { get; set; }
    static public bool disableCookiesInLightmapper { get; set; }
    static public bool enableTextureStreamingInEditMode { get; set; }
    static public bool enableTextureStreamingInPlayMode { get; set; }
    static public UnityEditor.EnterPlayModeOptions enterPlayModeOptions { get; set; }
    static public bool enterPlayModeOptionsEnabled { get; set; }
    static public int etcTextureBestCompressor { get; set; }
    static public int etcTextureCompressorBehavior { get; set; }
    static public int etcTextureFastCompressor { get; set; }
    static public int etcTextureNormalCompressor { get; set; }
    static public string externalVersionControl { get; set; }
    static public UnityEditor.LineEndingsMode lineEndingsForNewScripts { get; set; }
    static public UnityEditor.SceneAsset prefabRegularEnvironment { get; set; }
    static public UnityEditor.SceneAsset prefabUIEnvironment { get; set; }
    static public string[] projectGenerationBuiltinExtensions { get; }
    static public string projectGenerationRootNamespace { get; set; }
    static public string[] projectGenerationUserExtensions { get; set; }
    static public UnityEditor.SerializationMode serializationMode { get; set; }
    static public bool serializeInlineMappingsOnOneLine { get; set; }
    static public UnityEditor.SpritePackerMode spritePackerMode { get; set; }
    static public int spritePackerPaddingPower { get; set; }
    static public string unityRemoteCompression { get; set; }
    static public string unityRemoteDevice { get; set; }
    static public string unityRemoteJoystickSource { get; set; }
    static public string unityRemoteResolution { get; set; }
    static public bool useLegacyProbeSampleCount { get; set; }
    static public bool webSecurityEmulationEnabled { get; set; }
    static public string webSecurityEmulationHostUrl { get; set; }

}

}
