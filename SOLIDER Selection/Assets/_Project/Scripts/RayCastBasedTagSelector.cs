﻿using UnityEngine;
public class RayCastBasedTagSelector : MonoBehaviour, ISelector
{
    [SerializeField] private string selectableTag = "Selectable";

    private Transform _selection;

    public Transform GetSelection()
    {
        return _selection;
    }

    public void Check(Ray ray)
    {
        _selection = null;
        if (Physics.Raycast(ray, out var hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                _selection = selection;
            }
        }
    }
}