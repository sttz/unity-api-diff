using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public abstract class GraphView : UIElements.VisualElement, UnityEditor.Experimental.GraphView.ISelection
{
    static public void CalculateFrameTransform(Rect rectToFit, Rect clientRect, int border, out Vector3 frameTranslation, out Vector3 frameScaling);

    public UIElements.UQueryState<UnityEditor.Experimental.GraphView.Port> ports;

    public CanPasteSerializedDataDelegate canPasteSerializedData { get; set; }
    public UIElements.VisualElement contentContainer { get; }
    public UIElements.VisualElement contentViewContainer { get; private set; }
    public DeleteSelectionDelegate deleteSelection { get; set; }
    public UIElements.UQueryState<UnityEditor.Experimental.GraphView.Edge> edges { get; private set; }
    public ElementResized elementResized { get; set; }
    public Action<UnityEditor.Experimental.GraphView.Group, System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.GraphElement>> elementsAddedToGroup { get; set; }
    public Action<UnityEditor.Experimental.GraphView.StackNode, int, System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.GraphElement>> elementsInsertedToStackNode { get; set; }
    public Action<UnityEditor.Experimental.GraphView.Group, System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.GraphElement>> elementsRemovedFromGroup { get; set; }
    public Action<UnityEditor.Experimental.GraphView.StackNode, System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.GraphElement>> elementsRemovedFromStackNode { get; set; }
    public UIElements.UQueryState<UnityEditor.Experimental.GraphView.GraphElement> graphElements { get; private set; }
    public GraphViewChanged graphViewChanged { get; set; }
    public Action<UnityEditor.Experimental.GraphView.Group, string> groupTitleChanged { get; set; }
    public bool isReframable { get; set; }
    public float maxScale { get; }
    public float minScale { get; }
    public Action<UnityEditor.Experimental.GraphView.NodeCreationContext> nodeCreationRequest { get; set; }
    public UIElements.UQueryState<UnityEditor.Experimental.GraphView.Node> nodes { get; private set; }
    public float referenceScale { get; }
    public float scale { get; }
    public float scaleStep { get; }
    public System.Collections.Generic.List<UnityEditor.Experimental.GraphView.ISelectable> selection { get; protected set; }
    public SerializeGraphElementsDelegate serializeGraphElements { get; set; }
    public bool supportsWindowedBlackboard { get; }
    public UnserializeAndPasteDelegate unserializeAndPaste { get; set; }
    public UIElements.VisualElement viewport { get; }
    public UIElements.ITransform viewTransform { get; }
    public ViewTransformChanged viewTransformChanged { get; set; }
    public int zoomerMaxElementCountWithPixelCacheRegen { get; set; }

    protected GraphView();

    public void AddElement(UnityEditor.Experimental.GraphView.GraphElement graphElement);
    public void AddLayer(int index);
    public void AddToSelection(UnityEditor.Experimental.GraphView.ISelectable selectable);
    public void BuildContextualMenu(UIElements.ContextualMenuPopulateEvent evt);
    public Rect CalculateRectToFitAll(UIElements.VisualElement container);
    protected bool CanPasteSerializedData(string data);
    public void ClearSelection();
    public void DeleteElements(System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.GraphElement> elementsToRemove);
    public UnityEditor.Experimental.GraphView.EventPropagation DeleteSelection();
    protected void DeleteSelectionOperation(string operationName, AskUser askUser);
    protected void ExecuteDefaultAction(UIElements.EventBase evt);
    protected void ExecuteDefaultActionAtTarget(UIElements.EventBase evt);
    public UnityEditor.Experimental.GraphView.EventPropagation FrameAll();
    public UnityEditor.Experimental.GraphView.EventPropagation FrameNext();
    public UnityEditor.Experimental.GraphView.EventPropagation FrameNext(Func<UnityEditor.Experimental.GraphView.GraphElement, bool> predicate);
    public UnityEditor.Experimental.GraphView.EventPropagation FrameOrigin();
    public UnityEditor.Experimental.GraphView.EventPropagation FramePrev();
    public UnityEditor.Experimental.GraphView.EventPropagation FramePrev(Func<UnityEditor.Experimental.GraphView.GraphElement, bool> predicate);
    public UnityEditor.Experimental.GraphView.EventPropagation FrameSelection();
    public UnityEditor.Experimental.GraphView.Blackboard GetBlackboard();
    public System.Collections.Generic.List<UnityEditor.Experimental.GraphView.Port> GetCompatiblePorts(UnityEditor.Experimental.GraphView.Port startPort, UnityEditor.Experimental.GraphView.NodeAdapter nodeAdapter);
    public UnityEditor.Experimental.GraphView.Edge GetEdgeByGuid(string guid);
    public UnityEditor.Experimental.GraphView.GraphElement GetElementByGuid(string guid);
    public UnityEditor.Experimental.GraphView.Node GetNodeByGuid(string guid);
    public UnityEditor.Experimental.GraphView.Port GetPortByGuid(string guid);
    public void ReleaseBlackboard(UnityEditor.Experimental.GraphView.Blackboard toRelease);
    public void RemoveElement(UnityEditor.Experimental.GraphView.GraphElement graphElement);
    public void RemoveFromSelection(UnityEditor.Experimental.GraphView.ISelectable selectable);
    protected string SerializeGraphElements(System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.GraphElement> elements);
    public void SetupZoom(float minScaleSetup, float maxScaleSetup);
    public void SetupZoom(float minScaleSetup, float maxScaleSetup, float scaleStepSetup, float referenceScaleSetup);
    protected void UnserializeAndPasteOperation(string operationName, string data);
    public void UpdateViewTransform(Vector3 newPosition, Vector3 newScale);
    protected void ValidateTransform();

    public delegate UnityEditor.Experimental.GraphView.GraphViewChange GraphViewChanged(UnityEditor.Experimental.GraphView.GraphViewChange graphViewChange);

    public delegate void ElementResized(UIElements.VisualElement visualElement);

    public delegate void ViewTransformChanged(UnityEditor.Experimental.GraphView.GraphView graphView);

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

    public delegate string SerializeGraphElementsDelegate(System.Collections.Generic.IEnumerable<UnityEditor.Experimental.GraphView.GraphElement> elements);

    public delegate bool CanPasteSerializedDataDelegate(string data);

    public delegate void UnserializeAndPasteDelegate(string operationName, string data);

    public delegate void DeleteSelectionDelegate(string operationName, AskUser askUser);

}

}
