using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
 
public class BannerAd : MonoBehaviour
{
    // For the purpose of this example, these buttons are for functionality testing:

 
    [SerializeField] BannerPosition _bannerPosition = BannerPosition.BOTTOM_CENTER;
 
    [SerializeField] string _androidAdUnitId = "Banner_Android";
    string _adUnitId = null; // This will remain null for unsupported platforms.
 
    void Start()
    {
        // Get the Ad Unit ID for the current platform:
#if UNITY_IOS
        _adUnitId = _iOSAdUnitId;
#elif UNITY_ANDROID
        _adUnitId = _androidAdUnitId;
#endif

        // Disable the button until an ad is ready to show:
 
        // Set the banner position:
        Advertisement.Banner.SetPosition(_bannerPosition);
 
        // Configure the Load Banner button to call the LoadBanner() method when clicked:
        Advertisement.Banner.Load(_adUnitId);
        Advertisement.Banner.Show(_adUnitId);
    }
 
    // Implement a method to call when the Load Banner button is clicked:
 
    // Implement code to execute when the loadCallback event triggers:
    void OnBannerLoaded()
    {
        Debug.Log("Banner loaded");     
    }
 
    // Implement code to execute when the load errorCallback event triggers:
    void OnBannerError(string message)
    {
        Debug.Log($"Banner Error: {message}");
        // Optionally execute additional code, such as attempting to load another ad.
    }
 
    // Implement a method to call when the Show Banner button is clicked:
 
    // Implement a method to call when the Hide Banner button is clicked:
    void HideBannerAd()
    {
        // Hide the banner:
        Advertisement.Banner.Hide();
    }
}