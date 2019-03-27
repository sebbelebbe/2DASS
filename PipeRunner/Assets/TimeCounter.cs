using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    private Text text;
    private float DefaultTime = 1;
    private float time;
    private int sec = 0;

    private void Start()
    {
    time = DefaultTime;
        text.text = sec.ToString();

    }


// Update is called once per frame
void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0) {
            sec++;
            text.text = sec.ToString();
        }

        
        
    }
}
