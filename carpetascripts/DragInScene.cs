using UnityEngine;
using UnityEngine.EventSystems;

public class DragInScene : MonoBehaviour , IDragHandler
{
    public float z = 0.0f;
    public float maximoX;
    public float minimoX;
    public float maximoY;
    public float minimoY;


    public void OnDrag(PointerEventData eventData)
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = z;

        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }
}

