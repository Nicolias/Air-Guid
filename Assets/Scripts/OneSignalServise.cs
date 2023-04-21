using OneSignalSDK;
using UnityEngine;

public class OneSignalServise : MonoBehaviour
{
    [SerializeField] private string _appId;

    private void Start()
    {
        OneSignal.Default.Initialize(_appId);

        PromptForPush();
    }

    public async void PromptForPush()
    {
        var result = await OneSignal.Default.PromptForPushNotificationsWithUserResponse();

        if (result == NotificationPermission.Denied)
            Application.Quit();
    }
}
