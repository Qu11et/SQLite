﻿namespace Lab03_2
{
    partial class Server
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
            label2 = new Label();
            button2 = new Button();
            listViewCommnad = new ListView();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(226, 19);
            button1.Name = "button1";
            button1.Size = new Size(106, 38);
            button1.TabIndex = 2;
            button1.Text = "Listen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(28, 28);
            label2.TabIndex = 1;
            label2.Text = "IP";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(226, 63);
            button2.Name = "button2";
            button2.Size = new Size(106, 38);
            button2.TabIndex = 2;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listViewCommnad
            // 
            listViewCommnad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewCommnad.Location = new Point(12, 118);
            listViewCommnad.Name = "listViewCommnad";
            listViewCommnad.Size = new Size(320, 148);
            listViewCommnad.TabIndex = 3;
            listViewCommnad.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(48, 28);
            label1.TabIndex = 4;
            label1.Text = "Port";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(81, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 5;
            textBox1.Text = "127.0.0.1";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(81, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 34);
            textBox2.TabIndex = 5;
            textBox2.Text = "8080";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 278);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listViewCommnad);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "Server";
            Text = "UDP Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label2;
        private Button button2;
        private ListView listViewCommnad;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}