﻿namespace Prototip_Interfata
{
    partial class RentedBooks
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
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Location = new Point(12, 366);
            button1.Name = "button1";
            button1.Size = new Size(757, 56);
            button1.TabIndex = 0;
            button1.Text = "Imprumuta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(9, 14);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(760, 324);
            listBox1.TabIndex = 1;
            // 
            // RentedBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "RentedBooks";
            Text = "RentedBooks";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
    }
}