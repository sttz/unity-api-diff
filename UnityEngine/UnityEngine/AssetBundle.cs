using System;
using UnityEngine;

namespace UnityEngine
{

public class AssetBundle : Object
{
    static public AssetBundle CreateFromFile(string path);
    static public AssetBundleCreateRequest CreateFromMemory(byte[] binary);
    static public AssetBundle CreateFromMemoryImmediate(byte[] binary);
    static public System.Collections.Generic.IEnumerable<AssetBundle> GetAllLoadedAssetBundles();
    static public AssetBundle LoadFromFile(string path);
    static public AssetBundle LoadFromFile(string path, uint crc);
    static public AssetBundle LoadFromFile(string path, uint crc, ulong offset);
    static public AssetBundleCreateRequest LoadFromFileAsync(string path);
    static public AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc);
    static public AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc, ulong offset);
    static public AssetBundle LoadFromMemory(byte[] binary);
    static public AssetBundle LoadFromMemory(byte[] binary, uint crc);
    static public AssetBundleCreateRequest LoadFromMemoryAsync(byte[] binary);
    static public AssetBundleCreateRequest LoadFromMemoryAsync(byte[] binary, uint crc);
    static public AssetBundle LoadFromStream(System.IO.Stream stream, uint crc, uint managedReadBufferSize);
    static public AssetBundle LoadFromStream(System.IO.Stream stream, uint crc);
    static public AssetBundle LoadFromStream(System.IO.Stream stream);
    static public AssetBundleCreateRequest LoadFromStreamAsync(System.IO.Stream stream, uint crc, uint managedReadBufferSize);
    static public AssetBundleCreateRequest LoadFromStreamAsync(System.IO.Stream stream, uint crc);
    static public AssetBundleCreateRequest LoadFromStreamAsync(System.IO.Stream stream);
    static public AssetBundleRecompressOperation RecompressAssetBundleAsync(string inputPath, string outputPath, BuildCompression method, uint expectedCRC = 0, ThreadPriority priority = 0);
    static public void UnloadAllAssetBundles(bool unloadAllObjects);

    public bool isStreamedSceneAssetBundle { get; }
    public Object mainAsset { get; }

    public string[] AllAssetNames();
    public bool Contains(string name);
    public string[] GetAllAssetNames();
    public string[] GetAllScenePaths();
    public Object Load(string name);
    public Object Load(string name);
    public Object[] LoadAll();
    public T[] LoadAll();
    public Object[] LoadAllAssets();
    public T[] LoadAllAssets();
    public Object[] LoadAllAssets(Type type);
    public AssetBundleRequest LoadAllAssetsAsync();
    public AssetBundleRequest LoadAllAssetsAsync();
    public AssetBundleRequest LoadAllAssetsAsync(Type type);
    public Object LoadAsset(string name);
    public T LoadAsset(string name);
    public Object LoadAsset(string name, Type type);
    public AssetBundleRequest LoadAssetAsync(string name);
    public AssetBundleRequest LoadAssetAsync(string name);
    public AssetBundleRequest LoadAssetAsync(string name, Type type);
    public Object[] LoadAssetWithSubAssets(string name);
    public T[] LoadAssetWithSubAssets(string name);
    public Object[] LoadAssetWithSubAssets(string name, Type type);
    public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name);
    public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name);
    public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, Type type);
    public void Unload(bool unloadAllLoadedObjects);

}

}
