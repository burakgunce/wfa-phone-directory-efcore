namespace WFATelefonRehberi
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
            groupbox1 = new GroupBox();
            btnAdd = new Button();
            mtxtPhone = new MaskedTextBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupbox1
            // 
            groupbox1.Controls.Add(btnAdd);
            groupbox1.Controls.Add(mtxtPhone);
            groupbox1.Controls.Add(txtSurname);
            groupbox1.Controls.Add(txtName);
            groupbox1.Controls.Add(label3);
            groupbox1.Controls.Add(label2);
            groupbox1.Controls.Add(label1);
            groupbox1.Location = new Point(23, 27);
            groupbox1.Name = "groupbox1";
            groupbox1.Size = new Size(291, 230);
            groupbox1.TabIndex = 0;
            groupbox1.TabStop = false;
            groupbox1.Text = "Kişi Ekleme Paneli";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(110, 174);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(163, 48);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Rehbere Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(110, 127);
            mtxtPhone.Mask = "(999) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(165, 27);
            mtxtPhone.TabIndex = 5;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(110, 79);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(165, 27);
            txtSurname.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(110, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(165, 27);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 128);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 82);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 39);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 27);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 1;
            label4.Text = "Aranacak Ad Veya Soyad";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(336, 60);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(173, 27);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(336, 108);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(174, 42);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Kişi Ara";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(336, 201);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(174, 48);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 275);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(487, 153);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(groupbox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupbox1.ResumeLayout(false);
            groupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupbox1;
        private Button btnAdd;
        private MaskedTextBox mtxtPhone;
        private TextBox txtSurname;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnUpdate;
        private DataGridView dataGridView1;
    }
}