using System;
using System.Drawing;
using System.Windows.Forms;

namespace OffOnDesktopButtonWF
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(100, 230);
            this.Text = "Form1";

            EnableButton = new Button();
            EnableButton.Size = new System.Drawing.Size(80, 100);
            EnableButton.Text = "ENABLE";
            EnableButton.Location = new System.Drawing.Point(20, 120);
            EnableButton.MouseDown += Button_Click;
            EnableButton.MouseUp += Button_Click1;

            EnableBox = new TextBox();
            EnableBox.Location = new System.Drawing.Point(20, 10);
            EnableBox.Size = new System.Drawing.Size(80, 100);
            EnableBox.Enabled = false;
            EnableBox.Multiline = true;
            EnableBox.BackColor = Color.GreenYellow;


            this.Controls.Add(EnableButton);
            this.Controls.Add(EnableBox);

        }


        Button EnableButton;
        TextBox EnableBox;
        
        #endregion
    }
}

