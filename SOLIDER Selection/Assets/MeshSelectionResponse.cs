using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshSelectionResponse : MonoBehaviour, ISelectionResponse
{
    public void OnDeselect(Transform selection)
    {
        var changeMesh = selection.GetComponent<ChangeMesh>();
        changeMesh.ResetMesh();
    }

    public void OnSelect(Transform selection)
    {
        var changeMesh = selection.GetComponent<ChangeMesh>();
        changeMesh.SelectMesh();
    }
}
