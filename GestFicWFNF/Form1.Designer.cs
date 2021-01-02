namespace GesFicWF
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Toppanel = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.TextBox();
            this.treeViewEntites = new System.Windows.Forms.TreeView();
            this.listEnt = new System.Windows.Forms.ListView();
            this.imageEntList = new System.Windows.Forms.ImageList(this.components);
            this.listMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nouveauToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dossierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grandesIconesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightPanel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierPrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renommerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeImageEnt = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxCouper = new System.Windows.Forms.PictureBox();
            this.pictureBoxCopier = new System.Windows.Forms.PictureBox();
            this.pictureBoxColler = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.affichage = new System.Windows.Forms.Button();
            this.partage = new System.Windows.Forms.Button();
            this.accueil = new System.Windows.Forms.Button();
            this.fichier = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.nbre = new System.Windows.Forms.Label();
            this.nbrele = new System.Windows.Forms.Label();
            this.pictureBoxRoot = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.dateCreation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.back = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Toppanel.SuspendLayout();
            this.listMenu.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCouper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Toppanel
            // 
            this.Toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Toppanel.Controls.Add(this.back);
            this.Toppanel.Controls.Add(this.search);
            this.Toppanel.Controls.Add(this.path);
            this.Toppanel.Location = new System.Drawing.Point(0, 100);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(942, 34);
            this.Toppanel.TabIndex = 0;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(610, 7);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(315, 20);
            this.search.TabIndex = 1;
            // 
            // path
            // 
            this.path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.path.ForeColor = System.Drawing.Color.White;
            this.path.Location = new System.Drawing.Point(38, 7);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(541, 20);
            this.path.TabIndex = 0;
            // 
            // treeViewEntites
            // 
            this.treeViewEntites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.treeViewEntites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewEntites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeViewEntites.ForeColor = System.Drawing.Color.White;
            this.treeViewEntites.Location = new System.Drawing.Point(0, 133);
            this.treeViewEntites.Name = "treeViewEntites";
            this.treeViewEntites.ShowLines = false;
            this.treeViewEntites.ShowRootLines = false;
            this.treeViewEntites.Size = new System.Drawing.Size(158, 310);
            this.treeViewEntites.TabIndex = 1;
            // 
            // listEnt
            // 
            this.listEnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.listEnt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nom,
            this.dateCreation,
            this.type,
            this.taille});
            this.listEnt.Font = new System.Drawing.Font("Fira Code", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEnt.ForeColor = System.Drawing.Color.White;
            this.listEnt.HideSelection = false;
            this.listEnt.LargeImageList = this.imageEntList;
            this.listEnt.Location = new System.Drawing.Point(158, 133);
            this.listEnt.Name = "listEnt";
            this.listEnt.Size = new System.Drawing.Size(798, 322);
            this.listEnt.TabIndex = 2;
            this.listEnt.UseCompatibleStateImageBehavior = false;
            this.listEnt.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listEnt_AfterLabelEdit);
            this.listEnt.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listEnt_ItemMouseHover);
            this.listEnt.SelectedIndexChanged += new System.EventHandler(this.listEnt_SelectedIndexChanged);
            this.listEnt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listEnt_MouseClick);
            this.listEnt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listEnt_MouseDoubleClick);
            this.listEnt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listEnt_MouseClick);
            // 
            // imageEntList
            // 
            this.imageEntList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageEntList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageEntList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listMenu
            // 
            this.listMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem1,
            this.affichageToolStripMenuItem});
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(126, 48);
            // 
            // nouveauToolStripMenuItem1
            // 
            this.nouveauToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dossierToolStripMenuItem1,
            this.fichierToolStripMenuItem1});
            this.nouveauToolStripMenuItem1.Name = "nouveauToolStripMenuItem1";
            this.nouveauToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.nouveauToolStripMenuItem1.Text = "Nouveau";
            // 
            // dossierToolStripMenuItem1
            // 
            this.dossierToolStripMenuItem1.Name = "dossierToolStripMenuItem1";
            this.dossierToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.dossierToolStripMenuItem1.Text = "Dossier";
            this.dossierToolStripMenuItem1.Click += new System.EventHandler(this.dossierToolStripMenuItem1_Click);
            // 
            // fichierToolStripMenuItem1
            // 
            this.fichierToolStripMenuItem1.Name = "fichierToolStripMenuItem1";
            this.fichierToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.fichierToolStripMenuItem1.Text = "Fichier";
            this.fichierToolStripMenuItem1.Click += new System.EventHandler(this.fichierToolStripMenuItem1_Click);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grandesIconesToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // grandesIconesToolStripMenuItem
            // 
            this.grandesIconesToolStripMenuItem.Name = "grandesIconesToolStripMenuItem";
            this.grandesIconesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.grandesIconesToolStripMenuItem.Text = "Grandes icones";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            // 
            // rightPanel
            // 
            this.rightPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.modifierPrivilegesToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.couperToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.renommerToolStripMenuItem,
            this.collerToolStripMenuItem});
            this.rightPanel.Name = "contextMenuStrip1";
            this.rightPanel.Size = new System.Drawing.Size(173, 158);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ouvrirToolStripMenuItem.Text = "ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // modifierPrivilegesToolStripMenuItem
            // 
            this.modifierPrivilegesToolStripMenuItem.Name = "modifierPrivilegesToolStripMenuItem";
            this.modifierPrivilegesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.modifierPrivilegesToolStripMenuItem.Text = "modifier privileges";
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.copierToolStripMenuItem.Text = "copier";
            this.copierToolStripMenuItem.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // couperToolStripMenuItem
            // 
            this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            this.couperToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.couperToolStripMenuItem.Text = "couper";
            this.couperToolStripMenuItem.Click += new System.EventHandler(this.couperToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.supprimerToolStripMenuItem.Text = "supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // renommerToolStripMenuItem
            // 
            this.renommerToolStripMenuItem.Name = "renommerToolStripMenuItem";
            this.renommerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.renommerToolStripMenuItem.Text = "Renommer";
            this.renommerToolStripMenuItem.Click += new System.EventHandler(this.renommerToolStripMenuItem_Click);
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.collerToolStripMenuItem.Text = "coller";
            this.collerToolStripMenuItem.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // treeImageEnt
            // 
            this.treeImageEnt.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.treeImageEnt.ImageSize = new System.Drawing.Size(16, 16);
            this.treeImageEnt.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBoxRoot);
            this.panel1.Controls.Add(this.pictureBoxCouper);
            this.panel1.Controls.Add(this.pictureBoxCopier);
            this.panel1.Controls.Add(this.pictureBoxColler);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 65);
            this.panel1.TabIndex = 3;
            // 
            // pictureBoxCouper
            // 
            this.pictureBoxCouper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCouper.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCouper.Image")));
            this.pictureBoxCouper.Location = new System.Drawing.Point(212, 3);
            this.pictureBoxCouper.Name = "pictureBoxCouper";
            this.pictureBoxCouper.Size = new System.Drawing.Size(155, 22);
            this.pictureBoxCouper.TabIndex = 3;
            this.pictureBoxCouper.TabStop = false;
            this.pictureBoxCouper.Click += new System.EventHandler(this.couperToolStripMenuItem_Click);
            // 
            // pictureBoxCopier
            // 
            this.pictureBoxCopier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCopier.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCopier.Image")));
            this.pictureBoxCopier.Location = new System.Drawing.Point(75, 3);
            this.pictureBoxCopier.Name = "pictureBoxCopier";
            this.pictureBoxCopier.Size = new System.Drawing.Size(60, 62);
            this.pictureBoxCopier.TabIndex = 2;
            this.pictureBoxCopier.TabStop = false;
            this.pictureBoxCopier.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // pictureBoxColler
            // 
            this.pictureBoxColler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxColler.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxColler.Image")));
            this.pictureBoxColler.Location = new System.Drawing.Point(141, 3);
            this.pictureBoxColler.Name = "pictureBoxColler";
            this.pictureBoxColler.Size = new System.Drawing.Size(65, 59);
            this.pictureBoxColler.TabIndex = 1;
            this.pictureBoxColler.TabStop = false;
            this.pictureBoxColler.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 69);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.affichage);
            this.panel2.Controls.Add(this.partage);
            this.panel2.Controls.Add(this.accueil);
            this.panel2.Controls.Add(this.fichier);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 29);
            this.panel2.TabIndex = 4;
            // 
            // affichage
            // 
            this.affichage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.affichage.ForeColor = System.Drawing.Color.White;
            this.affichage.Location = new System.Drawing.Point(215, -1);
            this.affichage.Name = "affichage";
            this.affichage.Size = new System.Drawing.Size(75, 29);
            this.affichage.TabIndex = 3;
            this.affichage.Text = "Affichage";
            this.affichage.UseVisualStyleBackColor = true;
            // 
            // partage
            // 
            this.partage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.partage.ForeColor = System.Drawing.Color.White;
            this.partage.Location = new System.Drawing.Point(144, -1);
            this.partage.Name = "partage";
            this.partage.Size = new System.Drawing.Size(75, 29);
            this.partage.TabIndex = 2;
            this.partage.Text = "Partage";
            this.partage.UseVisualStyleBackColor = true;
            // 
            // accueil
            // 
            this.accueil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accueil.ForeColor = System.Drawing.Color.White;
            this.accueil.Location = new System.Drawing.Point(73, -1);
            this.accueil.Name = "accueil";
            this.accueil.Size = new System.Drawing.Size(75, 29);
            this.accueil.TabIndex = 1;
            this.accueil.Text = "Accueil";
            this.accueil.UseVisualStyleBackColor = true;
            // 
            // fichier
            // 
            this.fichier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(153)))), ((int)(((byte)(69)))));
            this.fichier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fichier.ForeColor = System.Drawing.Color.White;
            this.fichier.Location = new System.Drawing.Point(-1, -1);
            this.fichier.Name = "fichier";
            this.fichier.Size = new System.Drawing.Size(75, 29);
            this.fichier.TabIndex = 0;
            this.fichier.Text = "Fichier";
            this.fichier.UseVisualStyleBackColor = false;
            // 
            // err
            // 
            this.err.IsBalloon = true;
            this.err.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.nbre);
            this.panel3.Controls.Add(this.nbrele);
            this.panel3.Location = new System.Drawing.Point(0, 443);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 24);
            this.panel3.TabIndex = 5;
            // 
            // nbre
            // 
            this.nbre.AutoSize = true;
            this.nbre.ForeColor = System.Drawing.Color.White;
            this.nbre.Location = new System.Drawing.Point(3, 3);
            this.nbre.Name = "nbre";
            this.nbre.Size = new System.Drawing.Size(16, 13);
            this.nbre.TabIndex = 1;
            this.nbre.Text = "0 ";
            // 
            // nbrele
            // 
            this.nbrele.AutoSize = true;
            this.nbrele.ForeColor = System.Drawing.Color.White;
            this.nbrele.Location = new System.Drawing.Point(16, 3);
            this.nbrele.Name = "nbrele";
            this.nbrele.Size = new System.Drawing.Size(60, 13);
            this.nbrele.TabIndex = 0;
            this.nbrele.Text = "élément(s) |";
            // 
            // pictureBoxRoot
            // 
            this.pictureBoxRoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRoot.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRoot.Image")));
            this.pictureBoxRoot.Location = new System.Drawing.Point(212, 23);
            this.pictureBoxRoot.Name = "pictureBoxRoot";
            this.pictureBoxRoot.Size = new System.Drawing.Size(155, 21);
            this.pictureBoxRoot.TabIndex = 4;
            this.pictureBoxRoot.TabStop = false;
            this.pictureBoxRoot.Click += new System.EventHandler(this.pictureBoxRoot_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(212, 43);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(155, 22);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(373, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 64);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // dateCreation
            // 
            this.dateCreation.Text = "Date de création";
            this.dateCreation.Width = 134;
            // 
            // type
            // 
            this.type.Text = "Type";
            this.type.Width = 86;
            // 
            // taille
            // 
            this.taille.Text = "Taille";
            this.taille.Width = 81;
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 187;
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(12, 7);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(20, 20);
            this.back.TabIndex = 3;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(389, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 62);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(940, 467);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listEnt);
            this.Controls.Add(this.treeViewEntites);
            this.Controls.Add(this.Toppanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Toppanel.ResumeLayout(false);
            this.Toppanel.PerformLayout();
            this.listMenu.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCouper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Toppanel;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.TreeView treeViewEntites;
        private System.Windows.Forms.ListView listEnt;
        private System.Windows.Forms.ContextMenuStrip rightPanel;
        private System.Windows.Forms.ToolStripMenuItem modifierPrivilegesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renommerToolStripMenuItem;
        private System.Windows.Forms.ImageList treeImageEnt;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip listMenu;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dossierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grandesIconesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ImageList imageEntList;
        private System.Windows.Forms.PictureBox pictureBoxCouper;
        private System.Windows.Forms.PictureBox pictureBoxCopier;
        private System.Windows.Forms.PictureBox pictureBoxColler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button affichage;
        private System.Windows.Forms.Button partage;
        private System.Windows.Forms.Button accueil;
        private System.Windows.Forms.Button fichier;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolTip err;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label nbrele;
        private System.Windows.Forms.Label nbre;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBoxRoot;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader dateCreation;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader taille;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

