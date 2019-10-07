using System;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public class GraphicsFormatUtility
{
    static public uint ComputeMipmapSize(int width, int height, Experimental.Rendering.GraphicsFormat format);
    static public uint ComputeMipmapSize(int width, int height, int depth, Experimental.Rendering.GraphicsFormat format);
    static public Experimental.Rendering.GraphicsFormat ConvertToAlphaFormat(Experimental.Rendering.GraphicsFormat format);
    static public uint GetAlphaComponentCount(Experimental.Rendering.GraphicsFormat format);
    static public uint GetBlockHeight(Experimental.Rendering.GraphicsFormat format);
    static public uint GetBlockSize(Experimental.Rendering.GraphicsFormat format);
    static public uint GetBlockWidth(Experimental.Rendering.GraphicsFormat format);
    static public uint GetColorComponentCount(Experimental.Rendering.GraphicsFormat format);
    static public uint GetComponentCount(Experimental.Rendering.GraphicsFormat format);
    static public string GetFormatString(Experimental.Rendering.GraphicsFormat format);
    static public Experimental.Rendering.GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB);
    static public Experimental.Rendering.GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB);
    static public Experimental.Rendering.GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite);
    static public Experimental.Rendering.GraphicsFormat GetLinearFormat(Experimental.Rendering.GraphicsFormat format);
    static public RenderTextureFormat GetRenderTextureFormat(Experimental.Rendering.GraphicsFormat format);
    static public Experimental.Rendering.GraphicsFormat GetSRGBFormat(Experimental.Rendering.GraphicsFormat format);
    static public Rendering.FormatSwizzle GetSwizzleA(Experimental.Rendering.GraphicsFormat format);
    static public Rendering.FormatSwizzle GetSwizzleB(Experimental.Rendering.GraphicsFormat format);
    static public Rendering.FormatSwizzle GetSwizzleG(Experimental.Rendering.GraphicsFormat format);
    static public Rendering.FormatSwizzle GetSwizzleR(Experimental.Rendering.GraphicsFormat format);
    static public TextureFormat GetTextureFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool HasAlphaChannel(Experimental.Rendering.GraphicsFormat format);
    static public bool Is16BitPackedFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsAlphaOnlyFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsAlphaTestFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsASTCFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsBCFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsBPTCFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsCompressedFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsCrunchFormat(TextureFormat format);
    static public bool IsDepthFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsDXTCFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsEACFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsETCFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsFloatFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsHalfFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsIEEE754Format(Experimental.Rendering.GraphicsFormat format);
    static public bool IsIntegerFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsNormFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsPackedFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsPVRTCFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsRGTCFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsSignedFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsSIntFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsSNormFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsSRGBFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsStencilFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsSwizzleFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsUIntFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsUNormFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsUnsignedFormat(Experimental.Rendering.GraphicsFormat format);
    static public bool IsXRFormat(Experimental.Rendering.GraphicsFormat format);

    public GraphicsFormatUtility();

}

}
