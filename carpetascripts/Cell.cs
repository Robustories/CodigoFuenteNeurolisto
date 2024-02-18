using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LinePaint2
{
public class Cell : MonoBehaviour
{
    [SerializeField] private SpriteRenderer cellCenterPaint;
    [HideInInspector]public Vector2Int coords;

    public SpriteRenderer CellCenterPaint { get {return cellCenterPaint; }}
    }
}
