using System;
using System.Collections;
using System.Collections.Generic;
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
