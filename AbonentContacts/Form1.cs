using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AbonentContacts
{
    public partial class Form1 : Form
    {
       private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\Nikita\Documents\Программы\AbonentContacts\AbonentContacts\DataBase_Task_1.mdf;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void updateAbonentDGV()
        {
            var request = "SELECT * FROM Mikolaichuk_Abonent";
            var adapter = new SqlDataAdapter(request, connectionString);

            var abonent_table = new DataTable();

            adapter.Fill(abonent_table);
            abonent_grid.DataSource = abonent_table;
            abonent_grid.Columns["id"].Visible = false;
            abonent_grid.Columns["name"].HeaderText = "Имя";
            abonent_grid.Columns["surname"].HeaderText = "Фамилия";
            abonent_grid.Columns["patronymic"].HeaderText = "Отчество";
            abonent_grid.Columns["address"].HeaderText = "Адрес";
            abonent_grid.Columns["birth_date"].HeaderText = "Дата рождения";
            abonent_grid.Columns["comment"].HeaderText = "Комментарий";
        }

        private void updateContactDGV()
        {
            var request = "SELECT * FROM Mikolaichuk_Contact JOIN Mikolaichuk_Provider ON Mikolaichuk_Contact.provider_id = Mikolaichuk_Provider.Id";
            var adapter = new SqlDataAdapter(request, connectionString);

            var contact_table = new DataTable();

            adapter.Fill(contact_table);
            contact_grid.DataSource = contact_table;
            contact_grid.Columns["id"].Visible = false;
            contact_grid.Columns["provider_id"].Visible = false;
            contact_grid.Columns["score"].Visible = false;
            contact_grid.Columns["Id1"].Visible = false;
            contact_grid.Columns["name"].HeaderText = "Провайдер";
            contact_grid.Columns["phone"].HeaderText = "Телефон";
            contact_grid.Columns["type"].HeaderText = "Тип телефона";
        }

        private void updateProviderDGV()
        {
            var request = "SELECT * FROM Mikolaichuk_Provider";
            var adapter = new SqlDataAdapter(request, connectionString);

            var provider_table = new DataTable();

            adapter.Fill(provider_table);
            provider_grid.DataSource = provider_table;
            provider_grid.Columns["id"].Visible = false;
            provider_grid.Columns["name"].HeaderText = "Название провайдера";
            provider_grid.Columns["score"].HeaderText = "Рейтинг провайдера";
        }

        private void updatePhoneHelpDGV()
        {
            var request = @"SELECT * FROM Mikolaichuk_Abonent JOIN Mikolaichuk_Abonent_has_Contact 
                                ON Mikolaichuk_Abonent.Id = Mikolaichuk_Abonent_has_Contact.abonent_id 
                      JOIN Mikolaichuk_Contact 
                                ON Mikolaichuk_Contact.Id = Mikolaichuk_Abonent_has_Contact.contact_id 
                     LEFT JOIN Mikolaichuk_Provider ON Mikolaichuk_Provider.Id = Mikolaichuk_Contact.provider_id";
            if (m_edit_phone.Text != "")
            {
                request += " WHERE Mikolaichuk_Contact.phone LIKE '%" + m_edit_phone.Text + "%'";
            }

            if (m_edit_fio.Text != "")
            {
                //request += " WHERE Mikolaichuk_Abonent.surname LIKE '%" + m_edit_fio.Text + @"%'
                //            OR Mikolaichuk_Abonent.name LIKE '%" + m_edit_fio.Text + @"%'
                //            OR Mikolaichuk_Abonent.patronymic LIKE '%" + m_edit_fio.Text + "%'";

                request += @" WHERE Mikolaichuk_Abonent.surname +' '+ Mikolaichuk_Abonent.name +' '+ Mikolaichuk_Abonent.patronymic LIKE '%" + m_edit_fio.Text + "%'";
            }
            var adapter = new SqlDataAdapter(request, connectionString);

            var phone_help_table = new DataTable();

            adapter.Fill(phone_help_table);
            phoneHelp_grid.DataSource = phone_help_table;
            phoneHelp_grid.Columns["id"].Visible = false;
            phoneHelp_grid.Columns["id1"].Visible = false;
            phoneHelp_grid.Columns["id2"].Visible = false;
            phoneHelp_grid.Columns["score"].Visible = false;
            phoneHelp_grid.Columns["birth_date"].Visible = false;
            phoneHelp_grid.Columns["comment"].Visible = false;
            phoneHelp_grid.Columns["contact_id"].Visible = false;
            phoneHelp_grid.Columns["abonent_id"].Visible = false;
            phoneHelp_grid.Columns["provider_id"].Visible = false;
            phoneHelp_grid.Columns["name"].HeaderText = "Имя";
            phoneHelp_grid.Columns["surname"].HeaderText = "Фамилия";
            phoneHelp_grid.Columns["patronymic"].HeaderText = "Отчество";
            phoneHelp_grid.Columns["address"].HeaderText = "Адрес";
            phoneHelp_grid.Columns["phone"].HeaderText = "Телефон";
            phoneHelp_grid.Columns["type"].HeaderText = "Тип телефона";
            phoneHelp_grid.Columns["name1"].HeaderText = "Название провайдера";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateAbonentDGV();
            updateContactDGV();
            updateProviderDGV();
            updatePhoneHelpDGV();
        }

        private void m_edit_phone_TextChanged(object sender, EventArgs e)
        {
            updatePhoneHelpDGV();
        }

        private void m_edit_fio_TextChanged(object sender, EventArgs e)
        {
            updatePhoneHelpDGV();
        }

        private void button_add_abonent_Click(object sender, EventArgs e)
        {
            var form = new AbonentForm();
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var surname = form.surname_textbox.Text;
                var name = form.name_textbox.Text;
                var patronymic = form.patronymic_textbox.Text;
                var comment = form.comment_textbox.Text;
                var address = form.address_textbox.Text;
                var birth_date = form.birthday_textbox.Text;

                var connection = new SqlConnection(connectionString);
                connection.Open();

                var request = @"INSERT INTO Mikolaichuk_Abonent (surname, name, patronymic, address, birth_date, comment) 
                    VALUES ('" + surname + "','" + name + "','" + patronymic + "','" + address + "','" + birth_date + "','" + comment + "')";
                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();

                connection.Close();
                updateAbonentDGV();
                updatePhoneHelpDGV();
            }
        }

        private void changeabonent_button_Click(object sender, EventArgs e)
        {
            var row = abonent_grid.SelectedRows.Count > 0 ? abonent_grid.SelectedRows[0] : null;
            if (row == null)
            {
                MessageBox.Show("Сначала укажите строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new AbonentForm();

            form.surname_textbox.Text = row.Cells["surname"].Value.ToString();
            form.name_textbox.Text = row.Cells["name"].Value.ToString();
            form.patronymic_textbox.Text = row.Cells["patronymic"].Value.ToString();
            form.address_textbox.Text = row.Cells["address"].Value.ToString();
            form.birthday_textbox.Text = row.Cells["birth_date"].Value.ToString();
            form.comment_textbox.Text = row.Cells["comment"].Value.ToString();

            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var surname = form.surname_textbox.Text;
                var name = form.name_textbox.Text;
                var patronymic = form.patronymic_textbox.Text;
                var comment = form.comment_textbox.Text;
                var address = form.address_textbox.Text;
                var birth_date = form.birthday_textbox.Text;
                var id = row.Cells["id"].Value.ToString();

                var connection = new SqlConnection(connectionString);
                connection.Open();

                var request = @"UPDATE Mikolaichuk_Abonent SET 
                        surname='" + surname + "', name='" + name + "', patronymic='" + patronymic + "', address='" + address + "'," +
                            " birth_date='" + birth_date + "', comment='" + comment + "' WHERE id='" + id + "'";
                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();

                connection.Close();
                updateAbonentDGV();
                updatePhoneHelpDGV();
            }
        }

        private void deleteabonent_button_Click(object sender, EventArgs e)
        {
            var row = abonent_grid.SelectedRows.Count > 0 ? abonent_grid.SelectedRows[0] : null;
            if (row == null)
            {
                MessageBox.Show("Сначала укажите строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = row.Cells["id"].Value.ToString();
            var connection = new SqlConnection(connectionString);
            connection.Open();

            var request = @"DELETE Mikolaichuk_Abonent WHERE id=" + id + "";
            var command = new SqlCommand(request, connection);
            command.ExecuteNonQuery();

            connection.Close();
            updateAbonentDGV();
            updatePhoneHelpDGV();
        }

        private void add_contact_button_Click(object sender, EventArgs e)
        {
            var form = new ContactForm();
            {
                var request = "SELECT * FROM Mikolaichuk_Provider";
                var adapter = new SqlDataAdapter(request, connectionString);
                var provider_table = new DataTable();
                adapter.Fill(provider_table);

                var dict = new Dictionary<int, string>();
                foreach (DataRow row in provider_table.Rows)
                {
                    dict.Add((int)row["id"], row["name"].ToString());
                }
                form.ProviderData = dict;
            }
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var phone = form.phone_textbox.Text;
                var type = form.typephone_textbox.Text;
                var providerid = form.ProviderIdSelect;

                var connection = new SqlConnection(connectionString);
                connection.Open();

                var request = @"INSERT INTO Mikolaichuk_Contact (phone, type, provider_id) 
                    VALUES ('" + phone + "','" + type + "','" + providerid.ToString() + "')";

                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();

                connection.Close();
                updateContactDGV();
                updatePhoneHelpDGV();
            }
        }

        private void edit_contact_button_Click(object sender, EventArgs e)
        {
            var row = contact_grid.SelectedRows.Count > 0 ? contact_grid.SelectedRows[0] : null;
            if (row == null)
            {
                MessageBox.Show("Сначала укажите строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new ContactForm();

            form.phone_textbox.Text = row.Cells["phone"].Value.ToString();
            form.typephone_textbox.Text = row.Cells["type"].Value.ToString();

            {
                var request = "SELECT * FROM Mikolaichuk_Provider";
                var adapter = new SqlDataAdapter(request, connectionString);
                var provider_table = new DataTable();
                adapter.Fill(provider_table);

                var dict = new Dictionary<int, string>();
                foreach (DataRow dbRow in provider_table.Rows)
                {
                    dict.Add((int)dbRow["id"], dbRow["name"].ToString());
                }
                form.ProviderData = dict;
            }
            form.ProviderIdSelect = (int)row.Cells["provider_id"].Value;
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var phone = form.phone_textbox.Text;
                var type = form.typephone_textbox.Text;
                var provider_id = form.ProviderIdSelect;
                var id = row.Cells["id"].Value.ToString();

                var connection = new SqlConnection(connectionString);
                connection.Open();

                var request = @"UPDATE Mikolaichuk_Contact SET 
                        phone='" + phone + "', type='" + type + "', provider_id='" + provider_id.ToString() + "' WHERE id='" + id + "'";
                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();

                connection.Close();
                updateContactDGV();
                updatePhoneHelpDGV();
            }
        }

        private void delete_contact_button_Click(object sender, EventArgs e)
        {
            var row = contact_grid.SelectedRows.Count > 0 ? contact_grid.SelectedRows[0] : null;
            if (row == null)
            {
                MessageBox.Show("Сначала укажите строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = row.Cells["id"].Value.ToString();
            var connection = new SqlConnection(connectionString);
            connection.Open();

            var request = @"DELETE Mikolaichuk_Contact WHERE id=" + id + "";
            var command = new SqlCommand(request, connection);
            command.ExecuteNonQuery();

            connection.Close();
            updateContactDGV();
            updatePhoneHelpDGV();
        }

        private void add_provider_button_Click(object sender, EventArgs e)
        {
            var form = new ProviderForm();
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var name = form.name_provider_textbox.Text;
                var score = form.score_provider_textbox.Text;

                var connection = new SqlConnection(connectionString);
                connection.Open();

                var request = @"INSERT INTO Mikolaichuk_Provider (name, score) 
                    VALUES ('" + name + "','" + score + "')";

                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();

                connection.Close();
                updateProviderDGV();
            }
        }

        private void edit_provider_button_Click(object sender, EventArgs e)
        {
            var row = provider_grid.SelectedRows.Count > 0 ? provider_grid.SelectedRows[0] : null;
            if (row == null)
            {
                MessageBox.Show("Сначала укажите строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new ProviderForm();

            form.name_provider_textbox.Text = row.Cells["name"].Value.ToString();
            form.score_provider_textbox.Text = row.Cells["score"].Value.ToString();

            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var name = form.name_provider_textbox.Text;
                var score = form.score_provider_textbox.Text;
                var id = row.Cells["id"].Value.ToString();

                var connection = new SqlConnection(connectionString);
                connection.Open();

                var request = @"UPDATE Mikolaichuk_Provider SET 
                        name='" + name + "', score='" + score + "' WHERE id='" + id + "'";
                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();

                connection.Close();
                updateProviderDGV();
                updateContactDGV();
                updatePhoneHelpDGV();
            }
        }

        private void delete_provider_button_Click(object sender, EventArgs e)
        {
            var row = provider_grid.SelectedRows.Count > 0 ? provider_grid.SelectedRows[0] : null;
            if (row == null)
            {
                MessageBox.Show("Сначала укажите строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = row.Cells["id"].Value.ToString();
            var connection = new SqlConnection(connectionString);
            connection.Open();

            var request = @"DELETE Mikolaichuk_Provider WHERE id=" + id + "";
            var command = new SqlCommand(request, connection);
            command.ExecuteNonQuery();

            connection.Close();
            updateProviderDGV();
            updateContactDGV();
            updatePhoneHelpDGV();
        }

        private void add_phonehelp_button_Click(object sender, EventArgs e)
        {
            var form = new PhoneHelpForm();
            {
                var request = "SELECT Id, surname + ' ' + name + ' ' + patronymic AS fio FROM Mikolaichuk_Abonent";
                var adapter = new SqlDataAdapter(request, connectionString);
                var abonent_table = new DataTable();
                adapter.Fill(abonent_table);

                var dict = new Dictionary<int, string>();
                foreach (DataRow row in abonent_table.Rows)
                {
                    dict.Add((int)row["Id"], row["fio"].ToString());
                }
                form.AbonentData = dict;
            }
            {
                var request = "SELECT Id, phone + ' (' + type + ') ' AS phonetype FROM Mikolaichuk_Contact";
                var adapter = new SqlDataAdapter(request, connectionString);
                var phone_table = new DataTable();
                adapter.Fill(phone_table);

                var dict = new Dictionary<int, string>();
                foreach (DataRow row in phone_table.Rows)
                {
                    dict.Add((int)row["Id"], row["phonetype"].ToString());
                }
                form.PhoneData = dict;
            }
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var abonentid = form.AbonentIdSelect;
                var contactid = form.ContactIdSelect;

                var connection = new SqlConnection(connectionString);
                connection.Open();

                var request = @"INSERT INTO Mikolaichuk_Abonent_has_Contact (contact_id, abonent_id) VALUES ('" + contactid.ToString() + "','" + abonentid.ToString() + "')";

                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();

                connection.Close();
                updatePhoneHelpDGV();
            }
        }

        private void edit_phonehelp_button_Click(object sender, EventArgs e)
        {
            var row = phoneHelp_grid.SelectedRows.Count > 0 ? phoneHelp_grid.SelectedRows[0] : null;
            if (row == null)
            {
                MessageBox.Show("Сначала укажите строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new PhoneHelpForm();
            {
                var request = "SELECT id, surname + ' ' + name + ' ' + patronymic AS fio FROM Mikolaichuk_Abonent";
                var adapter = new SqlDataAdapter(request, connectionString);
                var abonent_table = new DataTable();
                adapter.Fill(abonent_table);

                var dict = new Dictionary<int, string>();
                foreach (DataRow dbRow in abonent_table.Rows)
                {
                    dict.Add((int)dbRow["id"], dbRow["fio"].ToString());
                }
                form.AbonentData = dict;
            }
            {
                var request = "SELECT id, phone + ' (' + type + ') ' AS phonetype FROM Mikolaichuk_Contact";
                var adapter = new SqlDataAdapter(request, connectionString);
                var phone_table = new DataTable();
                adapter.Fill(phone_table);

                var dict = new Dictionary<int, string>();
                foreach (DataRow dbRow in phone_table.Rows)
                {
                    dict.Add((int)dbRow["id"], dbRow["phonetype"].ToString());
                }
                form.PhoneData = dict;
            }

            form.AbonentIdSelect = (int)row.Cells["abonent_id"].Value;
            form.ContactIdSelect = (int)row.Cells["contact_id"].Value;
            
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var abonentid = form.AbonentIdSelect;
                var contactid = form.ContactIdSelect;
                var abonentid_sel = row.Cells["abonent_id"].Value.ToString();
                var contactid_sel = row.Cells["contact_id"].Value.ToString();

                var connection = new SqlConnection(connectionString);
                connection.Open();

                var request = @"UPDATE Mikolaichuk_Abonent_has_Contact SET 
                        contact_id='" + contactid.ToString() + "', abonent_id='" + abonentid.ToString() + "' " +
                        "WHERE contact_id=" + contactid_sel.ToString() + " AND abonent_id=" + abonentid_sel.ToString() + "";
                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();

                connection.Close();
                updatePhoneHelpDGV();
            }
        }

        private void delete_phonehelp_button_Click(object sender, EventArgs e)
        {
            var row = phoneHelp_grid.SelectedRows.Count > 0 ? phoneHelp_grid.SelectedRows[0] : null;
            if (row == null)
            {
                MessageBox.Show("Сначала укажите строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var abonentid = row.Cells["abonent_id"].Value.ToString();
            var contactid = row.Cells["contact_id"].Value.ToString();
            var connection = new SqlConnection(connectionString);
            connection.Open();

            var request = @"DELETE Mikolaichuk_Abonent_has_Contact WHERE contact_id=" + contactid.ToString() + " AND abonent_id=" + abonentid.ToString() + "";
            var command = new SqlCommand(request, connection);
            command.ExecuteNonQuery();

            connection.Close();
            updatePhoneHelpDGV();
        }
    }
}
