
namespace Gestion_Personnel.CustomControls
{
    partial class UCListeEmployes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtRecherchePrenom = new System.Windows.Forms.TextBox();
            this.txtRechercheNom = new System.Windows.Forms.TextBox();
            this.txtRechercheNum = new System.Windows.Forms.TextBox();
            this.lblText_ParPrenom = new System.Windows.Forms.Label();
            this.lblText_ParNom = new System.Windows.Forms.Label();
            this.lblText_ParNumero = new System.Windows.Forms.Label();
            this.lblText_Recherche = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRecherchePrenom
            // 
            this.txtRecherchePrenom.BackColor = System.Drawing.Color.DarkGray;
            this.txtRecherchePrenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecherchePrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtRecherchePrenom.Location = new System.Drawing.Point(285, 45);
            this.txtRecherchePrenom.Multiline = true;
            this.txtRecherchePrenom.Name = "txtRecherchePrenom";
            this.txtRecherchePrenom.Size = new System.Drawing.Size(124, 20);
            this.txtRecherchePrenom.TabIndex = 15;
            // 
            // txtRechercheNom
            // 
            this.txtRechercheNom.BackColor = System.Drawing.Color.DarkGray;
            this.txtRechercheNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRechercheNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtRechercheNom.Location = new System.Drawing.Point(145, 45);
            this.txtRechercheNom.Multiline = true;
            this.txtRechercheNom.Name = "txtRechercheNom";
            this.txtRechercheNom.Size = new System.Drawing.Size(124, 20);
            this.txtRechercheNom.TabIndex = 14;
            // 
            // txtRechercheNum
            // 
            this.txtRechercheNum.BackColor = System.Drawing.Color.DarkGray;
            this.txtRechercheNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRechercheNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtRechercheNum.Location = new System.Drawing.Point(8, 45);
            this.txtRechercheNum.Multiline = true;
            this.txtRechercheNum.Name = "txtRechercheNum";
            this.txtRechercheNum.Size = new System.Drawing.Size(124, 20);
            this.txtRechercheNum.TabIndex = 13;
            // 
            // lblText_ParPrenom
            // 
            this.lblText_ParPrenom.AutoSize = true;
            this.lblText_ParPrenom.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_ParPrenom.Location = new System.Drawing.Point(282, 25);
            this.lblText_ParPrenom.Name = "lblText_ParPrenom";
            this.lblText_ParPrenom.Size = new System.Drawing.Size(84, 17);
            this.lblText_ParPrenom.TabIndex = 12;
            this.lblText_ParPrenom.Text = "Par prénom :";
            // 
            // lblText_ParNom
            // 
            this.lblText_ParNom.AutoSize = true;
            this.lblText_ParNom.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_ParNom.Location = new System.Drawing.Point(142, 25);
            this.lblText_ParNom.Name = "lblText_ParNom";
            this.lblText_ParNom.Size = new System.Drawing.Size(64, 17);
            this.lblText_ParNom.TabIndex = 11;
            this.lblText_ParNom.Text = "Par nom :";
            // 
            // lblText_ParNumero
            // 
            this.lblText_ParNumero.AutoSize = true;
            this.lblText_ParNumero.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_ParNumero.Location = new System.Drawing.Point(5, 25);
            this.lblText_ParNumero.Name = "lblText_ParNumero";
            this.lblText_ParNumero.Size = new System.Drawing.Size(83, 17);
            this.lblText_ParNumero.TabIndex = 10;
            this.lblText_ParNumero.Text = "Par numéro :";
            // 
            // lblText_Recherche
            // 
            this.lblText_Recherche.AutoSize = true;
            this.lblText_Recherche.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Recherche.Location = new System.Drawing.Point(3, 0);
            this.lblText_Recherche.Name = "lblText_Recherche";
            this.lblText_Recherche.Size = new System.Drawing.Size(98, 25);
            this.lblText_Recherche.TabIndex = 9;
            this.lblText_Recherche.Text = "Recheche :";
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.Silver;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 77);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersVisible = false;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(450, 309);
            this.bunifuCustomDataGrid1.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // UCListeEmployes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtRecherchePrenom);
            this.Controls.Add(this.txtRechercheNom);
            this.Controls.Add(this.txtRechercheNum);
            this.Controls.Add(this.lblText_ParPrenom);
            this.Controls.Add(this.lblText_ParNom);
            this.Controls.Add(this.lblText_ParNumero);
            this.Controls.Add(this.lblText_Recherche);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Name = "UCListeEmployes";
            this.Size = new System.Drawing.Size(932, 396);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecherchePrenom;
        private System.Windows.Forms.TextBox txtRechercheNom;
        private System.Windows.Forms.TextBox txtRechercheNum;
        private System.Windows.Forms.Label lblText_ParPrenom;
        private System.Windows.Forms.Label lblText_ParNom;
        private System.Windows.Forms.Label lblText_ParNumero;
        private System.Windows.Forms.Label lblText_Recherche;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
