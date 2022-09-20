namespace currency_converter
{
    partial class mainwindow
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
            this.components = new System.ComponentModel.Container();
            this.from_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.to_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.to_comboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.from_comboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amount_label = new System.Windows.Forms.Label();
            this.converted_label = new System.Windows.Forms.Label();
            this.convert_button = new Guna.UI2.WinForms.Guna2Button();
            this.reset_button = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // from_textbox
            // 
            this.from_textbox.Animated = true;
            this.from_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.from_textbox.BorderColor = System.Drawing.Color.Navy;
            this.from_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.from_textbox.DefaultText = "";
            this.from_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.from_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.from_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.from_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.from_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.from_textbox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_textbox.ForeColor = System.Drawing.Color.Black;
            this.from_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.from_textbox.Location = new System.Drawing.Point(109, 101);
            this.from_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.from_textbox.Name = "from_textbox";
            this.from_textbox.PasswordChar = '\0';
            this.from_textbox.PlaceholderText = "";
            this.from_textbox.SelectedText = "";
            this.from_textbox.Size = new System.Drawing.Size(168, 46);
            this.from_textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.from_textbox.TabIndex = 0;
            // 
            // to_textbox
            // 
            this.to_textbox.Animated = true;
            this.to_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.to_textbox.BorderColor = System.Drawing.Color.Navy;
            this.to_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.to_textbox.DefaultText = "";
            this.to_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.to_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.to_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.to_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.to_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.to_textbox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_textbox.ForeColor = System.Drawing.Color.Black;
            this.to_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.to_textbox.Location = new System.Drawing.Point(109, 178);
            this.to_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.to_textbox.Name = "to_textbox";
            this.to_textbox.PasswordChar = '\0';
            this.to_textbox.PlaceholderText = "";
            this.to_textbox.ReadOnly = true;
            this.to_textbox.SelectedText = "";
            this.to_textbox.Size = new System.Drawing.Size(168, 46);
            this.to_textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.to_textbox.TabIndex = 1;
            // 
            // to_comboBox
            // 
            this.to_comboBox.BackColor = System.Drawing.Color.Transparent;
            this.to_comboBox.BorderColor = System.Drawing.Color.DodgerBlue;
            this.to_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.to_comboBox.DropDownHeight = 200;
            this.to_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.to_comboBox.DropDownWidth = 50;
            this.to_comboBox.FillColor = System.Drawing.Color.DodgerBlue;
            this.to_comboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.to_comboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.to_comboBox.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.to_comboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_comboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.to_comboBox.ItemHeight = 51;
            this.to_comboBox.Location = new System.Drawing.Point(282, 178);
            this.to_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.to_comboBox.MaxDropDownItems = 20;
            this.to_comboBox.Name = "to_comboBox";
            this.to_comboBox.Size = new System.Drawing.Size(85, 57);
            this.to_comboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.to_comboBox.TabIndex = 2;
            // 
            // from_comboBox
            // 
            this.from_comboBox.BackColor = System.Drawing.Color.Transparent;
            this.from_comboBox.BorderColor = System.Drawing.Color.DodgerBlue;
            this.from_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.from_comboBox.DropDownHeight = 200;
            this.from_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.from_comboBox.DropDownWidth = 50;
            this.from_comboBox.FillColor = System.Drawing.Color.DodgerBlue;
            this.from_comboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.from_comboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.from_comboBox.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.from_comboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_comboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.from_comboBox.FormattingEnabled = true;
            this.from_comboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.from_comboBox.ItemHeight = 51;
            this.from_comboBox.Location = new System.Drawing.Point(282, 101);
            this.from_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.from_comboBox.MaxDropDownItems = 20;
            this.from_comboBox.Name = "from_comboBox";
            this.from_comboBox.Size = new System.Drawing.Size(85, 57);
            this.from_comboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.from_comboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Currency Converter";
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_label.Location = new System.Drawing.Point(106, 82);
            this.amount_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(59, 19);
            this.amount_label.TabIndex = 5;
            this.amount_label.Text = "Amount";
            // 
            // converted_label
            // 
            this.converted_label.AutoSize = true;
            this.converted_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.converted_label.Location = new System.Drawing.Point(106, 159);
            this.converted_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.converted_label.Name = "converted_label";
            this.converted_label.Size = new System.Drawing.Size(90, 19);
            this.converted_label.TabIndex = 6;
            this.converted_label.Text = "Converted to";
            // 
            // convert_button
            // 
            this.convert_button.BorderColor = System.Drawing.Color.Navy;
            this.convert_button.BorderRadius = 8;
            this.convert_button.BorderThickness = 2;
            this.convert_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.convert_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.convert_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.convert_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.convert_button.FillColor = System.Drawing.Color.Gainsboro;
            this.convert_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_button.ForeColor = System.Drawing.Color.Navy;
            this.convert_button.Location = new System.Drawing.Point(107, 258);
            this.convert_button.Margin = new System.Windows.Forms.Padding(2);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(102, 31);
            this.convert_button.TabIndex = 7;
            this.convert_button.Text = "Convert";
            this.convert_button.Click += new System.EventHandler(this.convert_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.BorderColor = System.Drawing.Color.Navy;
            this.reset_button.BorderRadius = 8;
            this.reset_button.BorderThickness = 2;
            this.reset_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reset_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reset_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reset_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reset_button.FillColor = System.Drawing.Color.Gainsboro;
            this.reset_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.ForeColor = System.Drawing.Color.Navy;
            this.reset_button.Location = new System.Drawing.Point(248, 258);
            this.reset_button.Margin = new System.Windows.Forms.Padding(2);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(102, 31);
            this.reset_button.TabIndex = 8;
            this.reset_button.Text = "Reset";
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(458, 326);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.convert_button);
            this.Controls.Add(this.converted_label);
            this.Controls.Add(this.amount_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.from_comboBox);
            this.Controls.Add(this.to_comboBox);
            this.Controls.Add(this.to_textbox);
            this.Controls.Add(this.from_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "mainwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox from_textbox;
        private Guna.UI2.WinForms.Guna2TextBox to_textbox;
        private Guna.UI2.WinForms.Guna2ComboBox to_comboBox;
        private Guna.UI2.WinForms.Guna2ComboBox from_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.Label converted_label;
        private Guna.UI2.WinForms.Guna2Button convert_button;
        private Guna.UI2.WinForms.Guna2Button reset_button;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

