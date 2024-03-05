namespace WinFormsApp24
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label4 = new Label();
            button1 = new Button();
            lblDrinks = new Label();
            label6 = new Label();
            lblDish = new Label();
            label3 = new Label();
            label2 = new Label();
            cboDrinks = new ComboBox();
            label1 = new Label();
            cboDishes = new ComboBox();
            panel2 = new Panel();
            button2 = new Button();
            txtCash = new TextBox();
            label7 = new Label();
            lblTax = new Label();
            label9 = new Label();
            lblTotal = new Label();
            label5 = new Label();
            label8 = new Label();
            lblChange = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblDrinks);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblDish);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboDrinks);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboDishes);
            panel1.Location = new Point(36, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 413);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(82, 15);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 9;
            label4.Text = "MENU";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(25, 327);
            button1.Name = "button1";
            button1.Size = new Size(187, 29);
            button1.TabIndex = 8;
            button1.Text = "VOID";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblDrinks
            // 
            lblDrinks.AutoSize = true;
            lblDrinks.Location = new Point(185, 203);
            lblDrinks.Name = "lblDrinks";
            lblDrinks.Size = new Size(27, 20);
            lblDrinks.TabIndex = 7;
            lblDrinks.Text = "---";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 203);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 6;
            label6.Text = "Price";
            // 
            // lblDish
            // 
            lblDish.AutoSize = true;
            lblDish.Location = new Point(186, 81);
            lblDish.Name = "lblDish";
            lblDish.Size = new Size(27, 20);
            lblDish.TabIndex = 5;
            lblDish.Text = "---";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 81);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(22, 166);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 3;
            label2.Text = "DRINKS";
            // 
            // cboDrinks
            // 
            cboDrinks.FormattingEnabled = true;
            cboDrinks.Items.AddRange(new object[] { "RED HORSE", "TANDUAY", "SOJU", "GIN" });
            cboDrinks.Location = new Point(27, 236);
            cboDrinks.Name = "cboDrinks";
            cboDrinks.Size = new Size(186, 28);
            cboDrinks.TabIndex = 2;
            cboDrinks.SelectedIndexChanged += cboDrinks_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(22, 43);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 1;
            label1.Text = "DISHES";
            // 
            // cboDishes
            // 
            cboDishes.FormattingEnabled = true;
            cboDishes.Items.AddRange(new object[] { "CALDERETA", "SISIG", "ASADO", "MENUDO", "PANDESAL", "ANCHOVY" });
            cboDishes.Location = new Point(27, 114);
            cboDishes.Name = "cboDishes";
            cboDishes.Size = new Size(187, 28);
            cboDishes.TabIndex = 0;
            cboDishes.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblChange);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(txtCash);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lblTax);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(341, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 413);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Enabled = false;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(27, 327);
            button2.Name = "button2";
            button2.Size = new Size(187, 29);
            button2.TabIndex = 10;
            button2.Text = "PURCHASE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtCash
            // 
            txtCash.BorderStyle = BorderStyle.FixedSingle;
            txtCash.Location = new Point(27, 236);
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(185, 27);
            txtCash.TabIndex = 15;
            txtCash.TextChanged += txtCash_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.Location = new Point(26, 166);
            label7.Name = "label7";
            label7.Size = new Size(97, 25);
            label7.TabIndex = 14;
            label7.Text = "PAYMENT";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(185, 122);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(27, 20);
            lblTax.TabIndex = 13;
            lblTax.Text = "---";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(26, 122);
            label9.Name = "label9";
            label9.Size = new Size(33, 20);
            label9.TabIndex = 12;
            label9.Text = "Tax";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(185, 81);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(27, 20);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "---";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(87, 15);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 10;
            label5.Text = "RECEIPT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(26, 81);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 10;
            label8.Text = "Total";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(186, 283);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(27, 20);
            lblChange.TabIndex = 17;
            lblChange.Text = "---";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(27, 283);
            label11.Name = "label11";
            label11.Size = new Size(61, 20);
            label11.TabIndex = 16;
            label11.Text = "Change";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Basic Ordering System";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ComboBox cboDishes;
        private Label label1;
        private Label label2;
        private ComboBox cboDrinks;
        private Label lblDrinks;
        private Label label6;
        private Label lblDish;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label lblTotal;
        private Label label5;
        private Label label8;
        private Label lblTax;
        private Label label9;
        private Label label7;
        private Button button2;
        private TextBox txtCash;
        private Label lblChange;
        private Label label11;
    }
}
