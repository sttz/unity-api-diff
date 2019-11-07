using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public abstract class GraphView : Experimental.UIElements.VisualElement, UnityEditor.Experimental.UIElements.GraphView.ISelection
{
    static public void CalculateFrameTransform(Rect rectToFit, Rect clientRect, int border, out Vector3 frameTranslation, out Vector3 frameScaling);

    public QueryState<UnityEditor.Experimental.UIElements.GraphView.Port> ports;

    public CanPasteSerializedDataDelegate canPasteSerializedData { get; set; }
    public Experimental.UIElements.VisualElement contentContainer { get; }
    public Experimental.UIElements.VisualElement contentViewContainer { get; private set; }
    public DeleteSelectionDelegate deleteSelection { get; set; }
    public QueryState<UnityEditor.Experimental.UIElements.GraphView.Edge> edges { get; private set; }
    public ElementResized elementResized { get; set; }
    public Action<UnityEditor.Experimental.UIElements.GraphView.Group, System.Collections.Generic.IEnumerable<UnityEditor.Experimental.UIElements.GraphView.GraphElement>> elementsAddedToGroup { get; set; }
    public Action<UnityEditor.Experimental.UIElements.GraphView.StackNode, int, System.Collections.Generic.IEnumerable<UnityEditor.Experimental.UIElements.GraphView.GraphElement>> elementsInsertedToStackNode { get; set; }
    public Action<UnityEditor.Experimental.UIElements.GraphView.Group, System.Collections.Generic.IEnumerable<UnityEditor.Experimental.UIElements.GraphView.GraphElement>> elementsRemovedFromGroup { get; set; }
    public Action<UnityEditor.Experimental.UIElements.GraphView.StackNode, System.Collections.Generic.IEnumerable<UnityEditor.Experimental.UIElements.GraphView.GraphElement>> elementsRemovedFromStackNode { get; set; }
    public QueryState<UnityEditor.Experimental.UIElements.GraphView.GraphElement> graphElements { get; private set; }
    public GraphViewChanged graphViewChanged { get; set; }
    public Action<UnityEditor.Experimental.UIElements.GraphView.Group, string> groupTitleChanged { get; set; }
    public bool isReframable { get; set; }
    public float maxScale { get; }
    public float minScale { get; }
    public Action<UnityEditor.Experimental.UIElements.GraphView.NodeCreationContext> nodeCreationRequest { get; set; }
    public QueryState<UnityEditor.Experimental.UIElements.GraphView.Node> nodes { get; private set; }
    public float referenceScale { get; }
    public float scale { get; }
    public float scaleStep { get; }
    public System.Collections.Generic.List<UnityEditor.Experimental.UIElements.GraphView.ISelectable> selection { get; protected set; }
    public SerializeGraphElementsDelegate serializeGraphElements { get; set; }
    public UnserializeAndPasteDelegate unserializeAndPaste { get; set; }
    public Experimental.UIElements.VisualElement viewport { get; }
    public Experimental.UIElements.ITransform viewTransform { get; }
    public ViewTransformChanged viewTransformChanged { get; set; }
    public int zoomerMaxElementCountWithPixelCacheRegen { get; set; }

    protected GraphView();

    public void AddElement(UnityEditor.Experimental.UIElements.GraphView.GraphElement graphElement);
    public void AddLayer(int index);
    public void AddToSelection(UnityEditor.Experimental.UIElements.GraphView.ISelectable selectable);
    public void BuildContextualMenu(Experimental.UIElements.ContextualMenuPopulateEvent evt);
    public Rect CalculateRectToFitAll(Experimental.UIElements.VisualElement container);
    protected bool CanPasteSerializedData(string data);
    public void ClearSelection();
    public void DeleteElements(System.Collections.Generic.IEnumerable<UnityEditor.Experimental.UIElements.GraphView.GraphElement> elementsToRemove);
    public Experimental.UIElements.EventPropagation DeleteSelection();
    protected void DeleteSelectionOperation(string operationName, AskUser askUser);
    public Experimental.UIElements.EventPropagation FrameAll();
    public Experimental.UIElements.EventPropagation FrameNext();
    public Experimental.UIElements.EventPropagation FrameNext(Func<UnityEditor.Experimental.UIElements.GraphView.GraphElement, bool> predicate);
    public Experimental.UIElements.EventPropagation FrameOrigin();
    public Experimental.UIElements.EventPropagation FramePrev();
    public Experimental.UIElements.EventPropagation FramePrev(Func<UnityEditor.Experimental.UIElements.GraphView.GraphElement, bool> predicate);
    public Experimental.UIElements.EventPropagation FrameSelection();
    public System.Collections.Generic.List<UnityEditor.Experimental.UIElements.GraphView.Port> GetCompatiblePorts(UnityEditor.Experimental.UIElements.GraphView.Port startPort, UnityEditor.Experimental.UIElements.GraphView.NodeAdapter nodeAdapter);
    public UnityEditor.Experimental.UIElements.GraphView.Edge GetEdgeByGuid(string guid);
    public UnityEditor.Experimental.UIElements.GraphView.GraphElement GetElementByGuid(string guid);
    public UnityEditor.Experimental.UIElements.GraphView.Node GetNodeByGuid(string guid);
    public UnityEditor.Experimental.UIElements.GraphView.Port GetPortByGuid(string guid);
    public void OnPersistentDataReady();
    public void RemoveElement(UnityEditor.Experimental.UIElements.GraphView.GraphElement graphElement);
    public void RemoveFromSelection(UnityEditor.Experimental.UIElements.GraphView.ISelectable selectable);
    protected string SerializeGraphElements(System.Collections.Generic.IEnumerable<UnityEditor.Experimental.UIElements.GraphView.GraphElement> elements);
    public void SetupZoom(float minScaleSetup, float maxScaleSetup);
    public void SetupZoom(float minScaleSetup, float maxScaleSetup, float scaleStepSetup, float referenceScaleSetup);
    protected void UnserializeAndPasteOperation(string operationName, string data);
    public void UpdateViewTransform(Vector3 newPosition, Vector3 newScale);
    protected void ValidateTransform();

    public delegate UnityEditor.Experimental.UIElements.GraphView.GraphViewChange GraphViewChanged(UnityEditor.Experimental.UIElements.GraphView.GraphViewChange graphViewChange);

    public delegate void ElementResized(Experimental.UIElements.VisualElement visualElement);

    public delegate void ViewTransformChanged(UnityEditor.Experimental.UIElements.GraphView.GraphView graphView);

    public enum FrameType
    {
        All = 0,
        Selection = 1,
        Origin = 2,
    }

    public enum AskUser
    {
        AskUser = 0,
        DontAskUser = 1,
    }

    public delegate string SerializeGraphElementsDelegate(System.Collections.Generic.IEnumerable<UnityEditor.Experimental.UIElements.GraphView.GraphElement> elements);

    public delegate bool CanPasteSerializedDataDelegate(string data);

    public delegate void UnserializeAndPasteDelegate(string operationName, string data);

    public delegate void DeleteSelectionDelegate(string operationName, AskUser askUser);

}

}
