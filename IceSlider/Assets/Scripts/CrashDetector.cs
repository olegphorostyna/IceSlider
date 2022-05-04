using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) {
    if(other.tag == "Ground") // tag is set to game object with IDE UI contorl
     Debug.Log("You crashed!");
}
}
