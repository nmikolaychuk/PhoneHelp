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
    public partial class PhoneHelpForm : Form
    {
        public PhoneHelpForm()
        {
            InitializeComponent();
        }

        private void add_phonehelp_okey_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void add_phonehelp_cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        public Dictionary<int, string> AbonentData     // ассоциативный массив
        {
            set
            {
               add_phonehelp_abonent_combobox.DataSource = value.ToArray();
               add_phonehelp_abonent_combobox.DisplayMember = "Value";
            }
        }


        public Dictionary<int, string> PhoneData     // ассоциативный массив
        {
            set
            {
                add_phonehelp_phone_combobox.DataSource = value.ToArray();
                add_phonehelp_phone_combobox.DisplayMember = "Value";
            }
        }

        public int AbonentIdSelect
        {
            get
            {
                return ((KeyValuePair<int, string>)add_phonehelp_abonent_combobox.SelectedItem).Key;
            }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in add_phonehelp_abonent_combobox.Items)
                {
                    if (item.Key == value)
                    {
                        break;
                    }
                    idx++;
                }
                add_phonehelp_abonent_combobox.SelectedIndex = idx;
            }
        }

        public int ContactIdSelect
        {
            get
            {
                return ((KeyValuePair<int, string>)add_phonehelp_phone_combobox.SelectedItem).Key;
            }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in add_phonehelp_phone_combobox.Items)
                {
                    if (item.Key == value)
                    {
                        break;
                    }
                    idx++;
                }
                add_phonehelp_phone_combobox.SelectedIndex = idx;
            }
        }
    }
}
