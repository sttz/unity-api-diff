using System;
using UnityEngine;

namespace UnityEngine
{

public struct BuildCompression
{
    static public BuildCompression LZ4;
    static public BuildCompression LZ4Runtime;
    static public BuildCompression LZMA;
    static public BuildCompression Uncompressed;
    static public BuildCompression UncompressedRuntime;

    public uint blockSize { get; private set; }
    public CompressionType compression { get; private set; }
    public CompressionLevel level { get; private set; }

}

}
