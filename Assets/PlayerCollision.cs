using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

   public PlayerMoviment playerMoviment;
   void OnCollisionEnter (Collision collisionInfo){
      

       if(collisionInfo.collider.tag=="Obstacle"){
           Debug.Log ("We hit something."+collisionInfo.collider.name);
           playerMoviment.enabled = false;
       }
   }
}
