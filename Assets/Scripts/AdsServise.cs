//using AppodealStack.Monetization.Api;
//using AppodealStack.Monetization.Common;
using System.Collections.Generic;
using UnityEngine;

public class AdsServise : MonoBehaviour
{
    [SerializeField] private int _clickCountWhenShowAd;
    private int _clickCounter;

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

        if (_clickCounter == _clickCountWhenShowAd)
        {
            Debug.Log("ShowAds");
        }
    }
}
