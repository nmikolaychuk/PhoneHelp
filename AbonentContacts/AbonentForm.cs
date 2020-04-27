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
    public partial class AbonentForm : Form
    {
        public AbonentForm()
        {
            InitializeComponent();

            dateTimePicker_bd.MinDate = new DateTime(1900, 1, 1);
            dateTimePicker_bd.MaxDate = DateTime.Today;
        }

        private void okey_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
