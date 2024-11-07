namespace View
{
    partial class ToastForm
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
            toastBorder = new Panel();
            pictureBoxIcon = new PictureBox();
            labelType = new Label();
            labelMessage = new Label();
            autoClose = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // toastBorder
            // 
            toastBorder.BackColor = Color.LimeGreen;
            toastBorder.Location = new Point(-4, -3);
            toastBorder.Name = "toastBorder";
            toastBorder.Size = new Size(12, 64);
            toastBorder.TabIndex = 0;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Image = Properties.Resources._22_226960_download_success_png_image_green_like_button_png;
            pictureBoxIcon.Location = new Point(20, 15);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(25, 25);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIcon.TabIndex = 1;
            pictureBoxIcon.TabStop = false;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelType.Location = new Point(57, 9);
            labelType.Name = "labelType";
            labelType.Size = new Size(37, 17);
            labelType.TabIndex = 2;
            labelType.Text = "Type";
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMessage.Location = new Point(57, 35);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(83, 15);
            labelMessage.TabIndex = 3;
            labelMessage.Text = "Toast Message";
            // 
            // autoClose
            // 
            autoClose.Enabled = true;
            autoClose.Interval = 10;
            // 
            // ToastForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 59);
            Controls.Add(labelMessage);
            Controls.Add(labelType);
            Controls.Add(pictureBoxIcon);
            Controls.Add(toastBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToastForm";
            Text = "ToastForm";
            Load += ToastForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel toastBorder;
        private PictureBox pictureBoxIcon;
        private Label labelType;
        private Label labelMessage;
        private System.Windows.Forms.Timer autoClose;
    }
}