using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidad=6.0f;
    public float salto=10.0f;
    Rigidbody2D rb2d;
    private bool saltando=false;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * velocidad * Time.deltaTime,0, 0);
        if(Input.GetKey(KeyCode.Space) && !saltando){
   
            rb2d.AddForce(Vector2.up * salto);
           
        }
        Debug.Log(saltando);
    }    
}