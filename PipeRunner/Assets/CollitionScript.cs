using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionScript : MonoBehaviour
{

   
    /*
   private void OnCollisionEnter(Collision collision)
  {
       if (collision.collider.gameObject.tag == "Player") {
           Destroy(collision.collider.gameObject);
       }
   }
   */
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")


        {

            
            Destroy(other.gameObject);
        }
    }
}
