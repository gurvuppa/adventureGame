﻿
namespace adventureGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.option1Button = new System.Windows.Forms.PictureBox();
            this.option2Button = new System.Windows.Forms.PictureBox();
            this.option3Button = new System.Windows.Forms.PictureBox();
            this.option3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option1Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option2Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option3Button)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputLabel.Location = new System.Drawing.Point(12, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(342, 89);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "outputLabel";
            // 
            // option1Label
            // 
            this.option1Label.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.Color.White;
            this.option1Label.Location = new System.Drawing.Point(71, 342);
            this.option1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(225, 36);
            this.option1Label.TabIndex = 10;
            this.option1Label.Text = "option1Label";
            this.option1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option2Label
            // 
            this.option2Label.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.White;
            this.option2Label.Location = new System.Drawing.Point(71, 378);
            this.option2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(225, 32);
            this.option2Label.TabIndex = 11;
            this.option2Label.Text = "option2Label";
            this.option2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox.Image = global::adventureGame.Properties.Resources.kneelingKnight;
            this.imageBox.Location = new System.Drawing.Point(11, 100);
            this.imageBox.Margin = new System.Windows.Forms.Padding(2);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(344, 203);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 15;
            this.imageBox.TabStop = false;
            // 
            // option1Button
            // 
            this.option1Button.Image = global::adventureGame.Properties.Resources.skyrimQuestMarker_LI;
            this.option1Button.Location = new System.Drawing.Point(15, 342);
            this.option1Button.Margin = new System.Windows.Forms.Padding(2);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(39, 32);
            this.option1Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.option1Button.TabIndex = 14;
            this.option1Button.TabStop = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.Image = global::adventureGame.Properties.Resources.skyrimQuestMarker_LI;
            this.option2Button.Location = new System.Drawing.Point(16, 378);
            this.option2Button.Margin = new System.Windows.Forms.Padding(2);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(38, 37);
            this.option2Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.option2Button.TabIndex = 13;
            this.option2Button.TabStop = false;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.Image = global::adventureGame.Properties.Resources.skyrimQuestMarker_LI;
            this.option3Button.Location = new System.Drawing.Point(15, 419);
            this.option3Button.Margin = new System.Windows.Forms.Padding(2);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(38, 37);
            this.option3Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.option3Button.TabIndex = 16;
            this.option3Button.TabStop = false;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // option3Label
            // 
            this.option3Label.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.ForeColor = System.Drawing.Color.White;
            this.option3Label.Location = new System.Drawing.Point(71, 419);
            this.option3Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(225, 32);
            this.option3Label.TabIndex = 17;
            this.option3Label.Text = "option3Label";
            this.option3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(366, 462);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "The Search ";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option1Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option2Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option3Button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.PictureBox option2Button;
        private System.Windows.Forms.PictureBox option1Button;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.PictureBox option3Button;
        private System.Windows.Forms.Label option3Label;
    }
}

