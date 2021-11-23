using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

     private Transform Player1;

     private Vector3 tempPos;
    
     // Start is called before the first frame update
     void Start()
     {
        Player1 = GameObject.FindWithTag("Player").transform;
       
     }

    //  Update is called once per frame
     void Update()
     {
        tempPos = transform.position;
        tempPos = transform.position;
        
        tempPos.x=Player1.position.x;
        tempPos.y=Player1.position.y;
       

         transform.position=tempPos;
        
     }

    

    
} //class
