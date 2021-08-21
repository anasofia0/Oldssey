using UnityEngine;
using GoogleMobileAds.Api;


public class AdManager : MonoBehaviour
{
    public static AdManager instance;

    public int deaths;

    
    private InterstitialAd interstitial;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544~3347511713";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
            string adUnitId = "unexpected_platform";
#endif
        MobileAds.Initialize(initStatus => { });

        
        RequestInterstitial();
    }

    
    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/1033173712";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
        string adUnitId = "unexpected_platform";
#endif



        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);

        this.interstitial.OnAdClosed += HandleOnAdClosed;

        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }

    void HandleOnAdClosed(object sender, System.EventArgs args)
    {
        RequestInterstitial();
    }
    public void ShowPopUp()
    {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
    }


}