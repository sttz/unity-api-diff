using System;
using UnityEngine;

namespace UnityEditor.PackageManager.UI
{

public interface IPackageManagerExtension
{
    public UIElements.VisualElement CreateExtensionUI();
    public void OnPackageAddedOrUpdated(UnityEditor.PackageManager.PackageInfo packageInfo);
    public void OnPackageRemoved(UnityEditor.PackageManager.PackageInfo packageInfo);
    public void OnPackageSelectionChange(UnityEditor.PackageManager.PackageInfo packageInfo);

}

}
