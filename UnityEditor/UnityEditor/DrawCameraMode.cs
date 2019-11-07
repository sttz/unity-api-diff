using System;
using UnityEngine;

namespace UnityEditor
{

public enum DrawCameraMode
{
    UserDefined = -2147483648,
    Normal = -1,
    Textured = 0,
    Wireframe = 1,
    TexturedWire = 2,
    ShadowCascades = 3,
    RenderPaths = 4,
    AlphaChannel = 5,
    Overdraw = 6,
    Mipmaps = 7,
    DeferredDiffuse = 8,
    DeferredSpecular = 9,
    DeferredSmoothness = 10,
    DeferredNormal = 11,
    Charting = -12,
    RealtimeCharting = 12,
    Systems = 13,
    Albedo = -14,
    RealtimeAlbedo = 14,
    Emissive = -15,
    RealtimeEmissive = 15,
    Irradiance = -16,
    RealtimeIndirect = 16,
    Directionality = -17,
    RealtimeDirectionality = 17,
    Baked = -18,
    BakedLightmap = 18,
    Clustering = 19,
    LitClustering = 20,
    ValidateAlbedo = 21,
    ValidateMetalSpecular = 22,
    ShadowMasks = 23,
    LightOverlap = 24,
    BakedAlbedo = 25,
    BakedEmissive = 26,
    BakedDirectionality = 27,
    BakedTexelValidity = 28,
    BakedIndices = 29,
    BakedCharting = 30,
    SpriteMask = 31,
    BakedUVOverlap = 32,
    TextureStreaming = 33,
    BakedLightmapCulling = 34,
}

}
