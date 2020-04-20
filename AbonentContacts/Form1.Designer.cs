namespace AbonentContacts
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.main_tabControl = new System.Windows.Forms.TabControl();
            this.abonent_tab = new System.Windows.Forms.TabPage();
            this.abonent_grid = new System.Windows.Forms.DataGridView();
            this.deleteabonent_button = new System.Windows.Forms.Button();
            this.changeabonent_button = new System.Windows.Forms.Button();
            this.button_add_abonent = new System.Windows.Forms.Button();
            this.contact_tab = new System.Windows.Forms.TabPage();
            this.contact_grid = new System.Windows.Forms.DataGridView();
            this.delete_contact_button = new System.Windows.Forms.Button();
            this.edit_contact_button = new System.Windows.Forms.Button();
            this.add_contact_button = new System.Windows.Forms.Button();
            this.provider_tab = new System.Windows.Forms.TabPage();
            this.add_provider_button = new System.Windows.Forms.Button();
            this.edit_provider_button = new System.Windows.Forms.Button();
            this.delete_provider_button = new System.Windows.Forms.Button();
            this.provider_grid = new System.Windows.Forms.DataGridView();
            this.phoneHelp_tab = new System.Windows.Forms.TabPage();
            this.delete_phonehelp_button = new System.Windows.Forms.Button();
            this.m_edit_fio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_edit_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_phonehelp_button = new System.Windows.Forms.Button();
            this.add_phonehelp_button = new System.Windows.Forms.Button();
            this.phoneHelp_grid = new System.Windows.Forms.DataGridView();
            this.main_tabControl.SuspendLayout();
            this.abonent_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abonent_grid)).BeginInit();
            this.contact_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contact_grid)).BeginInit();
            this.provider_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provider_grid)).BeginInit();
            this.phoneHelp_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneHelp_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // main_tabControl
            // 
            this.main_tabControl.Controls.Add(this.abonent_tab);
            this.main_tabControl.Controls.Add(this.contact_tab);
            this.main_tabControl.Controls.Add(this.provider_tab);
            this.main_tabControl.Controls.Add(this.phoneHelp_tab);
            this.main_tabControl.Location = new System.Drawing.Point(12, 12);
            this.main_tabControl.Name = "main_tabControl";
            this.main_tabControl.SelectedIndex = 0;
            this.main_tabControl.Size = new System.Drawing.Size(722, 435);
            this.main_tabControl.TabIndex = 1;
            // 
            // abonent_tab
            // 
            this.abonent_tab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.abonent_tab.Controls.Add(this.abonent_grid);
            this.abonent_tab.Controls.Add(this.deleteabonent_button);
            this.abonent_tab.Controls.Add(this.changeabonent_button);
            this.abonent_tab.Controls.Add(this.button_add_abonent);
            this.abonent_tab.Location = new System.Drawing.Point(4, 22);
            this.abonent_tab.Name = "abonent_tab";
            this.abonent_tab.Padding = new System.Windows.Forms.Padding(3);
            this.abonent_tab.Size = new System.Drawing.Size(714, 409);
            this.abonent_tab.TabIndex = 0;
            this.abonent_tab.Text = "Абоненты";
            // 
            // abonent_grid
            // 
            this.abonent_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.abonent_grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.abonent_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonent_grid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.abonent_grid.Location = new System.Drawing.Point(0, 0);
            this.abonent_grid.MultiSelect = false;
            this.abonent_grid.Name = "abonent_grid";
            this.abonent_grid.Size = new System.Drawing.Size(712, 377);
            this.abonent_grid.TabIndex = 0;
            // 
            // deleteabonent_button
            // 
            this.deleteabonent_button.Location = new System.Drawing.Point(590, 383);
            this.deleteabonent_button.Name = "deleteabonent_button";
            this.deleteabonent_button.Size = new System.Drawing.Size(121, 23);
            this.deleteabonent_button.TabIndex = 9;
            this.deleteabonent_button.Text = "Удалить абонента";
            this.deleteabonent_button.UseVisualStyleBackColor = true;
            this.deleteabonent_button.Click += new System.EventHandler(this.deleteabonent_button_Click);
            // 
            // changeabonent_button
            // 
            this.changeabonent_button.Location = new System.Drawing.Point(428, 383);
            this.changeabonent_button.Name = "changeabonent_button";
            this.changeabonent_button.Size = new System.Drawing.Size(156, 23);
            this.changeabonent_button.TabIndex = 8;
            this.changeabonent_button.Text = "Редактировать абонента";
            this.changeabonent_button.UseVisualStyleBackColor = true;
            this.changeabonent_button.Click += new System.EventHandler(this.changeabonent_button_Click);
            // 
            // button_add_abonent
            // 
            this.button_add_abonent.Location = new System.Drawing.Point(289, 383);
            this.button_add_abonent.Name = "button_add_abonent";
            this.button_add_abonent.Size = new System.Drawing.Size(133, 23);
            this.button_add_abonent.TabIndex = 7;
            this.button_add_abonent.Text = "Добавить абонента";
            this.button_add_abonent.UseVisualStyleBackColor = true;
            this.button_add_abonent.Click += new System.EventHandler(this.button_add_abonent_Click);
            // 
            // contact_tab
            // 
            this.contact_tab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contact_tab.Controls.Add(this.contact_grid);
            this.contact_tab.Controls.Add(this.delete_contact_button);
            this.contact_tab.Controls.Add(this.edit_contact_button);
            this.contact_tab.Controls.Add(this.add_contact_button);
            this.contact_tab.Location = new System.Drawing.Point(4, 22);
            this.contact_tab.Name = "contact_tab";
            this.contact_tab.Padding = new System.Windows.Forms.Padding(3);
            this.contact_tab.Size = new System.Drawing.Size(714, 409);
            this.contact_tab.TabIndex = 1;
            this.contact_tab.Text = "Контакты";
            // 
            // contact_grid
            // 
            this.contact_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contact_grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contact_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contact_grid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.contact_grid.Location = new System.Drawing.Point(0, 0);
            this.contact_grid.MultiSelect = false;
            this.contact_grid.Name = "contact_grid";
            this.contact_grid.Size = new System.Drawing.Size(712, 377);
            this.contact_grid.TabIndex = 0;
            // 
            // delete_contact_button
            // 
            this.delete_contact_button.Location = new System.Drawing.Point(590, 383);
            this.delete_contact_button.Name = "delete_contact_button";
            this.delete_contact_button.Size = new System.Drawing.Size(121, 23);
            this.delete_contact_button.TabIndex = 12;
            this.delete_contact_button.Text = "Удалить контакт";
            this.delete_contact_button.UseVisualStyleBackColor = true;
            this.delete_contact_button.Click += new System.EventHandler(this.delete_contact_button_Click);
            // 
            // edit_contact_button
            // 
            this.edit_contact_button.Location = new System.Drawing.Point(428, 383);
            this.edit_contact_button.Name = "edit_contact_button";
            this.edit_contact_button.Size = new System.Drawing.Size(156, 23);
            this.edit_contact_button.TabIndex = 11;
            this.edit_contact_button.Text = "Редактировать контакт";
            this.edit_contact_button.UseVisualStyleBackColor = true;
            this.edit_contact_button.Click += new System.EventHandler(this.edit_contact_button_Click);
            // 
            // add_contact_button
            // 
            this.add_contact_button.Location = new System.Drawing.Point(289, 383);
            this.add_contact_button.Name = "add_contact_button";
            this.add_contact_button.Size = new System.Drawing.Size(133, 23);
            this.add_contact_button.TabIndex = 10;
            this.add_contact_button.Text = "Добавить контакт";
            this.add_contact_button.UseVisualStyleBackColor = true;
            this.add_contact_button.Click += new System.EventHandler(this.add_contact_button_Click);
            // 
            // provider_tab
            // 
            this.provider_tab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.provider_tab.Controls.Add(this.add_provider_button);
            this.provider_tab.Controls.Add(this.edit_provider_button);
            this.provider_tab.Controls.Add(this.delete_provider_button);
            this.provider_tab.Controls.Add(this.provider_grid);
            this.provider_tab.Location = new System.Drawing.Point(4, 22);
            this.provider_tab.Name = "provider_tab";
            this.provider_tab.Size = new System.Drawing.Size(714, 409);
            this.provider_tab.TabIndex = 2;
            this.provider_tab.Text = "Провайдеры";
            // 
            // add_provider_button
            // 
            this.add_provider_button.Location = new System.Drawing.Point(289, 383);
            this.add_provider_button.Name = "add_provider_button";
            this.add_provider_button.Size = new System.Drawing.Size(133, 23);
            this.add_provider_button.TabIndex = 13;
            this.add_provider_button.Text = "Добавить провайдера";
            this.add_provider_button.UseVisualStyleBackColor = true;
            this.add_provider_button.Click += new System.EventHandler(this.add_provider_button_Click);
            // 
            // edit_provider_button
            // 
            this.edit_provider_button.Location = new System.Drawing.Point(428, 383);
            this.edit_provider_button.Name = "edit_provider_button";
            this.edit_provider_button.Size = new System.Drawing.Size(156, 23);
            this.edit_provider_button.TabIndex = 14;
            this.edit_provider_button.Text = "Редактировать провайдера";
            this.edit_provider_button.UseVisualStyleBackColor = true;
            this.edit_provider_button.Click += new System.EventHandler(this.edit_provider_button_Click);
            // 
            // delete_provider_button
            // 
            this.delete_provider_button.Location = new System.Drawing.Point(590, 383);
            this.delete_provider_button.Name = "delete_provider_button";
            this.delete_provider_button.Size = new System.Drawing.Size(121, 23);
            this.delete_provider_button.TabIndex = 15;
            this.delete_provider_button.Text = "Удалить провайдера";
            this.delete_provider_button.UseVisualStyleBackColor = true;
            this.delete_provider_button.Click += new System.EventHandler(this.delete_provider_button_Click);
            // 
            // provider_grid
            // 
            this.provider_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.provider_grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.provider_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provider_grid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.provider_grid.Location = new System.Drawing.Point(0, 0);
            this.provider_grid.MultiSelect = false;
            this.provider_grid.Name = "provider_grid";
            this.provider_grid.Size = new System.Drawing.Size(711, 377);
            this.provider_grid.TabIndex = 0;
            // 
            // phoneHelp_tab
            // 
            this.phoneHelp_tab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.phoneHelp_tab.Controls.Add(this.delete_phonehelp_button);
            this.phoneHelp_tab.Controls.Add(this.m_edit_fio);
            this.phoneHelp_tab.Controls.Add(this.label2);
            this.phoneHelp_tab.Controls.Add(this.m_edit_phone);
            this.phoneHelp_tab.Controls.Add(this.label1);
            this.phoneHelp_tab.Controls.Add(this.edit_phonehelp_button);
            this.phoneHelp_tab.Controls.Add(this.add_phonehelp_button);
            this.phoneHelp_tab.Controls.Add(this.phoneHelp_grid);
            this.phoneHelp_tab.Location = new System.Drawing.Point(4, 22);
            this.phoneHelp_tab.Name = "phoneHelp_tab";
            this.phoneHelp_tab.Size = new System.Drawing.Size(714, 409);
            this.phoneHelp_tab.TabIndex = 3;
            this.phoneHelp_tab.Text = "Тел. справочник";
            // 
            // delete_phonehelp_button
            // 
            this.delete_phonehelp_button.Location = new System.Drawing.Point(604, 383);
            this.delete_phonehelp_button.Name = "delete_phonehelp_button";
            this.delete_phonehelp_button.Size = new System.Drawing.Size(107, 23);
            this.delete_phonehelp_button.TabIndex = 9;
            this.delete_phonehelp_button.Text = "Удалить запись";
            this.delete_phonehelp_button.UseVisualStyleBackColor = true;
            this.delete_phonehelp_button.Click += new System.EventHandler(this.delete_phonehelp_button_Click);
            // 
            // m_edit_fio
            // 
            this.m_edit_fio.Location = new System.Drawing.Point(248, 385);
            this.m_edit_fio.Name = "m_edit_fio";
            this.m_edit_fio.Size = new System.Drawing.Size(100, 20);
            this.m_edit_fio.TabIndex = 4;
            this.m_edit_fio.TextChanged += new System.EventHandler(this.m_edit_fio_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ФИО";
            // 
            // m_edit_phone
            // 
            this.m_edit_phone.Location = new System.Drawing.Point(102, 385);
            this.m_edit_phone.Name = "m_edit_phone";
            this.m_edit_phone.Size = new System.Drawing.Size(100, 20);
            this.m_edit_phone.TabIndex = 3;
            this.m_edit_phone.TextChanged += new System.EventHandler(this.m_edit_phone_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер телефона";
            // 
            // edit_phonehelp_button
            // 
            this.edit_phonehelp_button.Location = new System.Drawing.Point(467, 383);
            this.edit_phonehelp_button.Name = "edit_phonehelp_button";
            this.edit_phonehelp_button.Size = new System.Drawing.Size(131, 23);
            this.edit_phonehelp_button.TabIndex = 8;
            this.edit_phonehelp_button.Text = "Редактировать запись";
            this.edit_phonehelp_button.UseVisualStyleBackColor = true;
            this.edit_phonehelp_button.Click += new System.EventHandler(this.edit_phonehelp_button_Click);
            // 
            // add_phonehelp_button
            // 
            this.add_phonehelp_button.Location = new System.Drawing.Point(354, 383);
            this.add_phonehelp_button.Name = "add_phonehelp_button";
            this.add_phonehelp_button.Size = new System.Drawing.Size(107, 23);
            this.add_phonehelp_button.TabIndex = 7;
            this.add_phonehelp_button.Text = "Добавить запись";
            this.add_phonehelp_button.UseVisualStyleBackColor = true;
            this.add_phonehelp_button.Click += new System.EventHandler(this.add_phonehelp_button_Click);
            // 
            // phoneHelp_grid
            // 
            this.phoneHelp_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phoneHelp_grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phoneHelp_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneHelp_grid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.phoneHelp_grid.Location = new System.Drawing.Point(0, 0);
            this.phoneHelp_grid.MultiSelect = false;
            this.phoneHelp_grid.Name = "phoneHelp_grid";
            this.phoneHelp_grid.Size = new System.Drawing.Size(711, 377);
            this.phoneHelp_grid.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(740, 448);
            this.Controls.Add(this.main_tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Телефонный справочник";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_tabControl.ResumeLayout(false);
            this.abonent_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.abonent_grid)).EndInit();
            this.contact_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contact_grid)).EndInit();
            this.provider_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.provider_grid)).EndInit();
            this.phoneHelp_tab.ResumeLayout(false);
            this.phoneHelp_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneHelp_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl main_tabControl;
        private System.Windows.Forms.TabPage abonent_tab;
        private System.Windows.Forms.TabPage contact_tab;
        private System.Windows.Forms.TabPage provider_tab;
        private System.Windows.Forms.TabPage phoneHelp_tab;
        private System.Windows.Forms.DataGridView abonent_grid;
        private System.Windows.Forms.DataGridView contact_grid;
        private System.Windows.Forms.DataGridView provider_grid;
        private System.Windows.Forms.DataGridView phoneHelp_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_edit_phone;
        private System.Windows.Forms.TextBox m_edit_fio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_add_abonent;
        private System.Windows.Forms.Button changeabonent_button;
        private System.Windows.Forms.Button deleteabonent_button;
        private System.Windows.Forms.Button add_contact_button;
        private System.Windows.Forms.Button edit_contact_button;
        private System.Windows.Forms.Button delete_contact_button;
        private System.Windows.Forms.Button add_provider_button;
        private System.Windows.Forms.Button edit_provider_button;
        private System.Windows.Forms.Button delete_provider_button;
        private System.Windows.Forms.Button delete_phonehelp_button;
        private System.Windows.Forms.Button edit_phonehelp_button;
        private System.Windows.Forms.Button add_phonehelp_button;
    }
}

