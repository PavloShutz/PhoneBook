namespace Phone_Book
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            panelCategory = new Panel();
            label6 = new Label();
            textBoxEmail = new TextBox();
            label5 = new Label();
            textBoxAddress = new TextBox();
            comboBoxCategory = new ComboBox();
            categoryBindingSource = new BindingSource(components);
            textBoxNumber = new TextBox();
            textBoxName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridViewCallers = new DataGridView();
            CallerId = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            callersBindingSource = new BindingSource(components);
            buttonAddCaller = new Button();
            panel1 = new Panel();
            panelCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCallers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)callersBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelCategory
            // 
            panelCategory.Controls.Add(label6);
            panelCategory.Controls.Add(textBoxEmail);
            panelCategory.Controls.Add(label5);
            panelCategory.Controls.Add(textBoxAddress);
            panelCategory.Controls.Add(comboBoxCategory);
            panelCategory.Controls.Add(textBoxNumber);
            panelCategory.Controls.Add(textBoxName);
            panelCategory.Controls.Add(label4);
            panelCategory.Controls.Add(label3);
            panelCategory.Controls.Add(label2);
            panelCategory.Controls.Add(label1);
            panelCategory.Dock = DockStyle.Right;
            panelCategory.Location = new Point(1171, 0);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(207, 588);
            panelCategory.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 297);
            label6.Name = "label6";
            label6.Size = new Size(158, 20);
            label6.TabIndex = 12;
            label6.Text = "Електронна скринька";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(3, 320);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(189, 27);
            textBoxEmail.TabIndex = 11;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 223);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 10;
            label5.Text = "Адреса проживання";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(3, 246);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(192, 27);
            textBoxAddress.TabIndex = 9;
            textBoxAddress.TextChanged += textBoxAddress_TextChanged;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DataSource = categoryBindingSource;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.FlatStyle = FlatStyle.System;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(3, 392);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(192, 28);
            comboBoxCategory.TabIndex = 8;
            comboBoxCategory.ValueMember = "CategoryId";
            comboBoxCategory.SelectionChangeCommitted += comboBoxCategory_SelectionChangeCommitted;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Category);
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(3, 175);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(192, 27);
            textBoxNumber.TabIndex = 5;
            textBoxNumber.TextChanged += textBoxNumber_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(3, 107);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(192, 27);
            textBoxName.TabIndex = 4;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 369);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 3;
            label4.Text = "Категорія";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 152);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 84);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "Ім'я";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Здійснити пошук";
            // 
            // dataGridViewCallers
            // 
            dataGridViewCallers.AutoGenerateColumns = false;
            dataGridViewCallers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCallers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCallers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCallers.Columns.AddRange(new DataGridViewColumn[] { CallerId, nameDataGridViewTextBoxColumn, numberDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn });
            dataGridViewCallers.DataSource = callersBindingSource;
            dataGridViewCallers.Dock = DockStyle.Fill;
            dataGridViewCallers.Location = new Point(207, 0);
            dataGridViewCallers.Name = "dataGridViewCallers";
            dataGridViewCallers.RowHeadersWidth = 51;
            dataGridViewCallers.Size = new Size(964, 588);
            dataGridViewCallers.TabIndex = 1;
            dataGridViewCallers.ColumnHeaderMouseClick += dataGridViewCallers_ColumnHeaderMouseClick;
            dataGridViewCallers.DataBindingComplete += dataGridViewCallers_DataBindingComplete;
            // 
            // CallerId
            // 
            CallerId.DataPropertyName = "CallerId";
            CallerId.HeaderText = "Column1";
            CallerId.MinimumWidth = 6;
            CallerId.Name = "CallerId";
            CallerId.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Ім'я";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            numberDataGridViewTextBoxColumn.HeaderText = "Номер";
            numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Електронна скринька";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Адреса проживання";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // callersBindingSource
            // 
            callersBindingSource.DataMember = "Callers";
            callersBindingSource.DataSource = categoryBindingSource;
            // 
            // buttonAddCaller
            // 
            buttonAddCaller.Font = new Font("Segoe UI", 20F);
            buttonAddCaller.Location = new Point(60, 62);
            buttonAddCaller.Name = "buttonAddCaller";
            buttonAddCaller.Size = new Size(80, 80);
            buttonAddCaller.TabIndex = 2;
            buttonAddCaller.Text = "+";
            buttonAddCaller.UseVisualStyleBackColor = true;
            buttonAddCaller.Click += buttonAddCaller_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonAddCaller);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 588);
            panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 588);
            Controls.Add(dataGridViewCallers);
            Controls.Add(panelCategory);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Адресна книга";
            Load += MainForm_Load;
            panelCategory.ResumeLayout(false);
            panelCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCallers).EndInit();
            ((System.ComponentModel.ISupportInitialize)callersBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelCategory;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxNumber;
        private ComboBox comboBoxCategory;
        private BindingSource categoryBindingSource;
        private BindingSource callersBindingSource;
        private DataGridViewTextBoxColumn CallerId;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private Button buttonAddCaller;
        private Panel panel1;
        public DataGridView dataGridViewCallers;
        private Label label5;
        private TextBox textBoxAddress;
        private Label label6;
        private TextBox textBoxEmail;
    }
}
