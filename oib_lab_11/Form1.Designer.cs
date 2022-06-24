
namespace oib_lab_11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Off = new System.Windows.Forms.Button();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.userSignature = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Off
            // 
            this.Off.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Off.BackColor = System.Drawing.Color.Transparent;
            this.Off.BackgroundImage = global::oib_lab_11.Properties.Resources.shutdown_image;
            this.Off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Off.FlatAppearance.BorderSize = 0;
            this.Off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Off.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Off.Location = new System.Drawing.Point(1218, 12);
            this.Off.Name = "Off";
            this.Off.Size = new System.Drawing.Size(50, 50);
            this.Off.TabIndex = 4;
            this.Off.UseVisualStyleBackColor = false;
            this.Off.Click += new System.EventHandler(this.Off_Click);
            // 
            // userIcon
            // 
            this.userIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userIcon.BackColor = System.Drawing.Color.Transparent;
            this.userIcon.BackgroundImage = global::oib_lab_11.Properties.Resources.image;
            this.userIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userIcon.Location = new System.Drawing.Point(565, 180);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(150, 150);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userIcon.TabIndex = 6;
            this.userIcon.TabStop = false;
            // 
            // userSignature
            // 
            this.userSignature.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userSignature.AutoSize = true;
            this.userSignature.BackColor = System.Drawing.Color.Transparent;
            this.userSignature.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userSignature.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.userSignature.Location = new System.Drawing.Point(484, 340);
            this.userSignature.Name = "userSignature";
            this.userSignature.Size = new System.Drawing.Size(312, 65);
            this.userSignature.TabIndex = 7;
            this.userSignature.Text = "Another user";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(593, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // loginField
            // 
            this.loginField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginField.BackColor = System.Drawing.Color.White;
            this.loginField.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginField.Location = new System.Drawing.Point(430, 440);
            this.loginField.MaxLength = 20;
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(420, 40);
            this.loginField.TabIndex = 9;
            this.loginField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(0, 620);
            this.label3.MinimumSize = new System.Drawing.Size(1280, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1280, 25);
            this.label3.TabIndex = 15;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // show
            // 
            this.show.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.show.BackColor = System.Drawing.Color.Transparent;
            this.show.BackgroundImage = global::oib_lab_11.Properties.Resources.show_image;
            this.show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show.FlatAppearance.BorderSize = 0;
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show.Location = new System.Drawing.Point(395, 540);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(45, 45);
            this.show.TabIndex = 14;
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(574, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // input
            // 
            this.input.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.input.BackColor = System.Drawing.Color.Transparent;
            this.input.BackgroundImage = global::oib_lab_11.Properties.Resources.enter_image;
            this.input.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.input.FlatAppearance.BorderSize = 0;
            this.input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input.Location = new System.Drawing.Point(835, 540);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(45, 45);
            this.input.TabIndex = 12;
            this.input.UseVisualStyleBackColor = false;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // passField
            // 
            this.passField.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.passField.BackColor = System.Drawing.Color.White;
            this.passField.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passField.Location = new System.Drawing.Point(450, 540);
            this.passField.MaxLength = 127;
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(380, 45);
            this.passField.TabIndex = 11;
            this.passField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passField.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::oib_lab_11.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 900);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.show);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userSignature);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.Off);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Off;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.Label userSignature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.TextBox passField;
    }
}

