using UnityEngine.UI;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    public Text text;
    private float countdown = 1;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        text.text = counter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown <= 0) {
            counter++;
            text.text = counter.ToString();
            countdown = 1;

        }
        countdown -= Time.deltaTime;
    }
}
