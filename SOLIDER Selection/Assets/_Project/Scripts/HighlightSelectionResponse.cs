using UnityEngine;

public class HighlightSelectionResponse : MonoBehaviour, ISelectionResponse
{
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;

    public void OnSelect(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Renderer>();
        if (selectionRenderer != null)
        {
            selectionRenderer.material = highlightMaterial;
        }
    }

    public void OnDeselect(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Renderer>();
        if (selectionRenderer != null)
        {
            selectionRenderer.material = defaultMaterial;
        }
    }
}