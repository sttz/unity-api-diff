using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct ObjectChangeEventStream : IDisposable
{
    public bool isCreated { get; }
    public int length { get; }

    public UnityEditor.ObjectChangeEventStream Clone(Unity.Collections.Allocator allocator);
    public void Dispose();
    public void GetChangeAssetObjectPropertiesEvent(int eventIdx, out UnityEditor.ChangeAssetObjectPropertiesEventArgs data);
    public void GetChangeGameObjectOrComponentPropertiesEvent(int eventIdx, out UnityEditor.ChangeGameObjectOrComponentPropertiesEventArgs data);
    public void GetChangeGameObjectParentEvent(int eventIdx, out UnityEditor.ChangeGameObjectParentEventArgs data);
    public void GetChangeGameObjectStructureEvent(int eventIdx, out UnityEditor.ChangeGameObjectStructureEventArgs data);
    public void GetChangeGameObjectStructureHierarchyEvent(int eventIdx, out UnityEditor.ChangeGameObjectStructureHierarchyEventArgs data);
    public void GetChangeSceneEvent(int eventIdx, out UnityEditor.ChangeSceneEventArgs data);
    public void GetCreateAssetObjectEvent(int eventIdx, out UnityEditor.CreateAssetObjectEventArgs data);
    public void GetCreateGameObjectHierarchyEvent(int eventIdx, out UnityEditor.CreateGameObjectHierarchyEventArgs data);
    public void GetDestroyAssetObjectEvent(int eventIdx, out UnityEditor.DestroyAssetObjectEventArgs data);
    public void GetDestroyGameObjectHierarchyEvent(int eventIdx, out UnityEditor.DestroyGameObjectHierarchyEventArgs data);
    public UnityEditor.ObjectChangeKind GetEventType(int eventIdx);
    public void GetUpdatePrefabInstancesEvent(int eventIdx, out UnityEditor.UpdatePrefabInstancesEventArgs data);

    public struct Builder : IDisposable
    {
        public int eventCount { get; }

        public Builder(Unity.Collections.Allocator allocator);

        public void Dispose();
        public void PushChangeAssetObjectPropertiesEvent(UnityEditor.ChangeAssetObjectPropertiesEventArgs data);
        public void PushChangeGameObjectOrComponentPropertiesEvent(UnityEditor.ChangeGameObjectOrComponentPropertiesEventArgs data);
        public void PushChangeGameObjectParentEvent(UnityEditor.ChangeGameObjectParentEventArgs data);
        public void PushChangeGameObjectStructureEvent(UnityEditor.ChangeGameObjectStructureEventArgs data);
        public void PushChangeGameObjectStructureHierarchyEvent(UnityEditor.ChangeGameObjectStructureHierarchyEventArgs data);
        public void PushChangeSceneEvent(UnityEditor.ChangeSceneEventArgs data);
        public void PushCreateAssetObjectEvent(UnityEditor.CreateAssetObjectEventArgs data);
        public void PushCreateGameObjectHierarchyEvent(UnityEditor.CreateGameObjectHierarchyEventArgs data);
        public void PushDestroyAssetObjectEvent(UnityEditor.DestroyAssetObjectEventArgs data);
        public void PushDestroyGameObjectHierarchyEvent(UnityEditor.DestroyGameObjectHierarchyEventArgs data);
        public void PushUpdatePrefabInstancesEvent(UnityEditor.UpdatePrefabInstancesEventArgs data);
        public UnityEditor.ObjectChangeEventStream ToStream(Unity.Collections.Allocator allocator);

    }

}

}
