﻿namespace Crud2.VISTA.ClienteVista
{
    partial class AgregarCLiente
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 50);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(116, 291);
            button1.Name = "button1";
            button1.Size = new Size(102, 43);
            button1.TabIndex = 2;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(260, 291);
            button2.Name = "button2";
            button2.Size = new Size(95, 43);
            button2.TabIndex = 3;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 88);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 126);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 166);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefono";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(170, 166);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(185, 23);
            textBox4.TabIndex = 9;
            // 
            // AgregarCLiente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "AgregarCLiente";
            Text = "AgregarCLiente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}