using UnityEngine.EventSystems;
using UnityEngine;

public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject dd;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pointer entered");

        dd.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Pointer exited");

        dd.SetActive(false);
    }
}