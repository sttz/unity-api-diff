using System;
using UnityEngine;

namespace UnityEditor
{

public enum ModelImporterMaterialName
{
    BasedOnTextureName = 0,
    BasedOnMaterialName = 1,
    BasedOnModelNameAndMaterialName = 2,
    BasedOnTextureName_Or_ModelNameAndMaterialName = 3,
}

}
