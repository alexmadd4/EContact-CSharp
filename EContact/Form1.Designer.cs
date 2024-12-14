namespace EContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtboxContactID = new TextBox();
            txtboxFirstName = new TextBox();
            txtboxLastName = new TextBox();
            txtboxContactNo = new TextBox();
            txtboxAddress = new TextBox();
            cmbGender = new ComboBox();
            label7 = new Label();
            txtboxSearch = new TextBox();
            dgvContactList = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvContactList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(48, 98);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 0;
            label1.Text = "Contact ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(48, 168);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(50, 220);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(50, 275);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 3;
            label4.Text = "Contact Nr.";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(48, 330);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 4;
            label5.Text = "Address";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(50, 422);
            label6.Name = "label6";
            label6.Size = new Size(79, 28);
            label6.TabIndex = 5;
            label6.Text = "Gender";
            // 
            // txtboxContactID
            // 
            txtboxContactID.Location = new Point(170, 98);
            txtboxContactID.Name = "txtboxContactID";
            txtboxContactID.ReadOnly = true;
            txtboxContactID.Size = new Size(277, 27);
            txtboxContactID.TabIndex = 6;
            // 
            // txtboxFirstName
            // 
            txtboxFirstName.Location = new Point(170, 168);
            txtboxFirstName.Name = "txtboxFirstName";
            txtboxFirstName.Size = new Size(277, 27);
            txtboxFirstName.TabIndex = 7;
            // 
            // txtboxLastName
            // 
            txtboxLastName.Location = new Point(170, 224);
            txtboxLastName.Name = "txtboxLastName";
            txtboxLastName.Size = new Size(277, 27);
            txtboxLastName.TabIndex = 8;
            // 
            // txtboxContactNo
            // 
            txtboxContactNo.Location = new Point(170, 276);
            txtboxContactNo.Name = "txtboxContactNo";
            txtboxContactNo.Size = new Size(277, 27);
            txtboxContactNo.TabIndex = 9;
            // 
            // txtboxAddress
            // 
            txtboxAddress.Location = new Point(170, 334);
            txtboxAddress.Name = "txtboxAddress";
            txtboxAddress.Size = new Size(277, 27);
            txtboxAddress.TabIndex = 10;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(170, 422);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(277, 28);
            cmbGender.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(527, 98);
            label7.Name = "label7";
            label7.Size = new Size(72, 28);
            label7.TabIndex = 12;
            label7.Text = "Search";
            // 
            // txtboxSearch
            // 
            txtboxSearch.Location = new Point(605, 102);
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.Size = new Size(719, 27);
            txtboxSearch.TabIndex = 13;
            txtboxSearch.TextChanged += txtboxSearch_TextChanged;
            // 
            // dgvContactList
            // 
            dgvContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactList.Location = new Point(529, 135);
            dgvContactList.Name = "dgvContactList";
            dgvContactList.RowHeadersWidth = 51;
            dgvContactList.Size = new Size(795, 627);
            dgvContactList.TabIndex = 14;
            dgvContactList.RowHeaderMouseClick += dgvContactList_RowHeaderMouseClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.GreenYellow;
            btnAdd.Location = new Point(35, 630);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 58);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumAquamarine;
            btnUpdate.Location = new Point(157, 630);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 58);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(278, 630);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 58);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkSalmon;
            btnClear.Location = new Point(396, 630);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 58);
            btnClear.TabIndex = 18;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(447, -15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1336, 774);
            Controls.Add(pictureBox1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvContactList);
            Controls.Add(txtboxSearch);
            Controls.Add(label7);
            Controls.Add(cmbGender);
            Controls.Add(txtboxAddress);
            Controls.Add(txtboxContactNo);
            Controls.Add(txtboxLastName);
            Controls.Add(txtboxFirstName);
            Controls.Add(txtboxContactID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E-Contact";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContactList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtboxContactID;
        private TextBox txtboxFirstName;
        private TextBox txtboxLastName;
        private TextBox txtboxContactNo;
        private TextBox txtboxAddress;
        private ComboBox cmbGender;
        private Label label7;
        private TextBox txtboxSearch;
        private DataGridView dgvContactList;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private PictureBox pictureBox1;
    }
}
