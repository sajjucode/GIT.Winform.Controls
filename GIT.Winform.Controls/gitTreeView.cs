using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIT.Winform.Controls
{
    public partial class gitTreeView : TreeView
    {
        DataTable _RecordDataTable;// = new DataTable();
        private Boolean _ClearNode = true;

        [Description("Use to Set Data Table"), Category("GITProperties")]
        public DataTable RecordDataTable
        {
            get
            {
                return this._RecordDataTable;
            }
            set
            {
                this._RecordDataTable = value;
            }
        }

        public BindingSource RecordBindingSource { get; set; }

        [Description("Use to Set Record ID Colum"), Category("GITProperties")]
        public String RecordIDColumnName { get; set; }

        [Description("Use to Set Parent ID Column"), Category("GITProperties")]
        public string ParentIDColumnName { get; set; }
        [Description("Use to Set Node Title Column"), Category("GITProperties")]
        public string NodeTitleColumnName { get; set; }

        [Description("Use to Clear All nodes on Fill"), Category("GITProperties")]
        public Boolean ClearNodes
        {
            get
            {
                return _ClearNode;
            }
            set
            {
                _ClearNode = value;
            }
        }
        public Boolean setTreeNodeViaDataTable()
        {
            try
            {
                if (String.IsNullOrEmpty(RecordIDColumnName) == true || String.IsNullOrWhiteSpace(RecordIDColumnName) == true)
                {
                    MessageBox.Show("Please Provide Record ID Column", "Invalide Column Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (String.IsNullOrEmpty(ParentIDColumnName) == true || String.IsNullOrWhiteSpace(ParentIDColumnName) == true)
                {
                    MessageBox.Show("Please Provide Parent ID Column", "Invalide Column Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (String.IsNullOrEmpty(NodeTitleColumnName) == true || String.IsNullOrWhiteSpace(NodeTitleColumnName) == true)
                {
                    MessageBox.Show("Please Provide Node Title Column", "Invalide Column Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (RecordDataTable == null)
                {
                    MessageBox.Show("Please Provide Record DataTable", "Invalide DataTable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                if (RecordDataTable != null && RecordDataTable.Rows.Count > 0)
                {
                    TreeNode myParentTreeNode = new TreeNode();
                    TreeNode myNewTreeNode = new TreeNode();
                    String TreeNodeKey = string.Empty;

                    if (this._ClearNode == true)
                    {
                        this.Nodes.Clear();
                    }

                    foreach (DataRow myRow in RecordDataTable.Rows)
                    {
                        myNewTreeNode = this.Nodes.Find("Node_" + myRow[RecordIDColumnName].ToString(), true).SingleOrDefault();

                        if (myNewTreeNode == null)
                        {

                            myNewTreeNode = new TreeNode();
                            myNewTreeNode.Name = "Node_" + myRow[RecordIDColumnName].ToString();
                        }
                        myNewTreeNode.Text = myRow[NodeTitleColumnName].ToString();

                        myNewTreeNode.Tag = myRow[RecordIDColumnName].ToString();// +"@" + myRow[ParentIDColumnName].ToString();
                        //myNewTreeNode.Checked = Convert.ToBoolean(myRow["isEnable"].ToString());

                        myParentTreeNode = this.Nodes.Find("Node_" + myRow[ParentIDColumnName].ToString(), true).SingleOrDefault();

                        if (myParentTreeNode != null)
                        {
                            myParentTreeNode.Nodes.Add(myNewTreeNode);
                        }
                        else
                        {
                            this.Nodes.Add(myNewTreeNode);
                        }
                    }

                }

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }


        public Boolean setTreeNodeViaDataBinding()
        {
            try
            {
                if (String.IsNullOrEmpty(RecordIDColumnName) == true || String.IsNullOrWhiteSpace(RecordIDColumnName) == true)
                {
                    MessageBox.Show("Please Provide Record ID Column", "Invalide Column Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (String.IsNullOrEmpty(ParentIDColumnName) == true || String.IsNullOrWhiteSpace(ParentIDColumnName) == true)
                {
                    MessageBox.Show("Please Provide Parent ID Column", "Invalide Column Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (String.IsNullOrEmpty(NodeTitleColumnName) == true || String.IsNullOrWhiteSpace(NodeTitleColumnName) == true)
                {
                    MessageBox.Show("Please Provide Node Title Column", "Invalide Column Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (RecordBindingSource == null)
                {
                    MessageBox.Show("Please Provide Record Binding Source", "Invalide Binding Source", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                if (RecordBindingSource != null && RecordBindingSource.Count > 0)
                {
                    TreeNode myParentTreeNode = new TreeNode();
                    TreeNode myNewTreeNode = new TreeNode();
                    String TreeNodeKey = string.Empty;
                    this.Nodes.Clear();

                    foreach (DataRow myRow in RecordDataTable.Rows)
                    {
                        myNewTreeNode = new TreeNode();
                        myNewTreeNode.Name = "Node_" + myRow[RecordIDColumnName].ToString();
                        myNewTreeNode.Text = myRow[NodeTitleColumnName].ToString();

                        myNewTreeNode.Tag = myRow[RecordIDColumnName].ToString() + "@" + myRow[ParentIDColumnName].ToString();
                        //myNewTreeNode.Checked = Convert.ToBoolean(myRow["isEnable"].ToString());

                        myParentTreeNode = this.Nodes.Find(myRow[ParentIDColumnName].ToString(), true).SingleOrDefault();

                        if (myParentTreeNode != null)
                        {
                            myParentTreeNode.Nodes.Add(myNewTreeNode);
                        }
                        else
                        {
                            this.Nodes.Add(myNewTreeNode);
                        }
                    }

                }

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public gitTreeView()
        {
            InitializeComponent();
        }
    }
}
