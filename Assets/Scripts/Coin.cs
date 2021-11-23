using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {

        Player1.coincollect += 1;

        //after collision to destroy the object 
        Destroy(gameObject);
        
    }
}  //class
