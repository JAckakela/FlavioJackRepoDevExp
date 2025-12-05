using System;
using DevExpress.XtraBars.ToastNotifications;


namespace TestNotifications
{
    public static class WindowsNotificationHelper
    {
        public static void ShowToast()
        {
            ToastNotificationTemplate toastTemplate = ToastNotificationTemplate.ImageAndText04;

            ToastNotificationsManager toastManager = new ToastNotificationsManager();
            toastManager.ApplicationId = "Discord";

            ToastNotification note = new ToastNotification();
            note.Template = ToastNotificationTemplate.Text02;
            note.Header = "Generale";
            note.Body = "Ciao";
            note.ID = Guid.NewGuid().ToString();
            note.Template = toastTemplate;
            note.ImagePath = "C:\\Users\\user18_14_2\\Desktop\\c_sharp\\Notifications\\DevExpress\\FlavioJackRepoDevExp\\TestNotifications\\Images\\discord.png";

            toastManager.Notifications.Add(note);

            toastManager.ShowNotification(note.ID);
        }

        public static void ShowToast(string title, string message, string iconPath, bool playSound)
        {
            ToastNotificationsManager toastManager = new ToastNotificationsManager();
            toastManager.ApplicationId = "TestApplicativo"; // Unique ID

            // Add a notification.
            var note = new ToastNotification();
            note.Template = ToastNotificationTemplate.Text02;
            note.Header = "Funziona";
            note.Body = "DEBUG.";
            note.ID = Guid.NewGuid().ToString(); // A unique identifier
            toastManager.Notifications.Add(note);

            // Display the notification.
            //toastManager.ShowNotification(note.ID);
        }
    }
}
