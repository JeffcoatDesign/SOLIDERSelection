using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMesh : MonoBehaviour
{
    private MeshFilter _meshFilter;
    private Mesh _defaultMesh;
    [SerializeField] private Mesh _newMesh;
    void Start()
    {
        _meshFilter = GetComponent<MeshFilter>();
        _defaultMesh = _meshFilter.mesh;
    }

    public void SelectMesh ()
    {
        _meshFilter.mesh = _newMesh;
    }

    public void ResetMesh ()
    {
        _meshFilter.mesh = _defaultMesh;
    }
}
