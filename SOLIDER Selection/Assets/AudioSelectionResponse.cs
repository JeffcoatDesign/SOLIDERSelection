using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSelectionResponse : MonoBehaviour, ISelectionResponse
{
    public void OnDeselect(Transform selection)
    {
        var selectionAudioDescription = selection.GetComponent<AudioDescription>();
        if (selectionAudioDescription != null) selectionAudioDescription.Stop();
    }

    public void OnSelect(Transform selection)
    {
        var selectionAudioDescription = selection.GetComponent<AudioDescription>();
        if (selectionAudioDescription != null) selectionAudioDescription.Play();
    }
}
