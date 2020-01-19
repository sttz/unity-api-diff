using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class LocalizationAsset : Object
{
    public bool isEditorAsset { get; set; }
    public string localeIsoCode { get; set; }

    public LocalizationAsset();

    public string GetLocalizedString(string original);
    public void SetLocalizedString(string original, string localized);

}

}
