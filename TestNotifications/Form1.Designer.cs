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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(components);
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)toastNotificationsManager1).BeginInit();
            SuspendLayout();
            // 
            // toastNotificationsManager1
            // 
            toastNotificationsManager1.ApplicationId = "5a52ec02-f13e-4658-8f69-046dff162e28";
            toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] { new DevExpress.XtraBars.ToastNotifications.ToastNotification("1a563ef4-a6c7-4eb1-bc1f-05275dc13425", (System.Drawing.Image)resources.GetObject("toastNotificationsManager1.Notifications"), "UNODUETRE", "OKOK", "KKK", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text01) });
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(200, -14);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(211, 141);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(570, 193);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)toastNotificationsManager1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private System.Windows.Forms.Button button1;
    }
}

