using UnityEngine;
using UnityEngine.Monetization;
public class AdContoller : MonoBehaviour
{
    public static AdContoller instance;
    private string store_id = "3101399";
    private string video_ad = "GameOver";

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        Monetization.Initialize(store_id, false);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void ShowAd() {
        if (Monetization.IsReady(video_ad))
        {
            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(video_ad) as ShowAdPlacementContent;

            if (ad != null)
            {

                ad.Show();


            }


        }
    }
}
