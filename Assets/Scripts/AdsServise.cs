using AppodealStack.Monetization.Api;
using AppodealStack.Monetization.Common;
using System.Collections.Generic;
using UnityEngine;

public class AdsServise : MonoBehaviour, IAppodealInitializationListener, IBannerAdListener, IRewardedVideoAdListener
{
    [SerializeField] private string _appKey;

    [SerializeField] private int _clickCountWhenShowAd;
    private int _clickCounter;

    private void Start()
    {
        int adTypes = AppodealAdType.Interstitial | AppodealAdType.Banner | AppodealAdType.RewardedVideo;
        Appodeal.Initialize(_appKey, adTypes, this);
        Appodeal.SetBannerCallbacks(this);
        Appodeal.SetTabletBanners(false);
        Appodeal.SetSmartBanners(true);
    }

    public void AddButtonsForShowAds(List<ButtonPrefab> buttonsPrefab)
    {
        foreach (var buttonPrefab in buttonsPrefab)
        {
            buttonPrefab.Button.onClick.AddListener(UpdateClickCounter);
        }
    }

    private void UpdateClickCounter()
    {
        _clickCounter++;

        if (_clickCounter % _clickCountWhenShowAd == 0)
        {
            Appodeal.SetRewardedVideoCallbacks(this);

            if (Appodeal.IsLoaded(AppodealAdType.RewardedVideo))
                Appodeal.Show(AppodealShowStyle.RewardedVideo);
        }
    }

    public void OnInitializationFinished(List<string> errors)
    {
        print("Appodeal init");
        if (errors != null)
        {
            foreach (var error in errors)
            {
                print("AppoDeal error: " + error);
            }
        }
    }

    #region RewardVideo

    public void OnRewardedVideoLoaded(bool isPrecache)
    {

    }

    public void OnRewardedVideoFailedToLoad()
    {

    }

    public void OnRewardedVideoShowFailed()
    {

    }

    public void OnRewardedVideoShown()
    {

    }

    public void OnRewardedVideoFinished(double amount, string currency)
    {

    }

    public void OnRewardedVideoClosed(bool finished)
    {
       
    }

    public void OnRewardedVideoExpired()
    {

    }

    public void OnRewardedVideoClicked()
    {

    }

    #endregion

    #region Banner

    public void OnBannerLoaded(int height, bool isPrecache)
    {
        Appodeal.Show(AppodealShowStyle.BannerBottom);
    }

    public void OnBannerFailedToLoad()
    {

    }

    public void OnBannerShown()
    {

    }

    public void OnBannerShowFailed()
    {
        print("banner was failed");
    }

    public void OnBannerClicked()
    {

    }

    public void OnBannerExpired()
    {

    }

    #endregion
}
