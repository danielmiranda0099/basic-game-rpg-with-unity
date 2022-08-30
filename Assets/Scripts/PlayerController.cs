using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 4f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0.5f){
            this.transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0));
        }
        if(Mathf.Abs(Input.GetAxisRaw("Vertical")) > 0.5f){
            this.transform.Translate(new Vector3(0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0));
        }
    }
}
