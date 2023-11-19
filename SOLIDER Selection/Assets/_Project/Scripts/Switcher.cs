using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    public List<GameObject> ChangeableObjects;

    private List<IChangeable> _changeableObjects = new List<IChangeable>();

    private void Start()
    {
        foreach (var changeableObject in ChangeableObjects) {
            var newChangeableObject = changeableObject.GetComponent<IChangeable>();
            _changeableObjects.Add(newChangeableObject);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N)) {
            foreach (IChangeable changeable in _changeableObjects)
            {
                changeable.Next();
            }
        }
    }
}

public interface IChangeable
{
    void Next();
}