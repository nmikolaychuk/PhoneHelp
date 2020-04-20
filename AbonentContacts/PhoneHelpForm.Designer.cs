namespace AbonentContacts
{
    partial class PhoneHelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneHelpForm));
            this.add_phonehelp_abonent_combobox = new System.Windows.Forms.ComboBox();
            this.add_phonehelp_phone_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_phonehelp_okey_button = new System.Windows.Forms.Button();
            this.add_phonehelp_cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_phonehelp_abonent_combobox
            // 
            this.add_phonehelp_abonent_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.add_phonehelp_abonent_combobox.FormattingEnabled = true;
            this.add_phonehelp_abonent_combobox.Location = new System.Drawing.Point(13, 13);
            this.add_phonehelp_abonent_combobox.Name = "add_phonehelp_abonent_combobox";
            this.add_phonehelp_abonent_combobox.Size = new System.Drawing.Size(173, 21);
            this.add_phonehelp_abonent_combobox.TabIndex = 0;
            // 
            // add_phonehelp_phone_combobox
            // 
            this.add_phonehelp_phone_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.add_phonehelp_phone_combobox.FormattingEnabled = true;
            this.add_phonehelp_phone_combobox.Location = new System.Drawing.Point(13, 41);
            this.add_phonehelp_phone_combobox.Name = "add_phonehelp_phone_combobox";
            this.add_phonehelp_phone_combobox.Size = new System.Drawing.Size(173, 21);
            this.add_phonehelp_phone_combobox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Человек";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Телефон";
            // 
            // add_phonehelp_okey_button
            // 
            this.add_phonehelp_okey_button.Location = new System.Drawing.Point(49, 80);
            this.add_phonehelp_okey_button.Name = "add_phonehelp_okey_button";
            this.add_phonehelp_okey_button.Size = new System.Drawing.Size(75, 23);
            this.add_phonehelp_okey_button.TabIndex = 4;
            this.add_phonehelp_okey_button.Text = "OK";
            this.add_phonehelp_okey_button.UseVisualStyleBackColor = true;
            this.add_phonehelp_okey_button.Click += new System.EventHandler(this.add_phonehelp_okey_button_Click);
            // 
            // add_phonehelp_cancel_button
            // 
            this.add_phonehelp_cancel_button.Location = new System.Drawing.Point(142, 80);
            this.add_phonehelp_cancel_button.Name = "add_phonehelp_cancel_button";
            this.add_phonehelp_cancel_button.Size = new System.Drawing.Size(75, 23);
            this.add_phonehelp_cancel_button.TabIndex = 5;
            this.add_phonehelp_cancel_button.Text = "Отмена";
            this.add_phonehelp_cancel_button.UseVisualStyleBackColor = true;
            this.add_phonehelp_cancel_button.Click += new System.EventHandler(this.add_phonehelp_cancel_button_Click);
            // 
            // PhoneHelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 110);
            this.Controls.Add(this.add_phonehelp_cancel_button);
            this.Controls.Add(this.add_phonehelp_okey_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_phonehelp_phone_combobox);
            this.Controls.Add(this.add_phonehelp_abonent_combobox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhoneHelpForm";
            this.Text = "Справочник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox add_phonehelp_abonent_combobox;
        public System.Windows.Forms.ComboBox add_phonehelp_phone_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_phonehelp_okey_button;
        private System.Windows.Forms.Button add_phonehelp_cancel_button;
    }
}