﻿namespace Bagage_Afhandeling
{
    partial class PassengerForm
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
            this.buttonCheckStatus = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.StatusList = new System.Windows.Forms.ListBox();
            this.BaggageList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCheckStatus
            // 
            this.buttonCheckStatus.Location = new System.Drawing.Point(33, 359);
            this.buttonCheckStatus.Name = "buttonCheckStatus";
            this.buttonCheckStatus.Size = new System.Drawing.Size(208, 38);
            this.buttonCheckStatus.TabIndex = 4;
            this.buttonCheckStatus.Text = "Check your baggage status";
            this.buttonCheckStatus.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Rebort lost baggage";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "click on Baggage to show status histury";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(537, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 38);
            this.button3.TabIndex = 8;
            this.button3.Text = "Bag Pickup Confirmation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // StatusList
            // 
            this.StatusList.FormattingEnabled = true;
            this.StatusList.ItemHeight = 16;
            this.StatusList.Location = new System.Drawing.Point(259, 63);
            this.StatusList.Name = "StatusList";
            this.StatusList.Size = new System.Drawing.Size(186, 228);
            this.StatusList.TabIndex = 9;
            this.StatusList.SelectedIndexChanged += new System.EventHandler(this.StatusList_SelectedIndexChanged);
            // 
            // BaggageList
            // 
            this.BaggageList.FormattingEnabled = true;
            this.BaggageList.ItemHeight = 16;
            this.BaggageList.Location = new System.Drawing.Point(43, 63);
            this.BaggageList.Name = "BaggageList";
            this.BaggageList.Size = new System.Drawing.Size(178, 228);
            this.BaggageList.TabIndex = 10;
            this.BaggageList.SelectedIndexChanged += new System.EventHandler(this.BaggageList_SelectedIndexChanged);
            // 
            // PassengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 458);
            this.Controls.Add(this.BaggageList);
            this.Controls.Add(this.StatusList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonCheckStatus);
            this.Name = "PassengerForm";
            this.Text = "PassengerForm";
            this.Load += new System.EventHandler(this.PassengerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCheckStatus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox StatusList;
        private System.Windows.Forms.ListBox BaggageList;
    }
}