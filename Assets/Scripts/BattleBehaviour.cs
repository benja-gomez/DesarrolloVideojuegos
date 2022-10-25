using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D Event){
        if(Event.collider.CompareTag("Player")){
            Debug.Log("Player Collision");
        }
    }
    private void OnCollisionExit2D(Collision2D Event){
        if(Event.collider.CompareTag("Player")){
            Debug.Log("Player No Collision");
        }
    }
    private void OnCollisionStay2D(Collision2D Event){
        if(Event.collider.CompareTag("Player")){
            Debug.Log("Player Stay");
        }
    }
}
