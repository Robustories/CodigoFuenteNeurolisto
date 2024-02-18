using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unir : MonoBehaviour
{
    public GameObject animacionPerro;
    public string Tag;
    public float closeVDidst = 0.05f;
    private Vector3 positionsss;
    private Vector3 offeset;
    float dist;
    GameObject GO;
    void Start()
    {
        GO = GameObject.FindGameObjectWithTag(Tag);
    }
    void OnMouseDown()
    {
        positionsss = Camera.main.WorldToScreenPoint(transform.position);
        offeset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, positionsss.z));
    }
    void OnMouseDrag()
    {
        Vector3 curseScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, positionsss.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curseScreenPoint) + offeset;
        transform.position = curPosition;
        Vector3 partnerPos = Camera.main.WorldToViewportPoint(GO.transform.position);
        Vector3 myPos = Camera.main.WorldToViewportPoint(transform.position);
        dist = Vector2.Distance(partnerPos, myPos);
    }
    void OnMouseUp()
    {
        Cursor.visible = true;
        if (dist < closeVDidst)
        {
            transform.SetParent(GO.transform);
            animacionPerro.gameObject.SetActive(true);
        }
    }
}
