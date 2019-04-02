using UnityEngine;
using UnityEngine.SceneManagement;


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
            SceneManager.LoadScene("End");
            Debug.Log("test");
            
        }
    }
}
