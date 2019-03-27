using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainRotationController : MonoBehaviour
{
    public float speed;
    

        private void Update()
    {
        if (Input.GetMouseButton(0)) {
            Rotate();
            
        }
    }


    public void Rotate() {
        
        transform.Rotate(new Vector3(0, 1 * speed, 0));
        
    }
            
      
}
