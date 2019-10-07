using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class Projector : Behaviour
{
    public float aspectRatio { get; set; }
    public float farClipPlane { get; set; }
    public float fieldOfView { get; set; }
    public int ignoreLayers { get; set; }
    public bool isOrthoGraphic { get; set; }
    public Material material { get; set; }
    public float nearClipPlane { get; set; }
    public bool orthographic { get; set; }
    public float orthographicSize { get; set; }
    public float orthoGraphicSize { get; set; }

    public Projector();

}

}
