﻿namespace Gestione_campionato
{
    partial class FormAggiorna
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
            this.nu_part = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_casa = new System.Windows.Forms.Button();
            this.btn_ospiti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nu_part)).BeginInit();
            this.SuspendLayout();
            // 
            // nu_part
            // 
            this.nu_part.Location = new System.Drawing.Point(90, 77);
            this.nu_part.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nu_part.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nu_part.Name = "nu_part";
            this.nu_part.Size = new System.Drawing.Size(166, 20);
            this.nu_part.TabIndex = 6;
            this.nu_part.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nu_part.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(31, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Partita:";
            // 
            // btn_casa
            // 
            this.btn_casa.Location = new System.Drawing.Point(102, 123);
            this.btn_casa.Name = "btn_casa";
            this.btn_casa.Size = new System.Drawing.Size(73, 56);
            this.btn_casa.TabIndex = 10;
            this.btn_casa.Text = "GOAL CASA";
            this.btn_casa.UseVisualStyleBackColor = true;
            this.btn_casa.Click += new System.EventHandler(this.btn_casa_Click);
            // 
            // btn_ospiti
            // 
            this.btn_ospiti.Location = new System.Drawing.Point(181, 123);
            this.btn_ospiti.Name = "btn_ospiti";
            this.btn_ospiti.Size = new System.Drawing.Size(75, 56);
            this.btn_ospiti.TabIndex = 11;
            this.btn_ospiti.Text = "GOAL OSPITI";
            this.btn_ospiti.UseVisualStyleBackColor = true;
            this.btn_ospiti.Click += new System.EventHandler(this.btn_ospiti_Click);
            // 
            // FormAggiorna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_ospiti);
            this.Controls.Add(this.btn_casa);
            this.Controls.Add(this.nu_part);
            this.Controls.Add(this.label1);
            this.Name = "FormAggiorna";
            this.Text = "FormAggiorna";
            ((System.ComponentModel.ISupportInitialize)(this.nu_part)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nu_part;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_casa;
        private System.Windows.Forms.Button btn_ospiti;
    }
}