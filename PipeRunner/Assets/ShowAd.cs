using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CallAd();
    }

    private void CallAd() {
       
        AdContoller.instance.ShowAd();
    }
}
