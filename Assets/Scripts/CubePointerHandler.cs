using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

public class CubePointerHandler : MonoBehaviour, IMixedRealityPointerHandler
{

    public Material OnPointerDownMaterial;
    public Material OnPointerUpMaterial;

    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        gameObject.GetComponent<MeshRenderer>().material = OnPointerDownMaterial;
    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        gameObject.GetComponent<MeshRenderer>().material = OnPointerUpMaterial;
    }

    public void OnPointerClicked(MixedRealityPointerEventData eventData) { }

    public void OnPointerDragged(MixedRealityPointerEventData eventData) { }

}
