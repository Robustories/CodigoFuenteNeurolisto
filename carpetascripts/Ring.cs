using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
 {
     public int size = 0; // The size of the ring. Larger value = bigger ring
     public int poleNumber = 1; // The pole number this ring is on. Either 1, 2 or 3
 
     bool isBeingDragged = false;
 
     void Start ()
     {
         RingPositions.poles[poleNumber].Add(this as Ring);
     }
 
     void OnMouseDown ()
     {
         // Find the minimum ring size on this pole
         int minSize = 99999;
         foreach (Ring r in RingPositions.poles[poleNumber])
         {
             if (r.size < minSize)
             {
                 minSize = r.size;
             }
         }
 
         // Can only move the ring if it is the minimum size ring on the pole
         if (size == minSize)
         {
             isBeingDragged = true;
         }
     }
 
     void OnMouseDrag ()
     {
         if (isBeingDragged)
         {
             // Update position of this object to follow the mouse
         }
     }
 
     void OnMouseUp ()
     {
         // Find the position of the nearest pole
         int nearestPoleNumber = 3; // Either 1, 2 or 3
 
         // Make sure we have dragged it to different pole
         if (poleNumber != nearestPoleNumber)
         {
             // Find the smallest ring on the new pole
             int minSize = 99999;
             foreach (Ring r in RingPositions.poles[nearestPoleNumber])
             {
                 if (r.size < minSize)
                 {
                     minSize = r.size;
                 }
             }
 
             // This ring must be smaller if we can put it on this pole
             if (size < minSize)
             {
                 RingPositions.poles[poleNumber].Remove(this as Ring);
                 RingPositions.poles[nearestPoleNumber].Add(this as Ring);
                 // Change the position to the new pole
             } else
             {
                 // Change position back to the pole it was on
             }
         } else
         {
             // Change position back to the pole it was on
         }
         isBeingDragged = false;
     }
 }

