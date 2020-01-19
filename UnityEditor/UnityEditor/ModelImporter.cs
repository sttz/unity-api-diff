using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class ModelImporter : UnityEditor.AssetImporter
{
    public bool addCollider { get; set; }
    public UnityEditor.ModelImporterAnimationCompression animationCompression { get; set; }
    public float animationPositionError { get; set; }
    public float animationRotationError { get; set; }
    public float animationScaleError { get; set; }
    public UnityEditor.ModelImporterAnimationType animationType { get; set; }
    public WrapMode animationWrapMode { get; set; }
    public bool bakeIK { get; set; }
    public UnityEditor.ModelImporterClipAnimation[] clipAnimations { get; set; }
    public UnityEditor.ModelImporterClipAnimation[] defaultClipAnimations { get; }
    public string[] extraExposedTransformPaths { get; set; }
    public string[] extraUserProperties { get; set; }
    public float fileScale { get; }
    public UnityEditor.ModelImporterGenerateAnimations generateAnimations { get; set; }
    public UnityEditor.ModelImporterGenerateMaterials generateMaterials { get; set; }
    public bool generateSecondaryUV { get; set; }
    public float globalScale { get; set; }
    public HumanDescription humanDescription { get; set; }
    public UnityEditor.ModelImporterHumanoidOversampling humanoidOversampling { get; set; }
    public bool importAnimatedCustomProperties { get; set; }
    public bool importAnimation { get; set; }
    public UnityEditor.ModelImporterNormals importBlendShapeNormals { get; set; }
    public bool importBlendShapes { get; set; }
    public bool importCameras { get; set; }
    public bool importConstraints { get; set; }
    public UnityEditor.TakeInfo[] importedTakeInfos { get; }
    public bool importLights { get; set; }
    public bool importMaterials { get; set; }
    public UnityEditor.ModelImporterNormals importNormals { get; set; }
    public UnityEditor.ModelImporterTangents importTangents { get; set; }
    public bool importVisibility { get; set; }
    public UnityEditor.ModelImporterIndexFormat indexFormat { get; set; }
    public bool isBakeIKSupported { get; }
    public bool isFileScaleUsed { get; }
    public bool isReadable { get; set; }
    public bool isTangentImportSupported { get; }
    public bool isUseFileUnitsSupported { get; }
    public bool keepQuads { get; set; }
    public UnityEditor.ModelImporterMaterialLocation materialLocation { get; set; }
    public UnityEditor.ModelImporterMaterialName materialName { get; set; }
    public UnityEditor.ModelImporterMaterialSearch materialSearch { get; set; }
    public int maxBonesPerVertex { get; set; }
    public UnityEditor.ModelImporterMeshCompression meshCompression { get; set; }
    public UnityEditor.MeshOptimizationFlags meshOptimizationFlags { get; set; }
    public float minBoneWeight { get; set; }
    public string motionNodeName { get; set; }
    public UnityEditor.ModelImporterNormalCalculationMode normalCalculationMode { get; set; }
    public UnityEditor.ModelImporterTangentSpaceMode normalImportMode { get; set; }
    public float normalSmoothingAngle { get; set; }
    public UnityEditor.ModelImporterNormalSmoothingSource normalSmoothingSource { get; set; }
    public bool optimizeGameObjects { get; set; }
    public bool optimizeMesh { get; set; }
    public bool optimizeMeshPolygons { get; set; }
    public bool optimizeMeshVertices { get; set; }
    public bool preserveHierarchy { get; set; }
    public string[] referencedClips { get; }
    public bool resampleCurves { get; set; }
    public bool resampleRotations { get; set; }
    public float secondaryUVAngleDistortion { get; set; }
    public float secondaryUVAreaDistortion { get; set; }
    public float secondaryUVHardAngle { get; set; }
    public float secondaryUVPackMargin { get; set; }
    public UnityEditor.ModelImporterSkinWeights skinWeights { get; set; }
    public bool sortHierarchyByName { get; set; }
    public Avatar sourceAvatar { get; set; }
    public bool splitAnimations { get; set; }
    public bool splitTangentsAcrossSeams { get; set; }
    public bool swapUVChannels { get; set; }
    public UnityEditor.ModelImporterTangentSpaceMode tangentImportMode { get; set; }
    public string[] transformPaths { get; }
    public bool useFileScale { get; set; }
    public bool useFileUnits { get; set; }
    public bool useSRGBMaterialColor { get; set; }
    public bool weldVertices { get; set; }

    public ModelImporter();

    public void CreateDefaultMaskForClip(UnityEditor.ModelImporterClipAnimation clip);
    public bool ExtractTextures(string folderPath);
    public bool SearchAndRemapMaterials(UnityEditor.ModelImporterMaterialName nameOption, UnityEditor.ModelImporterMaterialSearch searchOption);

}

}
