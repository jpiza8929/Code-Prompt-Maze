using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
   //RigidBody//

 



   
   //x movement//
    private float movespeed = 0.01f;
    private float backwrdsspeed = 0.01f;

   //z movement//
    private float zleft = 0.011f;
    private float zright = 0.01f;
   
   
  

  
   
   
   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       

    Vector3 newPos = transform.position;
    
        //x movement//
        if(Input.GetKey(KeyCode.S)){

        newPos.x = newPos.x + movespeed;
    
        }

    else{
        if(Input.GetKey(KeyCode.W)){

        newPos.x = newPos.x - backwrdsspeed;
    
        }

    }
    
        //Z Movement//
     if(Input.GetKey(KeyCode.D)){
    
        newPos.z = newPos.z + zright;
    
    }

    if(Input.GetKey(KeyCode.A)){
    
        newPos.z = newPos.z - zleft;
    }

    

      transform.position = newPos;

      
    }
      
      
      
}
    
     

   


    
   
  
    
  
    

     
    

   
   
    
  


    

