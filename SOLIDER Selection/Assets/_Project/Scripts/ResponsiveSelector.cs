using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponsiveSelector : MonoBehaviour, ISelector
{
    [SerializeField] private List<Transform> _selectables;
    [SerializeField] private float threshold;
    private Transform _selection;
    public void Check(Ray ray)
    {
        _selection = null;

        var closest = 0f;
        for (int i = 0; i < _selectables.Count; i++)
        {
            var vec1 = ray.direction;
            var vec2 = _selectables[i].position - ray.origin;

            var lookPercentage = Vector3.Dot(vec1.normalized, vec2.normalized);

            if (lookPercentage > threshold && lookPercentage > closest)
            {
                closest = lookPercentage;
                _selection = _selectables[i];
            }
        }
    }

    public Transform GetSelection()
    {
        return _selection;
    }
}
