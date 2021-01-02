using GesFic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
//colors
//tree
//C:\Users\asus pc\source\repos
namespace GesFicWF
{
    public partial class Form1 : Form
    {
        Dossier selected = null;
        Dossier toBeCopied = null;
        Fichier selectedf = null;
        Boolean isRename = true;
        Boolean isCut = false;
        Boolean isCop = false;

        //les utilisateurs
        Utilisateur metUser = new Utilisateur();
        List<Utilisateur> users;
        Utilisateur currentuser;

        //les dossiers avec privileges
        Dossier metDos = new Dossier();
        Privilege privDos_ = new Privilege();
        List<Dossier> dossiers;
        List<Privilege> privDos;
        Dossier currentDir;

        //les fichiers avec privileges
        Fichier metFic = new Fichier();
        Privilege metprivFic = new Privilege();
        List<Fichier> fichiers;
        List<Privilege> privFic;

        public Form1()
        {
            currentDir = metDos.find(9003);
            users = metUser.getAll();
            dossiers = metDos.getAll();
            fichiers = metFic.getAll();
            privFic = metprivFic.getAllFichier();
            privDos = metprivFic.getAllFichier();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getIcons();
            getIconsTree();
            fillList(listEnt);
            nbre.Text = listEnt.Items.Count +" ";
            path.Text = currentDir.getRoot(dossiers);
            fillTree();
        }

        private void getIcons()
        {
            imageEntList.Images.Clear();
            imageEntList.ImageSize = new Size(90, 90);
            listEnt.View = View.LargeIcon;
            listEnt.LargeImageList = imageEntList;
            imageEntList.Images.Add(Image.FromFile(@"..\..\..\icons\folder-icon-big-256.png"));
            imageEntList.Images.Add(Image.FromFile(@"..\..\..\icons\0.png"));
            imageEntList.Images.Add(Image.FromFile(@"..\..\..\icons\1.png"));
            imageEntList.Images.Add(Image.FromFile(@"..\..\..\icons\2.png"));
            imageEntList.Images.Add(Image.FromFile(@"..\..\..\icons\3.png"));
        }

        private void getIconsTree()
        {
            treeImageEnt.Images.Clear();
            treeViewEntites.ImageList = treeImageEnt;
            treeImageEnt.Images.Add(Image.FromFile(@"..\..\..\icons\folder-icon-big-256.png"));

        }

        private void fillList(ListView listEnt)
        {
            listEnt.LabelEdit = true;
            listEnt.ShowItemToolTips = true;
            listEnt.Clear();
            listEnt.Items.Clear();
            if (currentDir.getSubDos() != null) 
            {
                foreach (Dossier dossier in currentDir.getSubDos())
                {
                    listEnt.Items.Add(dossier.NomRep, 0);
                }
            }
            if (currentDir.getSubFic() != null)
            {
                foreach (Fichier fichier in currentDir.getSubFic())
                {
                    switch (fichier.Extension.ToLower())
                    {
                        case "txt":
                            listEnt.Items.Add(fichier.NomFic, 2);
                            break;

                        case "c":
                            listEnt.Items.Add(fichier.NomFic, 3);
                            break;
                        case "doc":
                            listEnt.Items.Add(fichier.NomFic, 4);
                            break;
                        default:
                            listEnt.Items.Add(fichier.NomFic, 1);
                            break;
                    }
                }
            }
            nbre.Text = listEnt.Items.Count + " ";
        }

        private void fillTree()
        {
            treeViewEntites.BeginUpdate();
            treeViewEntites.Nodes.Clear();
            fichiers = metFic.getAll();
            dossiers = metDos.getAll();
            TreeNode bn = new TreeNode(metDos.find(9003).NomRep);
            bn.ImageIndex = 0;
            foreach(Dossier t in dossiers)
            {
                if(t.Parent== metDos.find(9003).Id_d)
                {
                    bn.Nodes.Add(fillDirectory(t));
                }
            }
            treeViewEntites.Nodes.Add(bn);
            treeViewEntites.EndUpdate();
            treeViewEntites.ExpandAll();
        }

        private TreeNode fillDirectory(Dossier te)
        {
            TreeNode sn = new TreeNode(te.NomRep);
            sn.ImageIndex = 0;
            foreach (Dossier dos in dossiers)
            {
                if (te.Id_d == dos.Parent)
                {
                    sn.Nodes.Add(fillDirectory(dos));
                }
            }
            return sn;
        }

        private void listEnt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listEnt.SelectedItems.Count > 0)
            {
                currentDir = currentDir.getDos(dossiers, listEnt.SelectedItems[0].SubItems[0].Text);
                if (currentDir != null)
                {
                    fillList(listEnt);
                    path.Text = currentDir.getRoot(dossiers);
                }
            }
        }

        private void listEnt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listEnt.FocusedItem != null)
                {
                    if (listEnt.FocusedItem.Bounds.Contains(e.Location))
                    {
                        rightPanel.Show(Cursor.Position);
                    }
                    else if (!listEnt.FocusedItem.Bounds.Contains(e.Location))
                    {
                        listMenu.Show(Cursor.Position);
                    }
                }
                else
                {
                    listMenu.Show(Cursor.Position);
                }
            }
        }

        private void dossierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            isRename = false;
            listEnt.Items.Add(" ", 0);
            listEnt.FocusedItem = listEnt.FindItemWithText(" ");
            listEnt.FocusedItem.Selected = true;
            listEnt.FocusedItem.BeginEdit();
        }

        private bool testForErrorDossier(LabelEditEventArgs e)
        {
            var r = new Regex(@"^[a-zA-Z]*$");
            if (r.IsMatch(e.Label) && currentDir.getDos(dossiers, e.Label) == null)
                return true;
            else
            {
                if (currentDir.getDos(dossiers, e.Label) != null)
                {
                    MessageBox.Show("la destination contient deja un dossier nommé " + e.Label);
                    e.CancelEdit = true;
                    fillList(listEnt);
                }
                else
                {
                    MessageBox.Show("Un nom de dossier ne peut contenir aucun des caractères suivants: / : * ? <> |");
                    e.CancelEdit = true;
                    fillList(listEnt);
                }
                return false;
            }
        }

        private bool testForErrorFichier(LabelEditEventArgs e)
        {
            var r = new Regex(@"^[\w]+\.[A-Za-z]*$");
            if (r.IsMatch(e.Label) && currentDir.getFic(fichiers, e.Label.Split('.')[0]) == null)
                return true;
            else
            {
                if (!r.IsMatch(e.Label))
                {
                    MessageBox.Show("Un nom de fichier ne peut contenir aucun des caractères suivants: / : * ? <> |");
                    /*err.Show("Un nom de fichier ne peut contenir aucun des caractères suivants: / : * ? <> |", listEnt,
                         new Point(listEnt.SelectedItems[0].Position.X + 15, listEnt.SelectedItems[0].Position.Y + 40), 5000); 
                    err.ShowAlways = true;
                    err.SetToolTip(listEnt, "Un nom de fichier ne peut contenir aucun des caractères suivants: / : * ? <> |");*/
                    e.CancelEdit = true;
                    fillList(listEnt);
                }
                else
                {
                    MessageBox.Show("la destination contient deja un fichier nommé " + e.Label);
                    e.CancelEdit = true;
                    fillList(listEnt);
                }
                return false;
            }
        }

        private void fichierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            isRename = false;
            listEnt.Items.Add(" ", 1);
            listEnt.FocusedItem = listEnt.FindItemWithText(" ");
            listEnt.FocusedItem.Selected = true;
            listEnt.FocusedItem.BeginEdit();
        }

        private void renommerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listEnt.SelectedItems.Count > 0)
            {
                isRename = true;
                listEnt.SelectedItems[0].BeginEdit();
            }

        }

        private void listEnt_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if ((selected != null || selectedf!=null) && isRename && e.Label != null)
            {
                if (listEnt.SelectedItems[0].ImageIndex == 0)
                {
                    if (testForErrorDossier(e))
                    {
                        selected.NomRep = e.Label;
                        selected.update();
                        fillTree();
                    }
                }
                else
                {
                    if (testForErrorFichier(e))
                    {
                        selectedf.NomFic = e.Label;
                        //selectedf.Extension = e.Label.Split('.')[1];
                        selectedf.update();
                        fillList(listEnt);
                    }
                }
            }
            else if(e.Label != null)
            {
                if (listEnt.SelectedItems[0].ImageIndex == 0)
                {
                    if (testForErrorDossier(e))
                    {
                        new Dossier(e.Label, currentDir.Id_d, DateTime.Now, true);
                        fillTree();
                    }
                }
                else
                {
                    if (testForErrorFichier(e))
                    {
                        new Fichier(e.Label.Split('.')[0], e.Label.Split('.')[1], currentDir.Id_d, DateTime.Today, true);
                        fillList(listEnt);
                    }
                        
                }
            }
            else
            {
                e.CancelEdit = true;
                fillList(listEnt);
                fillTree();
            }
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            if (currentDir != null)
            {
                if (currentDir.getDosById(dossiers, currentDir.Parent) != null)
                {
                    currentDir = currentDir.getDosById(dossiers, currentDir.Parent);
                    fillList(listEnt);
                    path.Text = currentDir.getRoot(dossiers);
                }
            }

        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selected != null) {
                if (DialogResult.Yes == MessageBox.Show("voulez vous vraiment supprimer ce dossier de façon permanente", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    currentDir.supp(dossiers, selected.NomRep);
                    selected = null;
                    fillList(listEnt);
                    fillTree();
                }
            }
            else
            {
                if (selectedf != null)
                {
                    if (DialogResult.Yes == MessageBox.Show("voulez vous vraiment supprimer ce fichier de façon permanente", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        currentDir.supp(fichiers, selectedf.NomFic);
                        selectedf = null;
                        fillList(listEnt);
                    }
                }
            }
        }

        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listEnt.SelectedItems[0].ImageIndex == 0)
            {
                selected = currentDir.getDos(dossiers, listEnt.SelectedItems[0].SubItems[0].Text);
            }
            else
            {
                selectedf = currentDir.getFic(fichiers, listEnt.SelectedItems[0].SubItems[0].Text);
            }
            isCut = true;
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isCop)
            {
                if (selected != null)
                {
                    if(selected.Id_d != currentDir.getDos(dossiers, listEnt.SelectedItems[0].SubItems[0].Text).Id_d && (selected.Id_d != currentDir.getDos(dossiers, listEnt.SelectedItems[0].SubItems[0].Text).Parent))
                    {
                        selected.Parent = currentDir.getDos(dossiers, listEnt.SelectedItems[0].SubItems[0].Text).Id_d;
                        selected.update();
                        fillList(listEnt);
                        selected = null;
                    }
                    else
                    {
                        MessageBox.Show("Le dossier de destiantion est un sous-dossier du dossier source");
                    }
                }
                else
                {
                    if (selectedf != null)
                    {
                        selectedf.Parent = currentDir.getDos(dossiers, listEnt.SelectedItems[0].SubItems[0].Text).Id_d;
                        selectedf.update();
                        selectedf = null;
                    }
                }
                isCut = false;
            }
            else
            {
                if (selected != null)
                {
                    selected.copieFolderTo(toBeCopied, currentDir.getDos(dossiers, listEnt.SelectedItems[0].SubItems[0].Text));
                    fillList(listEnt);
                    selected = null;
                }
                else
                {
                    selected.copieFileTo(selectedf, selected);
                    selectedf = null;
                }
                isCop = false;
            }
            fillList(listEnt);
            fillTree();
        }

        private void listEnt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isCut)
            {
                if (listEnt.SelectedItems.Count > 0)
                {
                    if (listEnt.SelectedItems[0].ImageIndex == 0)
                    {
                        selected = currentDir.getDos(dossiers, listEnt.SelectedItems[0].SubItems[0].Text);
                    }
                    else
                    {
                        selectedf = currentDir.getFic(fichiers, listEnt.SelectedItems[0].SubItems[0].Text);
                    }
                }
            }
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selected!=null)
            {
                currentDir = selected;
                fillList(listEnt);
                nbre.Text = listEnt.Items.Count + " ";
                path.Text = currentDir.getRoot(dossiers);
            }
            selected = null;
        }

        private void pictureBoxRoot_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(selected.getRoot(dossiers));
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isCop = true;
            toBeCopied = selected;
        }

        private void listEnt_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
           /* Control p = sender as Control;
            p.BackColor = Color.FromArgb(51, 102, 204);*/
        }
    }
}