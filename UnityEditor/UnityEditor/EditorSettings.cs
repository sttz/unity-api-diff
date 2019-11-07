using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class EditorSettings : Object
{
    static public UnityEditor.EditorBehaviorMode defaultBehaviorMode { get; set; }
    static public bool enableTextureStreamingInPlayMode { get; set; }
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
    static public UnityEditor.SpritePackerMode spritePackerMode { get; set; }
    static public int spritePackerPaddingPower { get; set; }
    static public string unityRemoteCompression { get; set; }
    static public string unityRemoteDevice { get; set; }
    static public string unityRemoteJoystickSource { get; set; }
    static public string unityRemoteResolution { get; set; }
    static public bool webSecurityEmulationEnabled { get; set; }
    static public string webSecurityEmulationHostUrl { get; set; }

}

}
