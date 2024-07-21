using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Get out of the way!");
   }

   void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("You just hit a trigger");
   }


}
