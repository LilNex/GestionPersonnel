using System.Drawing;
namespace Gestion_Personnel
{
    partial class frmPrincipal_Directeur
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
            this.pnlGauche = new System.Windows.Forms.Panel();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.btnParametre = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnX = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDemandes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGstPaie = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmployes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlDrag = new System.Windows.Forms.Panel();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ucEmployes = new Gestion_Personnel.CustomControls.UCEmployes();
            this.ucDashboard1 = new Gestion_Personnel.CustomControls.UCDashboard();
            this.ucProfil1 = new Gestion_Personnel.CustomControls.UCProfil();
            this.pnlGauche.SuspendLayout();
            this.pnlDrag.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGauche
            // 
            this.pnlGauche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.pnlGauche.Controls.Add(this.pnlActive);
            this.pnlGauche.Controls.Add(this.btnParametre);
            this.pnlGauche.Controls.Add(this.btnX);
            this.pnlGauche.Controls.Add(this.btnDemandes);
            this.pnlGauche.Controls.Add(this.btnGstPaie);
            this.pnlGauche.Controls.Add(this.btnEmployes);
            this.pnlGauche.Controls.Add(this.btnDashboard);
            this.pnlGauche.Controls.Add(this.ucProfil1);
            this.pnlGauche.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGauche.Location = new System.Drawing.Point(0, 0);
            this.pnlGauche.Name = "pnlGauche";
            this.pnlGauche.Size = new System.Drawing.Size(200, 600);
            this.pnlGauche.TabIndex = 0;
            // 
            // pnlActive
            // 
            this.pnlActive.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlActive.Location = new System.Drawing.Point(0, 185);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(12, 49);
            this.pnlActive.TabIndex = 0;
            // 
            // btnParametre
            // 
            this.btnParametre.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnParametre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnParametre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnParametre.BorderRadius = 0;
            this.btnParametre.ButtonText = "Paramètre";
            this.btnParametre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParametre.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(58)))), ((int)(((byte)(79)))));
            this.btnParametre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametre.Iconcolor = System.Drawing.Color.Transparent;
            this.btnParametre.Iconimage = null;
            this.btnParametre.Iconimage_right = global::Gestion_Personnel.Properties.Resources.icons8_settings_32px;
            this.btnParametre.Iconimage_right_Selected = null;
            this.btnParametre.Iconimage_Selected = null;
            this.btnParametre.IconMarginLeft = 0;
            this.btnParametre.IconMarginRight = 0;
            this.btnParametre.IconRightVisible = true;
            this.btnParametre.IconRightZoom = 0D;
            this.btnParametre.IconVisible = true;
            this.btnParametre.IconZoom = 50D;
            this.btnParametre.IsTab = false;
            this.btnParametre.Location = new System.Drawing.Point(0, 551);
            this.btnParametre.Margin = new System.Windows.Forms.Padding(0);
            this.btnParametre.Name = "btnParametre";
            this.btnParametre.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnParametre.OnHovercolor = System.Drawing.Color.LightSkyBlue;
            this.btnParametre.OnHoverTextColor = System.Drawing.Color.White;
            this.btnParametre.selected = false;
            this.btnParametre.Size = new System.Drawing.Size(202, 49);
            this.btnParametre.TabIndex = 5;
            this.btnParametre.Text = "Paramètre";
            this.btnParametre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnParametre.Textcolor = System.Drawing.Color.White;
            this.btnParametre.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnX
            // 
            this.btnX.Activecolor = System.Drawing.Color.LightSkyBlue;
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnX.BorderRadius = 0;
            this.btnX.ButtonText = "Dashboard";
            this.btnX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnX.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(58)))), ((int)(((byte)(79)))));
            this.btnX.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Iconcolor = System.Drawing.Color.Transparent;
            this.btnX.Iconimage = null;
            this.btnX.Iconimage_right = global::Gestion_Personnel.Properties.Resources.icons8_add_user_male_32px;
            this.btnX.Iconimage_right_Selected = null;
            this.btnX.Iconimage_Selected = null;
            this.btnX.IconMarginLeft = 0;
            this.btnX.IconMarginRight = 0;
            this.btnX.IconRightVisible = true;
            this.btnX.IconRightZoom = 0D;
            this.btnX.IconVisible = true;
            this.btnX.IconZoom = 50D;
            this.btnX.IsTab = false;
            this.btnX.Location = new System.Drawing.Point(0, 381);
            this.btnX.Margin = new System.Windows.Forms.Padding(0);
            this.btnX.Name = "btnX";
            this.btnX.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnX.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.btnX.OnHoverTextColor = System.Drawing.Color.White;
            this.btnX.selected = false;
            this.btnX.Size = new System.Drawing.Size(202, 49);
            this.btnX.TabIndex = 4;
            this.btnX.Text = "Dashboard";
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnX.Textcolor = System.Drawing.Color.White;
            this.btnX.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnDemandes
            // 
            this.btnDemandes.Activecolor = System.Drawing.Color.LightSkyBlue;
            this.btnDemandes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnDemandes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDemandes.BorderRadius = 0;
            this.btnDemandes.ButtonText = "Demandes";
            this.btnDemandes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDemandes.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(58)))), ((int)(((byte)(79)))));
            this.btnDemandes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDemandes.Iconimage = null;
            this.btnDemandes.Iconimage_right = global::Gestion_Personnel.Properties.Resources.icons8_checklist_32px;
            this.btnDemandes.Iconimage_right_Selected = null;
            this.btnDemandes.Iconimage_Selected = null;
            this.btnDemandes.IconMarginLeft = 0;
            this.btnDemandes.IconMarginRight = 0;
            this.btnDemandes.IconRightVisible = true;
            this.btnDemandes.IconRightZoom = 0D;
            this.btnDemandes.IconVisible = true;
            this.btnDemandes.IconZoom = 60D;
            this.btnDemandes.IsTab = false;
            this.btnDemandes.Location = new System.Drawing.Point(0, 332);
            this.btnDemandes.Margin = new System.Windows.Forms.Padding(0);
            this.btnDemandes.Name = "btnDemandes";
            this.btnDemandes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnDemandes.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.btnDemandes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDemandes.selected = false;
            this.btnDemandes.Size = new System.Drawing.Size(202, 49);
            this.btnDemandes.TabIndex = 3;
            this.btnDemandes.Text = "Demandes";
            this.btnDemandes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDemandes.Textcolor = System.Drawing.Color.White;
            this.btnDemandes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandes.Click += new System.EventHandler(this.btnDemandes_Click);
            // 
            // btnGstPaie
            // 
            this.btnGstPaie.Activecolor = System.Drawing.Color.LightSkyBlue;
            this.btnGstPaie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnGstPaie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGstPaie.BorderRadius = 0;
            this.btnGstPaie.ButtonText = "Gestion de paie";
            this.btnGstPaie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGstPaie.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(58)))), ((int)(((byte)(79)))));
            this.btnGstPaie.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGstPaie.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGstPaie.Iconimage = null;
            this.btnGstPaie.Iconimage_right = global::Gestion_Personnel.Properties.Resources.icons8_euro_money_32px;
            this.btnGstPaie.Iconimage_right_Selected = null;
            this.btnGstPaie.Iconimage_Selected = null;
            this.btnGstPaie.IconMarginLeft = 0;
            this.btnGstPaie.IconMarginRight = 0;
            this.btnGstPaie.IconRightVisible = true;
            this.btnGstPaie.IconRightZoom = 0D;
            this.btnGstPaie.IconVisible = true;
            this.btnGstPaie.IconZoom = 50D;
            this.btnGstPaie.IsTab = false;
            this.btnGstPaie.Location = new System.Drawing.Point(0, 283);
            this.btnGstPaie.Margin = new System.Windows.Forms.Padding(0);
            this.btnGstPaie.Name = "btnGstPaie";
            this.btnGstPaie.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnGstPaie.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.btnGstPaie.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGstPaie.selected = false;
            this.btnGstPaie.Size = new System.Drawing.Size(202, 49);
            this.btnGstPaie.TabIndex = 2;
            this.btnGstPaie.Text = "Gestion de paie";
            this.btnGstPaie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGstPaie.Textcolor = System.Drawing.Color.White;
            this.btnGstPaie.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGstPaie.Click += new System.EventHandler(this.btnGstPaie_Click);
            // 
            // btnEmployes
            // 
            this.btnEmployes.Activecolor = System.Drawing.Color.LightSkyBlue;
            this.btnEmployes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnEmployes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployes.BorderRadius = 0;
            this.btnEmployes.ButtonText = "Employées";
            this.btnEmployes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployes.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(58)))), ((int)(((byte)(79)))));
            this.btnEmployes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmployes.Iconimage = null;
            this.btnEmployes.Iconimage_right = global::Gestion_Personnel.Properties.Resources.icons8_user_groups_32px;
            this.btnEmployes.Iconimage_right_Selected = null;
            this.btnEmployes.Iconimage_Selected = null;
            this.btnEmployes.IconMarginLeft = 0;
            this.btnEmployes.IconMarginRight = 0;
            this.btnEmployes.IconRightVisible = true;
            this.btnEmployes.IconRightZoom = 0D;
            this.btnEmployes.IconVisible = true;
            this.btnEmployes.IconZoom = 50D;
            this.btnEmployes.IsTab = false;
            this.btnEmployes.Location = new System.Drawing.Point(0, 234);
            this.btnEmployes.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmployes.Name = "btnEmployes";
            this.btnEmployes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnEmployes.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.btnEmployes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmployes.selected = false;
            this.btnEmployes.Size = new System.Drawing.Size(202, 49);
            this.btnEmployes.TabIndex = 1;
            this.btnEmployes.Text = "Employées";
            this.btnEmployes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmployes.Textcolor = System.Drawing.Color.White;
            this.btnEmployes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployes.Click += new System.EventHandler(this.btnEmployes_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.LightSkyBlue;
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "Dashboard";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(58)))), ((int)(((byte)(79)))));
            this.btnDashboard.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = null;
            this.btnDashboard.Iconimage_right = global::Gestion_Personnel.Properties.Resources.icons8_home_32px1;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 0;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 50D;
            this.btnDashboard.IsTab = false;
            this.btnDashboard.Location = new System.Drawing.Point(0, 185);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnDashboard.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashboard.selected = false;
            this.btnDashboard.Size = new System.Drawing.Size(202, 49);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDashboard.Textcolor = System.Drawing.Color.White;
            this.btnDashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlDrag
            // 
            this.pnlDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(58)))), ((int)(((byte)(79)))));
            this.pnlDrag.Controls.Add(this.btnMinimize);
            this.pnlDrag.Controls.Add(this.btnClose);
            this.pnlDrag.Location = new System.Drawing.Point(197, 0);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.Size = new System.Drawing.Size(955, 32);
            this.pnlDrag.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Activecolor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::Gestion_Personnel.Properties.Resources.icons8_minus_24px_1;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimize.BorderRadius = 0;
            this.btnMinimize.ButtonText = "";
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(58)))), ((int)(((byte)(79)))));
            this.btnMinimize.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMinimize.Iconimage = null;
            this.btnMinimize.Iconimage_right = null;
            this.btnMinimize.Iconimage_right_Selected = null;
            this.btnMinimize.Iconimage_Selected = null;
            this.btnMinimize.IconMarginLeft = 0;
            this.btnMinimize.IconMarginRight = 0;
            this.btnMinimize.IconRightVisible = true;
            this.btnMinimize.IconRightZoom = 0D;
            this.btnMinimize.IconVisible = true;
            this.btnMinimize.IconZoom = 50D;
            this.btnMinimize.IsTab = false;
            this.btnMinimize.Location = new System.Drawing.Point(893, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMinimize.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnMinimize.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMinimize.selected = false;
            this.btnMinimize.Size = new System.Drawing.Size(30, 31);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.Textcolor = System.Drawing.Color.White;
            this.btnMinimize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Activecolor = System.Drawing.Color.Red;
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.BackgroundImage = global::Gestion_Personnel.Properties.Resources.icons8_multiply_26px_4;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.BorderRadius = 0;
            this.btnClose.ButtonText = "";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(58)))), ((int)(((byte)(79)))));
            this.btnClose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClose.Iconimage = null;
            this.btnClose.Iconimage_right = null;
            this.btnClose.Iconimage_right_Selected = null;
            this.btnClose.Iconimage_Selected = null;
            this.btnClose.IconMarginLeft = 0;
            this.btnClose.IconMarginRight = 0;
            this.btnClose.IconRightVisible = true;
            this.btnClose.IconRightZoom = 0D;
            this.btnClose.IconVisible = true;
            this.btnClose.IconZoom = 50D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(922, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.Red;
            this.btnClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(30, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Textcolor = System.Drawing.Color.White;
            this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bnfDragControl
            // 
            this.bnfDragControl.Fixed = true;
            this.bnfDragControl.Horizontal = true;
            this.bnfDragControl.TargetControl = this.pnlDrag;
            this.bnfDragControl.Vertical = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlMain.Controls.Add(this.ucEmployes);
            this.pnlMain.Controls.Add(this.ucDashboard1);
            this.pnlMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMain.Location = new System.Drawing.Point(200, 32);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(952, 569);
            this.pnlMain.TabIndex = 2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ucEmployes
            // 
            this.ucEmployes.Location = new System.Drawing.Point(0, 0);
            this.ucEmployes.Margin = new System.Windows.Forms.Padding(1);
            this.ucEmployes.Name = "ucEmployes";
            this.ucEmployes.Size = new System.Drawing.Size(949, 568);
            this.ucEmployes.TabIndex = 0;
            // 
            // ucDashboard1
            // 
            this.ucDashboard1.DateNow = "$DateTime.Now$";
            this.ucDashboard1.Location = new System.Drawing.Point(0, 0);
            this.ucDashboard1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ucDashboard1.Name = "ucDashboard1";
            this.ucDashboard1.Size = new System.Drawing.Size(949, 568);
            this.ucDashboard1.TabIndex = 1;
            // 
            // ucProfil1
            // 
            this.ucProfil1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(58)))), ((int)(((byte)(79)))));
            this.ucProfil1.ForeColor = System.Drawing.Color.White;
            this.ucProfil1.Location = new System.Drawing.Point(0, 0);
            this.ucProfil1.Name = "ucProfil1";
            this.ucProfil1.Size = new System.Drawing.Size(200, 175);
            this.ucProfil1.TabIndex = 0;
            // 
            // frmPrincipal_Directeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 600);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlGauche);
            this.Controls.Add(this.pnlDrag);
            this.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmPrincipal_Directeur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal_Directeur";
            this.pnlGauche.ResumeLayout(false);
            this.pnlDrag.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGauche;
        private System.Windows.Forms.Panel pnlDrag;
        private Bunifu.Framework.UI.BunifuDragControl bnfDragControl;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnMinimize;
        private CustomControls.UCProfil ucProfil1;
        private System.Windows.Forms.Panel pnlMain;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private Bunifu.Framework.UI.BunifuFlatButton btnX;
        private Bunifu.Framework.UI.BunifuFlatButton btnDemandes;
        private Bunifu.Framework.UI.BunifuFlatButton btnGstPaie;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmployes;
        private Bunifu.Framework.UI.BunifuFlatButton btnParametre;
        private System.Windows.Forms.Panel pnlActive;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer;
        private CustomControls.UCEmployes ucEmployes;
        private CustomControls.UCDashboard ucDashboard1;
    }
}