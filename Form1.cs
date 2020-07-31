// Nigel Krajewski
// MDV1830-O C202007 01
// Synthesis - FINAL

using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NigelKrajewski_Final
{
    public partial class Form1 : Form
    {
        // public global db connection
        MySqlConnection conn = new MySqlConnection();
        // instaniate data tables to hold query results
        DataTable listViewData = new DataTable();
        DataTable categoryData = new DataTable();
        DataTable publisherData = new DataTable();
        // var for current row index
        int currentRow = 0;
        // declare var to hold updated ship
        public ListViewItem lvi;
        // int to hold doubl clicked item index
        int doubleClickedIndex;

        public Form1()
        {
            InitializeComponent();
            FillForm();
        }

        // event to retry database connection 
        private void retryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillForm();
        }

        // method to update form with db data
        private void FillForm()
        {
            ClearInput();
            // invoke method for connection string
            string connString = DBUtilities.BuildConnectionString();
            conn = DBUtilities.Connect(connString);
            // only retrieve and update when db conn is successful
            if (conn.State == ConnectionState.Open)
            {
                FillCategories();
                FillPublishers();
                FillListView();
                ClearInput();
            }
            else
            {
                statusStripConnection.Visible = true;
            }
        }

        // method to fill category list with database data
        private void FillCategories()
        {
            RetrieveCategories();
            for (int i = 0; i < categoryData.Rows.Count; i++)
            {
                categoryComboBox.Items.Add(categoryData.Rows[i]["itemCategoryName"]);
            }
        }
        // method to retrieve categories from db
        private void RetrieveCategories()
        {
            // sql select statement
            string sql = "SELECT itemCategoryName FROM itemCategory";
            // create data adapter
            using (MySqlDataAdapter adr = new MySqlDataAdapter(sql, conn))
            {
                // set type of select command
                adr.SelectCommand.CommandType = CommandType.Text;
                // fill method to add rows to match data source
                adr.Fill(categoryData);
            }
        }

        // method to fill publisher combobox
        private void FillPublishers()
        {
            RetrievePublishers();
            for (int i = 0; i < publisherData.Rows.Count; i++)
            {
                publisherComboBox.Items.Add(publisherData.Rows[i]["itemPublisherName"]);
            }
            publisherComboBox.Items.Add("No publisher listed");
        }
        // method to retrieve publishers
        private void RetrievePublishers()
        {
            // sql select statement
            string sql = "SELECT itemPublisherName FROM itemPublisher";
            // create data adapter
            using (MySqlDataAdapter adr = new MySqlDataAdapter(sql, conn))
            {
                // set type of select command
                adr.SelectCommand.CommandType = CommandType.Text;
                // fill method to add rows to match data source
                adr.Fill(publisherData);
            }
        }

        // method to fill list view
        private void FillListView()
        {
            RetrieveData();
            for (int i = 0; i < listViewData.Rows.Count; i++)
            {
                NewListViewItem();
            }
            statusStripConnection.Visible = false;
        }
        // method to retrieve data for list view
        private void RetrieveData()
        {
            // create sql statment
            string sql = "SELECT i.title, i.retailPrice, ip.itemPublisherName, ic.itemCategoryName " +
                        "FROM itemPublisher as ip " +
                        "RIGHT JOIN item as i ON i.itemPublisherId = ip.itemPublisherId " +
                        "JOIN itemCategory as ic ON i.itemCategoryId = ic.itemCategoryId " +
                        "WHERE(i.itemPublisherId IS NULL) OR(i.itemPublisherId IS NOT NULL) " +
                        "ORDER BY i.itemId " +
                        "LIMIT 250; ";
            // create data adapter
            using (MySqlDataAdapter adr = new MySqlDataAdapter(sql, conn))
            {
                // set type of select command
                adr.SelectCommand.CommandType = CommandType.Text;
                // fill method to add rows to match data source
                adr.Fill(listViewData);
            }
        }

        // method to create dataitem from datatable
        private DataItem CreateItem()
        {
            DataItem d = new DataItem();
            d.Title = listViewData.Rows[currentRow]["title"].ToString();
            d.Category = listViewData.Rows[currentRow]["itemCategoryName"].ToString();
            if (listViewData.Rows[currentRow]["itemPublisherName"].ToString() == "")
            {
                d.Publisher = "No publisher listed";
            }
            else
            {
                d.Publisher = listViewData.Rows[currentRow]["itemPublisherName"].ToString();
            }
            d.Price = Convert.ToDecimal(listViewData.Rows[currentRow]["retailPrice"]);
            d.ImageIndex = categoryComboBox.Items.IndexOf(d.Category);

            currentRow++;
            return d;
        }
        // method to create new listView item
        private void NewListViewItem()
        {
            ListViewItem lvi = new ListViewItem();
            DataItem d = CreateItem();
            lvi.Text = d.ToString();
            lvi.ImageIndex = d.ImageIndex;
            lvi.Tag = d;
            itemListView.Items.Add(lvi);
        }

        // Exit click event
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // handle large icon menu selection
        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemListView.View = View.LargeIcon;
            largeIconToolStripMenuItem.CheckState = CheckState.Checked;
            smallIconToolStripMenuItem.CheckState = CheckState.Unchecked;
        }

        // handle small icon menu selection
        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemListView.View = View.SmallIcon;
            smallIconToolStripMenuItem.CheckState = CheckState.Checked;
            largeIconToolStripMenuItem.CheckState = CheckState.Unchecked;
        }

        // handle item double click
        private void itemListView_DoubleClick(object sender, EventArgs e)
        {
            DataItem d = itemListView.SelectedItems[0].Tag as DataItem;
            doubleClickedIndex = itemListView.Items.IndexOf(itemListView.SelectedItems[0]);
            textBoxTitle.Text = d.Title;
            categoryComboBox.Text = d.Category;
            publisherComboBox.Text = d.Publisher;
            numericPrice.Value = d.Price;
            numericPrice.Enabled = true;
            categoryComboBox.Enabled = true;
            publisherComboBox.Enabled = true;
            statusStripConnection.Visible = false;
        }

        // handle update button click
        private void updateButton_Click(object sender, EventArgs e)
        {
            
            if (textBoxTitle.Text != "")
            {
                bool updated = UpdateDataBase();
                if (updated)
                {
                    UpdateListView();
                    ClearInput();
                    statusStripConnection.Visible = true;
                    statusStripConnection.Items[1].Visible = false;
                    statusStripConnection.Items[2].Visible = false;
                    statusStripConnection.Items[0].Text = "Update Successful.";
                }
                else
                {
                    statusStripConnection.Visible = true;
                    statusStripConnection.Items[1].Visible = false;
                    statusStripConnection.Items[2].Visible = true;
                    statusStripConnection.Items[0].Text = "Update Failed.";
                }
            }
        }

        // method to update doubleclikced listview item
        private void UpdateListView()
        {
            DataItem d = new DataItem();
            d.Title = textBoxTitle.Text;
            d.Category = categoryComboBox.Text;
            d.Publisher = publisherComboBox.Text;
            d.Price = numericPrice.Value;
            d.ImageIndex = categoryComboBox.Items.IndexOf(d.Category);
            itemListView.Items[doubleClickedIndex].Tag = d;
            itemListView.Items[doubleClickedIndex].Text = d.ToString();
            itemListView.Items[doubleClickedIndex].ImageIndex = d.ImageIndex;
        }

        // Method to update database entry
        private bool UpdateDataBase()
        {
            // invoke method for connection string
            string connString = DBUtilities.BuildConnectionString();
            conn = DBUtilities.Connect(connString);
            // update when conn is successfu
            if (conn.State == ConnectionState.Open)
            {
                string sql = "UPDATE item " +
                            "SET itemCategoryId = @itemCategoryId, itemPublisherId = @itemPublisherId, retailPrice = @retailPrice " +
                            "WHERE title = @title";
                using (MySqlDataAdapter adr = new MySqlDataAdapter(sql, conn))
                {
                    // create new command to handle sql parameters
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    // add command parameters
                    cmd.Parameters.AddWithValue("@itemCategoryId", categoryComboBox.SelectedIndex + 1);
                    if (publisherComboBox.SelectedItem.Equals("No publisher listed"))
                    {
                        cmd.Parameters.AddWithValue("@itemPublisherId", null);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@itemPublisherId", publisherComboBox.SelectedIndex + 1);
                    }
                    cmd.Parameters.AddWithValue("@retailPrice", numericPrice.Value);
                    cmd.Parameters.AddWithValue("@title", textBoxTitle.Text);

                    // prepare command
                    adr.UpdateCommand = cmd;
                    // execute non query command
                    adr.UpdateCommand.ExecuteNonQuery();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method to clear inputs
        private void ClearInput()
        {
            textBoxTitle.Text = "";
            categoryComboBox.SelectedIndex = -1;
            publisherComboBox.SelectedIndex = -1;
            numericPrice.Value = 0.00M;
            numericPrice.Enabled = false;
            categoryComboBox.Enabled = false;
            publisherComboBox.Enabled = false;
            statusStripConnection.Visible = false;
        }

        // Method to view exception message details
        private void toolStripStatusDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DBUtilities.excptMsg);
        }
    }
}
