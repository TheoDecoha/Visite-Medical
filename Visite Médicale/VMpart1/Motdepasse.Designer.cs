namespace VMpart1
{
    partial class Motdepasse
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
            this.tbidentifiant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbmdp = new System.Windows.Forms.TextBox();
            this.btok = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbidentifiant
            // 
            this.tbidentifiant.Location = new System.Drawing.Point(100, 58);
            this.tbidentifiant.Name = "tbidentifiant";
            this.tbidentifiant.Size = new System.Drawing.Size(153, 20);
            this.tbidentifiant.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identifiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe";
            // 
            // tbmdp
            // 
            this.tbmdp.Location = new System.Drawing.Point(100, 108);
            this.tbmdp.Name = "tbmdp";
            this.tbmdp.PasswordChar = '*';
            this.tbmdp.Size = new System.Drawing.Size(153, 20);
            this.tbmdp.TabIndex = 3;
            this.tbmdp.Text = "azerty";
            // 
            // btok
            // 
            this.btok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btok.Location = new System.Drawing.Point(43, 167);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(68, 24);
            this.btok.TabIndex = 4;
            this.btok.Text = "Ok";
            this.btok.UseVisualStyleBackColor = true;
            // 
            // btcancel
            // 
            this.btcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btcancel.Location = new System.Drawing.Point(141, 168);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(84, 23);
            this.btcancel.TabIndex = 5;
            this.btcancel.Text = "Cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            // 
            // Motdepasse
            // 
            this.AcceptButton = this.btok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btcancel;
            this.ClientSize = new System.Drawing.Size(428, 398);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.tbmdp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbidentifiant);
            this.Name = "Motdepasse";
            this.Text = "Motdepasse";
            this.Load += new System.EventHandler(this.Motdepasse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbidentifiant;

        public System.Windows.Forms.TextBox gsTbidentifiant
        {
            get { return tbidentifiant; }
            set { tbidentifiant = value; }
        }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbmdp;

        public System.Windows.Forms.TextBox gsTbmdp
        {
            get { return tbmdp; }
            set { tbmdp = value; }
        }
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.Button btcancel;
    }
}