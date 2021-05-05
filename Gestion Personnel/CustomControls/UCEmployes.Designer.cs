﻿
namespace Gestion_Personnel.CustomControls
{
    partial class UCEmployes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAjouterEmploye = new System.Windows.Forms.Button();
            this.btnListeEmployes = new System.Windows.Forms.Button();
            this.ucListeEmployes1 = new Gestion_Personnel.CustomControls.UCListeEmployes();
            this.SuspendLayout();
            // 
            // btnAjouterEmploye
            // 
            this.btnAjouterEmploye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnAjouterEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterEmploye.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterEmploye.ForeColor = System.Drawing.Color.White;
            this.btnAjouterEmploye.Image = global::Gestion_Personnel.Properties.Resources.icons8_add_user_male_32px;
            this.btnAjouterEmploye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterEmploye.Location = new System.Drawing.Point(225, 0);
            this.btnAjouterEmploye.Margin = new System.Windows.Forms.Padding(0);
            this.btnAjouterEmploye.Name = "btnAjouterEmploye";
            this.btnAjouterEmploye.Size = new System.Drawing.Size(225, 41);
            this.btnAjouterEmploye.TabIndex = 5;
            this.btnAjouterEmploye.Text = "Ajouter un employé";
            this.btnAjouterEmploye.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouterEmploye.UseVisualStyleBackColor = false;
            // 
            // btnListeEmployes
            // 
            this.btnListeEmployes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnListeEmployes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeEmployes.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeEmployes.ForeColor = System.Drawing.Color.White;
            this.btnListeEmployes.Image = global::Gestion_Personnel.Properties.Resources.icons8_user_groups_32px;
            this.btnListeEmployes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListeEmployes.Location = new System.Drawing.Point(0, 0);
            this.btnListeEmployes.Margin = new System.Windows.Forms.Padding(0);
            this.btnListeEmployes.Name = "btnListeEmployes";
            this.btnListeEmployes.Size = new System.Drawing.Size(225, 41);
            this.btnListeEmployes.TabIndex = 4;
            this.btnListeEmployes.Text = "Liste des employés";
            this.btnListeEmployes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListeEmployes.UseVisualStyleBackColor = false;
            this.btnListeEmployes.Click += new System.EventHandler(this.btnListeEmployes_Click);
            // 
            // ucListeEmployes1
            // 
            this.ucListeEmployes1.Location = new System.Drawing.Point(0, 40);
            this.ucListeEmployes1.Name = "ucListeEmployes1";
            this.ucListeEmployes1.Size = new System.Drawing.Size(932, 396);
            this.ucListeEmployes1.TabIndex = 6;
            // 
            // UCEmployes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.ucListeEmployes1);
            this.Controls.Add(this.btnAjouterEmploye);
            this.Controls.Add(this.btnListeEmployes);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UCEmployes";
            this.Size = new System.Drawing.Size(932, 436);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterEmploye;
        private System.Windows.Forms.Button btnListeEmployes;
        private UCListeEmployes ucListeEmployes1;
    }
}
