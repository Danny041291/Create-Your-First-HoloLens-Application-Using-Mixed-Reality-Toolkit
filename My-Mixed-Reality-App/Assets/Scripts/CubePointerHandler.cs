using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

public class CubePointerHandler : MonoBehaviour, IMixedRealityPointerHandler
{

    public Material OnPointerDownMaterial;
    public Material OnPointerUpMaterial;
    public Material OnPointerClickedMaterial;
    public Material OnPointerDraggedMaterial;

    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        gameObject.GetComponent<MeshRenderer>().material = OnPointerDownMaterial;
    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        gameObject.GetComponent<MeshRenderer>().material = OnPointerUpMaterial;
    }

    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        /* Decomment the code below to test OnPointerClicked event */
        // gameObject.GetComponent<MeshRenderer>().material = OnPointerClickedMaterial;
    }

    public void OnPointerDragged(MixedRealityPointerEventData eventData)
    {
        /* Decomment the code below to test OnPointerDragged event */
        // gameObject.GetComponent<MeshRenderer>().material = OnPointerDraggedMaterial;
    }


}
