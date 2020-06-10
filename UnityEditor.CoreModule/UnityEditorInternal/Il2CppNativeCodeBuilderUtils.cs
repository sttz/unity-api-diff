using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public static class Il2CppNativeCodeBuilderUtils
{
    static public IEnumerable<string> AddBuilderArguments(UnityEditorInternal.Il2CppNativeCodeBuilder builder, string outputRelativePath, IEnumerable<string> includeRelativePaths, IEnumerable<string> additionalLibs, UnityEditor.Il2CppCompilerConfiguration compilerConfiguration);
    static public void ClearAndPrepareCacheDirectory(UnityEditorInternal.Il2CppNativeCodeBuilder builder);
    static public void ClearCacheIfEditorVersionDiffers(UnityEditorInternal.Il2CppNativeCodeBuilder builder, string currentEditorVersion);
    static public string ObjectFilePathInCacheDirectoryFor(string builderCacheDirectory);
    static public void PrepareCacheDirectory(UnityEditorInternal.Il2CppNativeCodeBuilder builder, string currentEditorVersion);

}

}
