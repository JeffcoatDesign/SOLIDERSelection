using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CompositeSelectionResponse : MonoBehaviour, ISelectionResponse, IChangeable
{
    [SerializeField] GameObject selectionResponseHolder;

    private List<ISelectionResponse> _SelectionResponses = new List<ISelectionResponse>();
    private int _currentIndex;
    private Transform _selection;

    private void Start()
    {
        _SelectionResponses = new(selectionResponseHolder.GetComponents<ISelectionResponse>());
    }

    [ContextMenu("Next")]
    public void Next()
    {
        _SelectionResponses[_currentIndex].OnDeselect(_selection);
        _currentIndex = (_currentIndex + 1) % _SelectionResponses.Count;
        _SelectionResponses[_currentIndex].OnSelect(_selection);
    }

    public void OnDeselect(Transform selection)
    {
        _selection = null;
        if (HasSelection()) { 
            _SelectionResponses[_currentIndex].OnDeselect(selection);
        }
    }

    private bool HasSelection()
    {
        return _currentIndex > -1 && _currentIndex < _SelectionResponses.Count;
    }

    public void OnSelect(Transform selection)
    {
        _selection = selection;
        if (HasSelection())
            _SelectionResponses[_currentIndex].OnSelect(selection);
    }
}
