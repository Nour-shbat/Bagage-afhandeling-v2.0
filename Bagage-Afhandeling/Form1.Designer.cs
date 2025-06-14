namespace Bagage_Afhandeling
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
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEnterID = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.buttonSeeStatus = new System.Windows.Forms.Button();
            this.buttonCheckin = new System.Windows.Forms.Button();
            this.buttonStatusChange = new System.Windows.Forms.Button();
            this.buttonChangeCorrectPlane = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(88, 94);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(96, 25);
            this.buttonConfirm.TabIndex = 0;
            this.buttonConfirm.TabStop = false;
            this.buttonConfirm.Text = "Bevestigen";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geef ID en wachtwoord op:";
            // 
            // textBoxEnterID
            // 
            this.textBoxEnterID.Location = new System.Drawing.Point(43, 66);
            this.textBoxEnterID.Name = "textBoxEnterID";
            this.textBoxEnterID.Size = new System.Drawing.Size(87, 22);
            this.textBoxEnterID.TabIndex = 2;
            this.textBoxEnterID.TextChanged += new System.EventHandler(this.textBoxEnterID_TextChanged);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(43, 186);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(109, 22);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(158, 186);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(109, 22);
            this.textBoxLastName.TabIndex = 4;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(43, 242);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(109, 22);
            this.textBoxRole.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Voornaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Achternaam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Functie";
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.Location = new System.Drawing.Point(136, 66);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.PasswordChar = '*';
            this.textBoxPassWord.Size = new System.Drawing.Size(87, 22);
            this.textBoxPassWord.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Werknemers ID";
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Location = new System.Drawing.Point(158, 242);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(109, 22);
            this.textBoxEmployeeID.TabIndex = 11;
            // 
            // buttonSeeStatus
            // 
            this.buttonSeeStatus.Location = new System.Drawing.Point(351, 36);
            this.buttonSeeStatus.Name = "buttonSeeStatus";
            this.buttonSeeStatus.Size = new System.Drawing.Size(116, 52);
            this.buttonSeeStatus.TabIndex = 12;
            this.buttonSeeStatus.Text = "Status baggage inzien";
            this.buttonSeeStatus.UseVisualStyleBackColor = true;
            this.buttonSeeStatus.Visible = false;
            this.buttonSeeStatus.Click += new System.EventHandler(this.buttonSeeStatus_Click);
            // 
            // buttonCheckin
            // 
            this.buttonCheckin.Location = new System.Drawing.Point(351, 96);
            this.buttonCheckin.Name = "buttonCheckin";
            this.buttonCheckin.Size = new System.Drawing.Size(116, 52);
            this.buttonCheckin.TabIndex = 13;
            this.buttonCheckin.Text = "Handbaggage inchecken";
            this.buttonCheckin.UseVisualStyleBackColor = true;
            this.buttonCheckin.Visible = false;
            this.buttonCheckin.Click += new System.EventHandler(this.buttonCheckin_Click);
            // 
            // buttonStatusChange
            // 
            this.buttonStatusChange.Location = new System.Drawing.Point(351, 154);
            this.buttonStatusChange.Name = "buttonStatusChange";
            this.buttonStatusChange.Size = new System.Drawing.Size(116, 52);
            this.buttonStatusChange.TabIndex = 14;
            this.buttonStatusChange.Text = "Status baggage aanpassen";
            this.buttonStatusChange.UseVisualStyleBackColor = true;
            this.buttonStatusChange.Visible = false;
            this.buttonStatusChange.Click += new System.EventHandler(this.buttonStatusChange_Click);
            // 
            // buttonChangeCorrectPlane
            // 
            this.buttonChangeCorrectPlane.Location = new System.Drawing.Point(351, 212);
            this.buttonChangeCorrectPlane.Name = "buttonChangeCorrectPlane";
            this.buttonChangeCorrectPlane.Size = new System.Drawing.Size(116, 61);
            this.buttonChangeCorrectPlane.TabIndex = 15;
            this.buttonChangeCorrectPlane.Text = "Baggage naar juiste vliegtuig corrigeren?";
            this.buttonChangeCorrectPlane.UseVisualStyleBackColor = true;
            this.buttonChangeCorrectPlane.Visible = false;
            this.buttonChangeCorrectPlane.Click += new System.EventHandler(this.buttonChangeCorrectPlane_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 407);
            this.Controls.Add(this.buttonChangeCorrectPlane);
            this.Controls.Add(this.buttonStatusChange);
            this.Controls.Add(this.buttonCheckin);
            this.Controls.Add(this.buttonSeeStatus);
            this.Controls.Add(this.textBoxEmployeeID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPassWord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxEnterID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfirm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEnterID;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.Button buttonSeeStatus;
        private System.Windows.Forms.Button buttonCheckin;
        private System.Windows.Forms.Button buttonStatusChange;
        private System.Windows.Forms.Button buttonChangeCorrectPlane;
    }
}

