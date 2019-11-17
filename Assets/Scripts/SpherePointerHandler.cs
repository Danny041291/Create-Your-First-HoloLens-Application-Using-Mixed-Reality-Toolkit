using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

public class SpherePointerHandler : MonoBehaviour, IMixedRealityPointerHandler
{

    public Material OnPointerClickedMaterial;
    public Material OnPointerDraggedMaterial;

    public void OnPointerDown(MixedRealityPointerEventData eventData) { }

    public void OnPointerUp(MixedRealityPointerEventData eventData) { }

    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        gameObject.GetComponent<MeshRenderer>().material = OnPointerClickedMaterial;
    }

    public void OnPointerDragged(MixedRealityPointerEventData eventData)
    {
        gameObject.GetComponent<MeshRenderer>().material = OnPointerDraggedMaterial;
    }


}
