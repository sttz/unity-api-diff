using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class SketchUpImporter : UnityEditor.ModelImporter
{
    public double latitude { get; }
    public double longitude { get; }
    public double northCorrection { get; }

    public SketchUpImporter();

    public UnityEditor.SketchUpImportCamera GetDefaultCamera();
    public UnityEditor.SketchUpImportScene[] GetScenes();

}

}
