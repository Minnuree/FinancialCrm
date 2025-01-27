namespace FinancialCrm
{
    partial class FrmSpending
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdateSpending = new System.Windows.Forms.Button();
            this.btnRemoveSpending = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SpendingDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmCategory = new System.Windows.Forms.ComboBox();
            this.btnCreateSpending = new System.Windows.Forms.Button();
            this.btnSpendingList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpendingAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpendingTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpendingId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCategories = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnDasboard = new System.Windows.Forms.Button();
            this.btnBankProcesses = new System.Windows.Forms.Button();
            this.btnSpending = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(208, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 201);
            this.panel3.TabIndex = 6;
            // 
            // btnUpdateSpending
            // 
            this.btnUpdateSpending.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSpending.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnUpdateSpending.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateSpending.Location = new System.Drawing.Point(507, 242);
            this.btnUpdateSpending.Name = "btnUpdateSpending";
            this.btnUpdateSpending.Size = new System.Drawing.Size(125, 38);
            this.btnUpdateSpending.TabIndex = 11;
            this.btnUpdateSpending.Text = "Gider Güncelle";
            this.btnUpdateSpending.UseVisualStyleBackColor = false;
            this.btnUpdateSpending.Click += new System.EventHandler(this.btnUpdateSpending_Click);
            // 
            // btnRemoveSpending
            // 
            this.btnRemoveSpending.BackColor = System.Drawing.Color.Silver;
            this.btnRemoveSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveSpending.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveSpending.Location = new System.Drawing.Point(370, 242);
            this.btnRemoveSpending.Name = "btnRemoveSpending";
            this.btnRemoveSpending.Size = new System.Drawing.Size(125, 38);
            this.btnRemoveSpending.TabIndex = 10;
            this.btnRemoveSpending.Text = "Gider Sil";
            this.btnRemoveSpending.UseVisualStyleBackColor = false;
            this.btnRemoveSpending.Click += new System.EventHandler(this.btnRemoveSpending_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SpendingDate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmCategory);
            this.panel2.Controls.Add(this.btnUpdateSpending);
            this.panel2.Controls.Add(this.btnRemoveSpending);
            this.panel2.Controls.Add(this.btnCreateSpending);
            this.panel2.Controls.Add(this.btnSpendingList);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSpendingAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSpendingTitle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSpendingId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(208, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 287);
            this.panel2.TabIndex = 5;
            // 
            // SpendingDate
            // 
            this.SpendingDate.Location = new System.Drawing.Point(98, 156);
            this.SpendingDate.Name = "SpendingDate";
            this.SpendingDate.Size = new System.Drawing.Size(276, 20);
            this.SpendingDate.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kategori: ";
            // 
            // cmCategory
            // 
            this.cmCategory.FormattingEnabled = true;
            this.cmCategory.Location = new System.Drawing.Point(98, 196);
            this.cmCategory.Name = "cmCategory";
            this.cmCategory.Size = new System.Drawing.Size(276, 21);
            this.cmCategory.TabIndex = 12;
            // 
            // btnCreateSpending
            // 
            this.btnCreateSpending.BackColor = System.Drawing.Color.Silver;
            this.btnCreateSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateSpending.ForeColor = System.Drawing.Color.Black;
            this.btnCreateSpending.Location = new System.Drawing.Point(233, 242);
            this.btnCreateSpending.Name = "btnCreateSpending";
            this.btnCreateSpending.Size = new System.Drawing.Size(125, 38);
            this.btnCreateSpending.TabIndex = 9;
            this.btnCreateSpending.Text = "Yeni Gider";
            this.btnCreateSpending.UseVisualStyleBackColor = false;
            this.btnCreateSpending.Click += new System.EventHandler(this.btnCreateSpending_Click);
            // 
            // btnSpendingList
            // 
            this.btnSpendingList.BackColor = System.Drawing.Color.Silver;
            this.btnSpendingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingList.ForeColor = System.Drawing.Color.Black;
            this.btnSpendingList.Location = new System.Drawing.Point(96, 242);
            this.btnSpendingList.Name = "btnSpendingList";
            this.btnSpendingList.Size = new System.Drawing.Size(125, 38);
            this.btnSpendingList.TabIndex = 8;
            this.btnSpendingList.Text = "Gider Listesi";
            this.btnSpendingList.UseVisualStyleBackColor = false;
            this.btnSpendingList.Click += new System.EventHandler(this.btnLSpendingList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(46, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tarih: ";
            // 
            // txtSpendingAmount
            // 
            this.txtSpendingAmount.BackColor = System.Drawing.Color.Khaki;
            this.txtSpendingAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingAmount.Location = new System.Drawing.Point(94, 113);
            this.txtSpendingAmount.Name = "txtSpendingAmount";
            this.txtSpendingAmount.Size = new System.Drawing.Size(558, 27);
            this.txtSpendingAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miktar: ";
            // 
            // txtSpendingTitle
            // 
            this.txtSpendingTitle.BackColor = System.Drawing.Color.Khaki;
            this.txtSpendingTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingTitle.Location = new System.Drawing.Point(94, 70);
            this.txtSpendingTitle.Name = "txtSpendingTitle";
            this.txtSpendingTitle.Size = new System.Drawing.Size(558, 27);
            this.txtSpendingTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlık: ";
            // 
            // txtSpendingId
            // 
            this.txtSpendingId.BackColor = System.Drawing.Color.Khaki;
            this.txtSpendingId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingId.Location = new System.Drawing.Point(94, 29);
            this.txtSpendingId.Name = "txtSpendingId";
            this.txtSpendingId.Size = new System.Drawing.Size(558, 27);
            this.txtSpendingId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harcama Id: ";
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.Transparent;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Location = new System.Drawing.Point(29, 32);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(139, 38);
            this.btnCategories.TabIndex = 1;
            this.btnCategories.Text = "Kategoriler";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(29, 296);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 38);
            this.button7.TabIndex = 4;
            this.button7.Text = "Çıkış Yap";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnDasboard
            // 
            this.btnDasboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDasboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDasboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDasboard.ForeColor = System.Drawing.Color.White;
            this.btnDasboard.Location = new System.Drawing.Point(29, 252);
            this.btnDasboard.Name = "btnDasboard";
            this.btnDasboard.Size = new System.Drawing.Size(139, 38);
            this.btnDasboard.TabIndex = 6;
            this.btnDasboard.Text = "Dashboard";
            this.btnDasboard.UseVisualStyleBackColor = false;
            this.btnDasboard.Click += new System.EventHandler(this.btnDasboard_Click);
            // 
            // btnBankProcesses
            // 
            this.btnBankProcesses.BackColor = System.Drawing.Color.Transparent;
            this.btnBankProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankProcesses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcesses.ForeColor = System.Drawing.Color.White;
            this.btnBankProcesses.Location = new System.Drawing.Point(29, 208);
            this.btnBankProcesses.Name = "btnBankProcesses";
            this.btnBankProcesses.Size = new System.Drawing.Size(139, 38);
            this.btnBankProcesses.TabIndex = 5;
            this.btnBankProcesses.Text = "Banka Hareketleri";
            this.btnBankProcesses.UseVisualStyleBackColor = false;
            this.btnBankProcesses.Click += new System.EventHandler(this.btnBankProcesses_Click);
            // 
            // btnSpending
            // 
            this.btnSpending.BackColor = System.Drawing.Color.Transparent;
            this.btnSpending.Enabled = false;
            this.btnSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpending.ForeColor = System.Drawing.Color.White;
            this.btnSpending.Location = new System.Drawing.Point(29, 164);
            this.btnSpending.Name = "btnSpending";
            this.btnSpending.Size = new System.Drawing.Size(139, 38);
            this.btnSpending.TabIndex = 4;
            this.btnSpending.Text = "Giderler";
            this.btnSpending.UseVisualStyleBackColor = false;
            // 
            // btnBills
            // 
            this.btnBills.BackColor = System.Drawing.Color.Transparent;
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBills.ForeColor = System.Drawing.Color.White;
            this.btnBills.Location = new System.Drawing.Point(29, 120);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(139, 38);
            this.btnBills.TabIndex = 3;
            this.btnBills.Text = "Faturalar";
            this.btnBills.UseVisualStyleBackColor = false;
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.BackColor = System.Drawing.Color.Transparent;
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(29, 76);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(139, 38);
            this.btnBanksForm.TabIndex = 2;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btnDasboard);
            this.panel1.Controls.Add(this.btnBankProcesses);
            this.panel1.Controls.Add(this.btnSpending);
            this.panel1.Controls.Add(this.btnBills);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 504);
            this.panel1.TabIndex = 4;
            // 
            // FrmSpending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 551);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSpending";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSpending";
            this.Load += new System.EventHandler(this.FrmSpending_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdateSpending;
        private System.Windows.Forms.Button btnRemoveSpending;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreateSpending;
        private System.Windows.Forms.Button btnSpendingList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpendingAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpendingTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpendingId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnDasboard;
        private System.Windows.Forms.Button btnBankProcesses;
        private System.Windows.Forms.Button btnSpending;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker SpendingDate;
    }
}