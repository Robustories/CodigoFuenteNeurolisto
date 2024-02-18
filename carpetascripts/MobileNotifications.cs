using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class MobileNotifications : MonoBehaviour
{
    private string nombrereferencia;
    // Start is called before the first frame update
    void Start()
    {
        GetName();

        AndroidNotificationCenter.CancelAllDisplayedNotifications();

        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.Default,
            Description = "Generic notifications",
        };
            AndroidNotificationCenter.RegisterNotificationChannel(channel);

            var notification = new AndroidNotification();
            notification.Title = "¡Sigue Aprendiendo " + "  "+ nombrereferencia + "  "+ " !";
            notification.Text = "Ven " + "  "+  nombrereferencia + ", entra a NeuroListo a continuar esta aventura educativa, para cada día ser más listo";
            notification.FireTime = System.DateTime.Now.AddHours(24);
            
            var id = AndroidNotificationCenter.SendNotification(notification, "channel_id");

            if(AndroidNotificationCenter.CheckScheduledNotificationStatus(id) == NotificationStatus.Scheduled)
            {
                AndroidNotificationCenter.CancelAllNotifications();
                AndroidNotificationCenter.SendNotification(notification, "channel_id");
            }
        
    }

    void GetName()
    {
        nombrereferencia = Neuro.GetNombre();
    }
}
