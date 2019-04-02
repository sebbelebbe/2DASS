using UnityEngine;


public class RemoveObstacle : MonoBehaviour
{



    private void OnTriggerExit(Collider other)
    {

        Destroy(other.gameObject);
        
    }

   


}
