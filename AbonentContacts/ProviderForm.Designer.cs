namespace AbonentContacts
{
    partial class ProviderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProviderForm));
            this.name_provider_textbox = new System.Windows.Forms.TextBox();
            this.score_provider_textbox = new System.Windows.Forms.TextBox();
            this.okey_provider_button = new System.Windows.Forms.Button();
            this.cancel_provider_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_provider_textbox
            // 
            this.name_provider_textbox.Location = new System.Drawing.Point(13, 13);
            this.name_provider_textbox.Name = "name_provider_textbox";
            this.name_provider_textbox.Size = new System.Drawing.Size(100, 20);
            this.name_provider_textbox.TabIndex = 0;
            // 
            // score_provider_textbox
            // 
            this.score_provider_textbox.Location = new System.Drawing.Point(13, 40);
            this.score_provider_textbox.Name = "score_provider_textbox";
            this.score_provider_textbox.Size = new System.Drawing.Size(100, 20);
            this.score_provider_textbox.TabIndex = 1;
            // 
            // okey_provider_button
            // 
            this.okey_provider_button.Location = new System.Drawing.Point(13, 76);
            this.okey_provider_button.Name = "okey_provider_button";
            this.okey_provider_button.Size = new System.Drawing.Size(75, 23);
            this.okey_provider_button.TabIndex = 2;
            this.okey_provider_button.Text = "ОК";
            this.okey_provider_button.UseVisualStyleBackColor = true;
            this.okey_provider_button.Click += new System.EventHandler(this.okey_provider_button_Click);
            // 
            // cancel_provider_button
            // 
            this.cancel_provider_button.Location = new System.Drawing.Point(122, 76);
            this.cancel_provider_button.Name = "cancel_provider_button";
            this.cancel_provider_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_provider_button.TabIndex = 3;
            this.cancel_provider_button.Text = "Отмена";
            this.cancel_provider_button.UseVisualStyleBackColor = true;
            this.cancel_provider_button.Click += new System.EventHandler(this.cancel_provider_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Рейтинг";
            // 
            // ProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 109);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_provider_button);
            this.Controls.Add(this.okey_provider_button);
            this.Controls.Add(this.score_provider_textbox);
            this.Controls.Add(this.name_provider_textbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProviderForm";
            this.Text = "Провайдер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox name_provider_textbox;
        public System.Windows.Forms.TextBox score_provider_textbox;
        private System.Windows.Forms.Button okey_provider_button;
        private System.Windows.Forms.Button cancel_provider_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}