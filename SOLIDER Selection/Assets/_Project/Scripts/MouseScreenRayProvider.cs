using UnityEngine;
public class MouseScreenRayProvider : MonoBehaviour, IRayProvider
{
    public Ray CreateRay() => Camera.main.ScreenPointToRay(Input.mousePosition);
}