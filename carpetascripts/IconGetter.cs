using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IconGetter : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData) 
    {
        Transform droppedIcon;
        droppedIcon = IconDragger.draggedIcon;

        if (this.gameObject.CompareTag(droppedIcon.tag))
        {
            if(transform.childCount > 0)
            IconDragger.draggedIcon = transform.GetChild(0);
            else
            IconDragger.draggedIcon = null;

            droppedIcon.SetParent(transform, false);

        }
        else
        {
            print ("Icono destruido...");
            Destroy (droppedIcon.gameObject);
            IconDragger.draggedIcon = null;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
