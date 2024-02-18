using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{
    public GameObject item;


    void Start()
    {
        
    }

      public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragHandler.Itemdragging;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
        }
        
    }
}
