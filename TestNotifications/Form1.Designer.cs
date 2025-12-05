namespace TestNotifications
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            NotificationButton = new System.Windows.Forms.Button();
            toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(components);
            ((System.ComponentModel.ISupportInitialize)toastNotificationsManager1).BeginInit();
            SuspendLayout();
            // 
            // NotificationButton
            // 
            NotificationButton.Location = new System.Drawing.Point(233, -17);
            NotificationButton.Margin = new System.Windows.Forms.Padding(4);
            NotificationButton.Name = "NotificationButton";
            NotificationButton.Size = new System.Drawing.Size(246, 174);
            NotificationButton.TabIndex = 0;
            NotificationButton.Text = "Notify with DevExpress";
            NotificationButton.UseVisualStyleBackColor = true;
            NotificationButton.Click += NotificationButton_Click;
            // 
            // toastNotificationsManager1
            // 
            toastNotificationsManager1.ApplicationId = "ac4d629f-6a13-4f28-92c3-36f99d7237fd";
            toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] { new DevExpress.XtraBars.ToastNotifications.ToastNotification("f0d5acc9-b600-4769-9f2a-751f76d28e3b", null, "Header", "Body1", "Body2", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text04) });
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(665, 238);
            Controls.Add(NotificationButton);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)toastNotificationsManager1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NotificationButton;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
    }
}

