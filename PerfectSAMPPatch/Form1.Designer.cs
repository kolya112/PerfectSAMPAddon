
namespace PerfectSAMPPatch
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.getSAMPscreens = new System.Windows.Forms.Button();
            this.getgameclient = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to SAMP 0.3.7 starter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Powered by Николай Юрченко\r\naka Sharp_Macalister,\r\nNikolay_Aweiro\r\nNikolay_Mason";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(13, 77);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(267, 88);
            this.start.TabIndex = 2;
            this.start.Text = "Играть";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // getSAMPscreens
            // 
            this.getSAMPscreens.Location = new System.Drawing.Point(13, 172);
            this.getSAMPscreens.Name = "getSAMPscreens";
            this.getSAMPscreens.Size = new System.Drawing.Size(267, 48);
            this.getSAMPscreens.TabIndex = 3;
            this.getSAMPscreens.Text = "Открыть папку с скриншотами SAMP";
            this.getSAMPscreens.UseVisualStyleBackColor = true;
            this.getSAMPscreens.Click += new System.EventHandler(this.getSAMPscreens_Click);
            // 
            // getgameclient
            // 
            this.getgameclient.Location = new System.Drawing.Point(13, 227);
            this.getgameclient.Name = "getgameclient";
            this.getgameclient.Size = new System.Drawing.Size(267, 45);
            this.getgameclient.TabIndex = 4;
            this.getgameclient.Text = "Открыть папку с клиентом игры";
            this.getgameclient.UseVisualStyleBackColor = true;
            this.getgameclient.Click += new System.EventHandler(this.getgameclient_Click);
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(13, 279);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(267, 53);
            this.settings.TabIndex = 5;
            this.settings.Text = "Настройки";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.getgameclient);
            this.Controls.Add(this.getSAMPscreens);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SAMPLauncher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button getSAMPscreens;
        private System.Windows.Forms.Button getgameclient;
        private System.Windows.Forms.Button settings;
    }
}

