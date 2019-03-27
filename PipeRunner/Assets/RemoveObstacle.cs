using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RemoveObstacle : MonoBehaviour
{



    private void OnTriggerExit(Collider other)
    {

        Destroy(other.gameObject);
        Debug.Log("etsetstetafewfew");
    }

   


}
