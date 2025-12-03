
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
            manager.ShowNotification(note.ID);


            toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);
            toastNotificationsManager1.ShowNotification("3b7fcd8b-a1e0-4ff5-83ce-023cdf6be24b");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
