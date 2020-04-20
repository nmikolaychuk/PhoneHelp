using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbonentContacts
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void okey_contact_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancel_contact_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public Dictionary<int, string> ProviderData     // ассоциативный массив
        {
            set
            {
                provider_combobox.DataSource = value.ToArray();
                provider_combobox.DisplayMember = "Value";
            }
        }

        public int ProviderIdSelect
        {
            get
            {
                return ((KeyValuePair<int, string>)provider_combobox.SelectedItem).Key;
            }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in provider_combobox.Items)
                {
                    if (item.Key == value)
                    {
                        break;
                    }
                    idx++;
                }
                provider_combobox.SelectedIndex = idx;
            }
        }
    }
}
