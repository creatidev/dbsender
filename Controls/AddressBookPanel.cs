using DBSender.Classes;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TreeView = System.Windows.Forms.TreeView;
using System.Xml.Linq;

namespace DBSender.Controls
{
    public partial class AddressBookPanel : UserControl
    {
        public List<string> ProjectList = new List<string>();
        public List<Client> ClientList = new List<Client>();
        private List<Client> _assignedClientList = new List<Client>();
        private List<Client> _allAssignedClientList = new List<Client>();

        //private List<string> _assignedProjectList = new List<string>();
        private List<string> _allAssignedProjectList = new List<string>();
        private static readonly Settings Settings = JsonFile.Settings;
        private static List<Address> _listAddresses = new List<Address>();
        private static List<AddressMod> _listAddressesMod = new List<AddressMod>();
        private static readonly List<string> Categories = Settings.Contacts.Categories;
        private Address _address = new Address();
        public bool DataLoaded;
        private bool _saved = true;
        private int _index = 0;

        public AddressBookPanel()
        {
            InitializeComponent();
            LoadContacts();
        }

        #region "Banner"

        private void CloseFilterWindowBtn_Click(object sender, EventArgs e)
        {
            Program.Form.MainMenuPanel.UpdatePics(DataLoaded);
            if (_saved == false)
            {
                var response = MessageBox.Show(@"¿Quiere guardar los cambios?", "DBSender", MessageBoxButtons.YesNoCancel);
                switch (response)
                {
                    case DialogResult.Yes:
                        _saved = true;
                        JsonFile.Save(Settings.ToJson());
                        Dispose();
                        break;

                    case DialogResult.No:
                        Dispose();
                        break;

                    case DialogResult.Cancel:
                        break;
                }
            }
            else
            {
                Dispose();
            }
        }

        #endregion "Banner"

        private void AddEmailBtn_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == "")
            {
                NameTxt.Focus();
                MessageBox.Show("Ingresar nombre", "DBSender");
            }
            else if (EmailTxt.Text == "")
            {
                EmailTxt.Focus();
                MessageBox.Show("Ingresar email", "DBSender");
            }
            else if (!Utils.IsValidEmail(EmailTxt.Text))
            {
                EmailTxt.Focus();
                MessageBox.Show("Ingresar email válido", "DBSender");
            }
            else if (EmailExist(EmailTxt.Text))//Validar si el email ya se encuentra registrado
            {
                EmailTxt.Focus();
                MessageBox.Show("El email ya se encuentra registrado", "DBSender");
            }
            else if (_assignedClientList.Count == 0)
            {
                MessageBox.Show("No se encuentran proyectos asociados al registro", "DBSender");
            }
            else
            {
                var address = new Address
                {
                    Name = NameTxt.Text,
                    Email = EmailTxt.Text,
                    Category = ListGroupsCbo.SelectedIndex,
                    Clients = _assignedClientList,
                    Enable = EnableContactChk.Checked
                };

                _saved = true;
                dataGridView1.Enabled = _saved;
                _listAddresses.Add(address);
                JsonFile.Save(Settings.ToJson());
                MessageBox.Show("Destinatario registrado correctamente", "DBSender");
                SetControlState(false);
                LoadContacts();
            }
        }

        private void UpdateEmailBtn_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == "")
            {
                NameTxt.Focus();
                MessageBox.Show("Por favor ingresar nombre", "DBSender");
            }
            else if (!Utils.IsValidEmail(EmailTxt.Text))
            {
                EmailTxt.Focus();
                MessageBox.Show("Por favor ingresar email válido", "DBSender");
            }
            else if (_assignedClientList.Count == 0)
            {
                MessageBox.Show("No se encuentran proyectos asociados al destinatario", "DBSender");
            }
            else
            {
                _saved = true;
                _address.Name = NameTxt.Text;
                _address.Email = EmailTxt.Text;
                _address.Category = CategoryCbo.SelectedIndex;
                _address.Clients = _assignedClientList;
                _address.Enable = EnableContactChk.Checked;
                _listAddresses[_index] = _address;
                JsonFile.Save(Settings.ToJson());
                dataGridView1.Enabled = _saved;
                ProjectsPnl.Enabled = _saved;
                MessageBox.Show("Destinatario actualizado correctamente", "DBSender");
                LoadContacts();
            }
        }

        public class AddressMod
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Category { get; set; }
            public int Clients { get; set; }
            public int Projects { get; set; }
        }

        private void LoadContacts()
        {
            ListGroupsCbo.DataSource = null;
            ListGroupsCbo.DataSource = Categories;
            CategoryCbo.DataSource = null;
            CategoryCbo.DataSource = Categories;
            _listAddresses = null;
            _listAddresses = Settings.Contacts.Address;
            _listAddressesMod = _listAddresses.Select(listAddress => new AddressMod { Name = listAddress.Name, Email = listAddress.Email, Category = Settings.Contacts.Categories[listAddress.Category], Clients = listAddress.Clients.Count, Projects = listAddress.Clients.Select(x => x.Projects.Count).Sum() }).ToList();

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _listAddressesMod;
            RegCountLbl.Text = _listAddressesMod.Count.ToString();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DeleteEmailBtn_Click(object sender, EventArgs e)
        {
            var option = MessageBox.Show(@"Esta acción será irreversible ¿Quiere continuar?", "DBSender", MessageBoxButtons.YesNo);
            switch (option)
            {
                case DialogResult.Yes:
                    if (dataGridView1.CurrentRow != null) _listAddresses.RemoveAt(dataGridView1.CurrentRow.Index);
                    SetControlState(false);
                    JsonFile.Save(Settings.ToJson());
                    _saved = true;
                    LoadContacts();
                    break;
                case DialogResult.No:
                    break;
            }
           
        }

        private bool CategoryExist(string group)
        {
            var groupExist = Categories.FirstOrDefault(x => x.Equals(group));
            return (groupExist != null);
        }

        private bool EmailExist(string email)
        {
            var emailExist = _listAddresses.FirstOrDefault(x => x.Email.Equals(email));
            return (emailExist != null);
        }

        private void ApplyFilerBtn_Click(object sender, EventArgs e)
        {
            var addresses = _listAddressesMod.Where(x => x.Category == ListGroupsCbo.SelectedItem.ToString());
            var filteredListAddresses = addresses.Select(data => new AddressMod { Name = data.Name, Email = data.Email, Category = data.Category, Projects = data.Projects }).ToList();
            RegCountLbl.Text = filteredListAddresses.Count.ToString();
            dataGridView1.DataSource = filteredListAddresses;
        }

        private void ListGroupsCbo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CategoryExist(ListGroupsCbo.Text))
            {
                //Settings.Contacts.Group = ListGroupsCbo.SelectedIndex;
            }
        }

        private void RestoreAdressesBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _listAddressesMod;
            dataGridView1.Enabled = true;
            LoadContacts();
        }

        private void NewContactBtn_Click(object sender, EventArgs e)
        {
            SetControlState(true);
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            SetControlState(false);
        }

        private void SetControlState(bool newContact)
        {
            AddEmailBtn.Visible = newContact;
            ProjectsPnl.Enabled = newContact;
            CancelBtn.Visible = newContact;
            NewContactBtn.Visible = !newContact;
            SelectedProjectPnl.Enabled = newContact;
            RegisteredPanel.Enabled = !newContact;
            UpdateEmailBtn.Visible = false;
            UserRegPnl.Enabled = newContact;
            CategoryCbo.SelectedIndex = 0;
            NameTxt.Text = "";
            EmailTxt.Text = "";
            AssociatedProjectsLbl.Text = "000";
            _assignedClientList = new List<Client>();
            SelectedProjectsChkLB.DataSource = null;
            UpdateTreeViews(SelectedProjectsTV, AssociatedProjectsLbl, _assignedClientList);
        }

        private void AddressBookPanel_Load(object sender, EventArgs e)
        {
            var associatedClients = Settings.Contacts.Address.SelectMany(x => x.Clients).Distinct().ToList();
            foreach (var client in associatedClients)
            {
                _allAssignedClientList.Add(client);
                ClientList = RemoveClientName(ClientList, client.Name, false);
            }
            ClientsLbl.Text = UpdateTreeViews(ProjectsByClientTV, ProjectsLbl, ClientList);
        }

        private void RemoveSelectionsBtn_Click(object sender, EventArgs e)
        {
            foreach (TreeNode nodes in SelectedProjectsTV.Nodes)
            {
                if (!nodes.Checked) continue;
                _assignedClientList = RemoveClientName(_assignedClientList, nodes.Text, true);
                _allAssignedClientList = RemoveClientName(_allAssignedClientList, nodes.Text, false);
            }
            _saved = false;
            UpdateTreeViews(SelectedProjectsTV, AssociatedProjectsLbl, _assignedClientList);
            LoadContacts();
        }

        private List<Client> RemoveClientName(List<Client> clients, string name, bool back)
        {
            var query = clients.Where(x => x.Name == name).Select(y => y).FirstOrDefault();
            if (back)
            {
                ClientList.Add(query);
                ClientsLbl.Text = UpdateTreeViews(ProjectsByClientTV, ProjectsLbl, ClientList);
            }

            clients.Remove(query);
            return clients;
        }

        private void AddSelectionsBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            if (UnassignedRB.Checked)
            {
                foreach (TreeNode nodes in ProjectsByClientTV.Nodes)
                {
                    var client = new Client();
                    if (!nodes.Checked) continue;
                    client.Name = nodes.Text;
                    var projects = (from TreeNode node in nodes.Nodes where node.Checked select node.Text).ToList();
                    client.Projects = projects;
                    _assignedClientList.Add(client);
                    _allAssignedClientList.Add(client);
                    ClientList = RemoveClientName(ClientList, client.Name, false);
                }
                ClientsLbl.Text = UpdateTreeViews(ProjectsByClientTV, ProjectsLbl, ClientList);
            }


            if (AssignedRB.Checked)
            {
                var client = new Client();
                var projects = new List<string>();
                foreach (TreeNode nodes in ProjectsByClientTV.Nodes)
                {
                    if (!nodes.Checked) continue;
                    client.Name = nodes.Text;
                    projects.AddRange(from TreeNode node in nodes.Nodes select node.Text);
                    client.Projects = projects.Select(x => x).Distinct().ToList();
                    _assignedClientList.Add(client);
                }
            }
            _saved = false;
            _assignedClientList = _assignedClientList.DistinctBy(x => x.Name).ToList();
            _allAssignedClientList = _allAssignedClientList.DistinctBy(x => x.Name).ToList();
            UpdateTreeViews(SelectedProjectsTV, AssociatedProjectsLbl, _assignedClientList);
        }

        private string UpdateTreeViews(TreeView treeView , Control label, List<Client> clients)
        {
            treeView.Nodes.Clear();
            var count = clients.Count;
            clients = clients.Where(x => x.Name != null).DistinctBy(x => x.Name).ToList();
            clients = clients.OrderBy(r => r.Name).ToList();
            
            var treeNodes = new List<TreeNode>();
            var childNodes = new List<TreeNode>();
            foreach (var client in clients)
            {
                if (client.Projects.Count > 0)
                {
                    if (client.Name == "") client.Name = "Sin grupo";
                    childNodes.AddRange(client.Projects.Select(clientProject => new TreeNode(clientProject)));
                    treeNodes.Add(new TreeNode(client.Name, 1, 1, childNodes.ToArray()));
                    childNodes.Clear();
                }
            }

            label.Text = clients.SelectMany(x => x.Projects).Count().ToString();
            treeView.Nodes.AddRange(treeNodes.ToArray());
            treeNodes.Clear();
            clients.Clear();
            return count.ToString();
        }

        private void UnassignedRB_CheckedChanged(object sender, EventArgs e)
        {
            ClientsLbl.Text = UpdateTreeViews(ProjectsByClientTV, ProjectsLbl, ClientList);
        }

        private void AssignedRB_CheckedChanged(object sender, EventArgs e)
        {
            ClientsLbl.Text = UpdateTreeViews(ProjectsByClientTV, ProjectsLbl, _allAssignedClientList);
        }

        private void ProjectsChkLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(ProjectsChkLB.SelectedIndex);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count <= 0) return;
            _index = dataGridView1.SelectedCells[0].RowIndex;
            _address = _listAddresses[_index];
            NameTxt.Text = _address.Name;
            EmailTxt.Text = _address.Email;
            ListGroupsCbo.SelectedIndex = _address.Category;
            EnableContactChk.Checked = _address.Enable;
            _assignedClientList = _address.Clients;
            UpdateTreeViews(SelectedProjectsTV, AssociatedProjectsLbl, _assignedClientList);
            AddEmailBtn.Visible = false;
            UpdateEmailBtn.Visible = true;
            UserRegPnl.Enabled = true;
            ProjectsPnl.Enabled = true;
            SelectedProjectPnl.Enabled = true;
        }

        private void ProjectsByClientTV_AfterCheck(object sender, TreeViewEventArgs e)
        {
            SetCheck(e);
        }

        private void SelectedProjectsTV_AfterCheck(object sender, TreeViewEventArgs e)
        {
            SetCheck(e);
        }

        private void SetCheck(TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.Unknown) return;

            if (e.Node.Nodes.Count > 0)
            {
                CheckAllChildNodes(e.Node, e.Node.Checked);
            }
            SelectParents(e.Node, e.Node.Checked);
        }

        private static void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;

                if (node.Nodes.Count > 0)
                {
                    CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        private void SelectParents(TreeNode node, bool isChecked)
        {
            while (true)
            {
                var parent = node.Parent;

                if (parent == null) return;

                if (!isChecked && HasCheckedNode(parent)) return;

                parent.Checked = isChecked;
                node = parent;
            }
        }

        private static bool HasCheckedNode(TreeNode node)
        {
            return node.Nodes.Cast<TreeNode>().Any(n => n.Checked);
        }
    }
}