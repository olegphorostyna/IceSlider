using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount=1f; //serailize this variable. This attribute will make them IDE editable;
    Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();//return the component of type T if gameObject has one 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)){ //if user press LeftArrow
            rb2d.AddTorque(torqueAmount);
        }
        else if(Input.GetKey(KeyCode.RightArrow)){ //if user press LeftArrow
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
