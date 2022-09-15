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
            this.from_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.to_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.to_comboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.from_comboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amount_label = new System.Windows.Forms.Label();
            this.converted_label = new System.Windows.Forms.Label();
            this.convert_button = new Guna.UI2.WinForms.Guna2Button();
            this.reset_button = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
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
            this.from_textbox.Location = new System.Drawing.Point(136, 126);
            this.from_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.from_textbox.Name = "from_textbox";
            this.from_textbox.PasswordChar = '\0';
            this.from_textbox.PlaceholderText = "";
            this.from_textbox.SelectedText = "";
            this.from_textbox.Size = new System.Drawing.Size(210, 58);
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
            this.to_textbox.Location = new System.Drawing.Point(136, 222);
            this.to_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.to_textbox.Name = "to_textbox";
            this.to_textbox.PasswordChar = '\0';
            this.to_textbox.PlaceholderText = "";
            this.to_textbox.ReadOnly = true;
            this.to_textbox.SelectedText = "";
            this.to_textbox.Size = new System.Drawing.Size(210, 58);
            this.to_textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.to_textbox.TabIndex = 1;
            // 
            // to_comboBox
            // 
            this.to_comboBox.BackColor = System.Drawing.Color.Transparent;
            this.to_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.to_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.to_comboBox.FillColor = System.Drawing.Color.DodgerBlue;
            this.to_comboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.to_comboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.to_comboBox.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.to_comboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.to_comboBox.ForeColor = System.Drawing.Color.White;
            this.to_comboBox.ItemHeight = 51;
            this.to_comboBox.Items.AddRange(new object[] {
            "USD",
            "INR",
            "EUR"});
            this.to_comboBox.Location = new System.Drawing.Point(352, 222);
            this.to_comboBox.MaxDropDownItems = 10;
            this.to_comboBox.Name = "to_comboBox";
            this.to_comboBox.Size = new System.Drawing.Size(88, 57);
            this.to_comboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.to_comboBox.TabIndex = 2;
            // 
            // from_comboBox
            // 
            this.from_comboBox.BackColor = System.Drawing.Color.Transparent;
            this.from_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.from_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.from_comboBox.FillColor = System.Drawing.Color.DodgerBlue;
            this.from_comboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.from_comboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.from_comboBox.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.from_comboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.from_comboBox.ForeColor = System.Drawing.Color.White;
            this.from_comboBox.FormattingEnabled = true;
            this.from_comboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.from_comboBox.ItemHeight = 51;
            this.from_comboBox.Items.AddRange(new object[] {
            "USD",
            "INR",
            "EUR"});
            this.from_comboBox.Location = new System.Drawing.Point(352, 126);
            this.from_comboBox.MaxDropDownItems = 10;
            this.from_comboBox.Name = "from_comboBox";
            this.from_comboBox.Size = new System.Drawing.Size(88, 57);
            this.from_comboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.from_comboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Currency Converter";
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_label.Location = new System.Drawing.Point(132, 103);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(72, 23);
            this.amount_label.TabIndex = 5;
            this.amount_label.Text = "Amount";
            this.amount_label.Click += new System.EventHandler(this.amount_label_Click);
            // 
            // converted_label
            // 
            this.converted_label.AutoSize = true;
            this.converted_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.converted_label.Location = new System.Drawing.Point(132, 199);
            this.converted_label.Name = "converted_label";
            this.converted_label.Size = new System.Drawing.Size(110, 23);
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
            this.convert_button.Location = new System.Drawing.Point(134, 323);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(128, 39);
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
            this.reset_button.Location = new System.Drawing.Point(310, 323);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(128, 39);
            this.reset_button.TabIndex = 8;
            this.reset_button.Text = "Reset";
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.Navy;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Navy;
            this.guna2Button1.Location = new System.Drawing.Point(136, 323);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(128, 39);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Convert";
            this.guna2Button1.Click += new System.EventHandler(this.convert_button_Click);
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(572, 408);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.convert_button);
            this.Controls.Add(this.converted_label);
            this.Controls.Add(this.amount_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.from_comboBox);
            this.Controls.Add(this.to_comboBox);
            this.Controls.Add(this.to_textbox);
            this.Controls.Add(this.from_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
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
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

