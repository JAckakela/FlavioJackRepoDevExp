
using DevExpress.XtraBars.ToastNotifications;

using System;


namespace TestNotifications
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        ToastNotificationsManager manager;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NotificationButton_Click(object sender, EventArgs e)
        {
            /*
            var manager = new ToastNotificationsManager();
            manager.ApplicationId = "TestApplicativo"; // Unique ID

            // Add a notification.
            var note = new ToastNotification();
            note.Template = ToastNotificationTemplate.Text02;
            note.Header = "Funziona";
            note.Body = "DEBUG.";
            note.ID = Guid.NewGuid().ToString(); // A unique identifier
            manager.Notifications.Add(note);

            // Display the notification.
            //manager.ShowNotification(note.ID);
            */


            //toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);
            //toastNotificationsManager1.ShowNotification("61324b1b-2b77-46df-a800-cbe78ec405df");


            WindowsNotificationHelper.ShowToast();
            //toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);

        }
    }
}
