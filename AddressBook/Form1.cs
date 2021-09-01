using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class AddressBookForm : Form
    {
        private DataGridView addressGridView;

        public AddressBookForm()
        {
            InitializeComponent();
        }

        private void AddressBookForm_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        /// <summary>
        /// METHOD: Populates the gridview with sample address data
        /// Data will always load when opening the address book
        /// </summary>
        private void PopulateDataGridView()
        {
            string[] row0 = { "Peter", "Parker", "20 Ingram Street", "Forest Hills", "NY", "11375" };
            string[] row1 = { "Clark", "Kent", "344 Clinton St, Apt 3B", "Metropolis", "NY" };
            string[] row2 = { "Bruce", "Wayne", "Wayne Manor", "Gotham City", "NY" };
            string[] row3 = { "Tony", "Stark", "59th Street and Broadway", "Manhattan", "NY", "10019" };
            string[] row4 = { "Hal", "Jordan", "22 Sea View", "Coast City", "CA", "92657"};

            addressGridView.Rows.Add(row0);
            addressGridView.Rows.Add(row1);
            addressGridView.Rows.Add(row2);
            addressGridView.Rows.Add(row3);
            addressGridView.Rows.Add(row4);
        }

        /// <summary>
        /// METHOD: Add button on form makes new entry in the address book
        /// Added data will not save in address book unless remade in a database
        /// </summary>
        private void addBtn_Click(object sender, EventArgs e)
        {
            this.addressGridView.Rows.Add(firstNameTxtBox.Text, lastNameTxtBox.Text, homeAddressTxtBox.Text, 
                                            cityTxtBox.Text, stateTxtBox.Text, zipCodeTxtBox.Text);
        }

        /// <summary>
        /// METHOD: Delete button on form removes entry by selecting and clicking remove button
        /// Deleted data will not save in address book unless remade in a database
        /// </summary>
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (this.addressGridView.SelectedRows.Count > 0 &&
                this.addressGridView.SelectedRows[0].Index !=
                this.addressGridView.Rows.Count - 1) 
            {
                this.addressGridView.Rows.RemoveAt(addressGridView.SelectedRows[0].Index);
            }
        }
    }
}
