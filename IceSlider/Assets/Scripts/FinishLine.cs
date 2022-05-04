using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
private void OnTriggerEnter2D(Collider2D other) {
    if(other.tag == "Player") // tag is set to game object with IDE UI contorl
     Debug.Log("You finished!");
}
}
