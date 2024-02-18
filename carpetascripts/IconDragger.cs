using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IconDragger : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public static GameObject Itemdragging;
    
    Vector3 startPosition; 
    Transform startParent;
    Transform dragParent;

    public static Transform draggedIcon;
    public Transform hand;
    public bool clonable;

     void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            eventData.pointerDrag = null;
            return;
        }

        if (this.clonable)

            draggedIcon = Instantiate(transform.GetChild(0), this.hand, false);
            else
            {
                draggedIcon = transform.GetChild(0);
                draggedIcon.SetParent(this.hand, false);
                
            }


        
    }
    
    

        public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        this.hand.position = Input.mousePosition;
    }

        public void OnEndDrag(PointerEventData eventData)
    {
        if (draggedIcon == null) return;
        if (this.clonable)
        {
            print("Icono Destruido");
            Destroy(draggedIcon.gameObject);
            return;

        }

        draggedIcon.SetParent(transform, false);
        draggedIcon = null;
    }
}
