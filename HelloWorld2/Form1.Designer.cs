﻿namespace HelloWorld2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.changeText = new System.Windows.Forms.Button();
            this.changeColor = new System.Windows.Forms.Button();
            this.wow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 132);
            this.label1.TabIndex = 0;
            this.label1.Text = "W0W";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeText
            // 
            this.changeText.BackColor = System.Drawing.Color.Transparent;
            this.changeText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.changeText.Location = new System.Drawing.Point(64, 271);
            this.changeText.Name = "changeText";
            this.changeText.Size = new System.Drawing.Size(93, 36);
            this.changeText.TabIndex = 1;
            this.changeText.Text = "Update Time";
            this.changeText.UseVisualStyleBackColor = false;
            this.changeText.Click += new System.EventHandler(this.button1_Click);
            // 
            // changeColor
            // 
            this.changeColor.Location = new System.Drawing.Point(267, 271);
            this.changeColor.Name = "changeColor";
            this.changeColor.Size = new System.Drawing.Size(93, 36);
            this.changeColor.TabIndex = 2;
            this.changeColor.Text = "Farbe ändern";
            this.changeColor.UseVisualStyleBackColor = true;
            this.changeColor.Click += new System.EventHandler(this.changeColor_Click);
            // 
            // wow
            // 
            this.wow.BackColor = System.Drawing.Color.Transparent;
            this.wow.Location = new System.Drawing.Point(168, 271);
            this.wow.Name = "wow";
            this.wow.Size = new System.Drawing.Size(93, 36);
            this.wow.TabIndex = 3;
            this.wow.Text = "WOW";
            this.wow.UseVisualStyleBackColor = false;
            this.wow.Click += new System.EventHandler(this.wow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(425, 319);
            this.Controls.Add(this.wow);
            this.Controls.Add(this.changeColor);
            this.Controls.Add(this.changeText);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DogeClock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button changeText;
        private System.Windows.Forms.Button changeColor;
        private System.Windows.Forms.Button wow;
        private System.Windows.Forms.Label label1;
    }
}
