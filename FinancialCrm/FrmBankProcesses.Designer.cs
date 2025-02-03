namespace FinancialCrm
{
    partial class FrmBankProcesses
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDasboard = new System.Windows.Forms.Button();
            this.btnBankProcesses = new System.Windows.Forms.Button();
            this.btnSpending = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnUpdateProcess = new System.Windows.Forms.Button();
            this.btnRemoveProcess = new System.Windows.Forms.Button();
            this.ProcessDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmBanks = new System.Windows.Forms.ComboBox();
            this.btnCreateProcess = new System.Windows.Forms.Button();
            this.btnProcessList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProcessAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDecsription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProcessesId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtProcessType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnStatistics);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDasboard);
            this.panel1.Controls.Add(this.btnBankProcesses);
            this.panel1.Controls.Add(this.btnSpending);
            this.panel1.Controls.Add(this.btnBills);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 578);
            this.panel1.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(27, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDasboard
            // 
            this.btnDasboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDasboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDasboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDasboard.ForeColor = System.Drawing.Color.White;
            this.btnDasboard.Location = new System.Drawing.Point(27, 295);
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
            this.btnBankProcesses.Enabled = false;
            this.btnBankProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankProcesses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcesses.ForeColor = System.Drawing.Color.White;
            this.btnBankProcesses.Location = new System.Drawing.Point(27, 207);
            this.btnBankProcesses.Name = "btnBankProcesses";
            this.btnBankProcesses.Size = new System.Drawing.Size(139, 38);
            this.btnBankProcesses.TabIndex = 5;
            this.btnBankProcesses.Text = "Banka Hareketleri";
            this.btnBankProcesses.UseVisualStyleBackColor = false;
            // 
            // btnSpending
            // 
            this.btnSpending.BackColor = System.Drawing.Color.Transparent;
            this.btnSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpending.ForeColor = System.Drawing.Color.White;
            this.btnSpending.Location = new System.Drawing.Point(27, 163);
            this.btnSpending.Name = "btnSpending";
            this.btnSpending.Size = new System.Drawing.Size(139, 38);
            this.btnSpending.TabIndex = 4;
            this.btnSpending.Text = "Giderler";
            this.btnSpending.UseVisualStyleBackColor = false;
            this.btnSpending.Click += new System.EventHandler(this.btnSpending_Click);
            // 
            // btnBills
            // 
            this.btnBills.BackColor = System.Drawing.Color.Transparent;
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBills.ForeColor = System.Drawing.Color.White;
            this.btnBills.Location = new System.Drawing.Point(27, 119);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(139, 38);
            this.btnBills.TabIndex = 3;
            this.btnBills.Text = "Faturalar";
            this.btnBills.UseVisualStyleBackColor = false;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.BackColor = System.Drawing.Color.Transparent;
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(27, 75);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(139, 38);
            this.btnBanksForm.TabIndex = 2;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = false;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.Transparent;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Location = new System.Drawing.Point(27, 31);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(139, 38);
            this.btnCategories.TabIndex = 1;
            this.btnCategories.Text = "Kategoriler";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnUpdateProcess
            // 
            this.btnUpdateProcess.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProcess.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnUpdateProcess.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateProcess.Location = new System.Drawing.Point(518, 285);
            this.btnUpdateProcess.Name = "btnUpdateProcess";
            this.btnUpdateProcess.Size = new System.Drawing.Size(136, 38);
            this.btnUpdateProcess.TabIndex = 11;
            this.btnUpdateProcess.Text = "Güncelle";
            this.btnUpdateProcess.UseVisualStyleBackColor = false;
            this.btnUpdateProcess.Click += new System.EventHandler(this.btnUpdateProcess_Click);
            // 
            // btnRemoveProcess
            // 
            this.btnRemoveProcess.BackColor = System.Drawing.Color.Silver;
            this.btnRemoveProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveProcess.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveProcess.Location = new System.Drawing.Point(367, 285);
            this.btnRemoveProcess.Name = "btnRemoveProcess";
            this.btnRemoveProcess.Size = new System.Drawing.Size(136, 38);
            this.btnRemoveProcess.TabIndex = 10;
            this.btnRemoveProcess.Text = "Sil";
            this.btnRemoveProcess.UseVisualStyleBackColor = false;
            this.btnRemoveProcess.Click += new System.EventHandler(this.btnRemoveProcess_Click);
            // 
            // ProcessDate
            // 
            this.ProcessDate.Location = new System.Drawing.Point(129, 197);
            this.ProcessDate.Name = "ProcessDate";
            this.ProcessDate.Size = new System.Drawing.Size(276, 20);
            this.ProcessDate.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(66, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Banka: ";
            // 
            // cmBanks
            // 
            this.cmBanks.FormattingEnabled = true;
            this.cmBanks.Location = new System.Drawing.Point(129, 237);
            this.cmBanks.Name = "cmBanks";
            this.cmBanks.Size = new System.Drawing.Size(276, 21);
            this.cmBanks.TabIndex = 12;
            // 
            // btnCreateProcess
            // 
            this.btnCreateProcess.BackColor = System.Drawing.Color.Silver;
            this.btnCreateProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateProcess.ForeColor = System.Drawing.Color.Black;
            this.btnCreateProcess.Location = new System.Drawing.Point(217, 285);
            this.btnCreateProcess.Name = "btnCreateProcess";
            this.btnCreateProcess.Size = new System.Drawing.Size(136, 38);
            this.btnCreateProcess.TabIndex = 9;
            this.btnCreateProcess.Text = "Yeni Ekle";
            this.btnCreateProcess.UseVisualStyleBackColor = false;
            this.btnCreateProcess.Click += new System.EventHandler(this.btnCreateProcess_Click);
            // 
            // btnProcessList
            // 
            this.btnProcessList.BackColor = System.Drawing.Color.Silver;
            this.btnProcessList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProcessList.ForeColor = System.Drawing.Color.Black;
            this.btnProcessList.Location = new System.Drawing.Point(68, 285);
            this.btnProcessList.Name = "btnProcessList";
            this.btnProcessList.Size = new System.Drawing.Size(136, 38);
            this.btnProcessList.TabIndex = 8;
            this.btnProcessList.Text = "Banka Hareketleri";
            this.btnProcessList.UseVisualStyleBackColor = false;
            this.btnProcessList.Click += new System.EventHandler(this.btnProcessList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(74, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tarih: ";
            // 
            // txtProcessAmount
            // 
            this.txtProcessAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.txtProcessAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessAmount.Location = new System.Drawing.Point(129, 112);
            this.txtProcessAmount.Name = "txtProcessAmount";
            this.txtProcessAmount.Size = new System.Drawing.Size(558, 27);
            this.txtProcessAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(64, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miktar: ";
            // 
            // txtDecsription
            // 
            this.txtDecsription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.txtDecsription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDecsription.Location = new System.Drawing.Point(129, 69);
            this.txtDecsription.Name = "txtDecsription";
            this.txtDecsription.Size = new System.Drawing.Size(558, 27);
            this.txtDecsription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Açıklama: ";
            // 
            // txtProcessesId
            // 
            this.txtProcessesId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.txtProcessesId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessesId.Location = new System.Drawing.Point(129, 28);
            this.txtProcessesId.Name = "txtProcessesId";
            this.txtProcessesId.Size = new System.Drawing.Size(558, 27);
            this.txtProcessesId.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(206, 349);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(695, 222);
            this.panel3.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtProcessType);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.ProcessDate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmBanks);
            this.panel2.Controls.Add(this.btnUpdateProcess);
            this.panel2.Controls.Add(this.btnRemoveProcess);
            this.panel2.Controls.Add(this.btnCreateProcess);
            this.panel2.Controls.Add(this.btnProcessList);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtProcessAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtDecsription);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtProcessesId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(206, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 332);
            this.panel2.TabIndex = 8;
            // 
            // txtProcessType
            // 
            this.txtProcessType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.txtProcessType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessType.Location = new System.Drawing.Point(129, 153);
            this.txtProcessType.Name = "txtProcessType";
            this.txtProcessType.Size = new System.Drawing.Size(558, 27);
            this.txtProcessType.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(40, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "İşlem Türü: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F);
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banka Hareketleri \r\n                               Id: ";
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.Transparent;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Location = new System.Drawing.Point(27, 251);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(139, 38);
            this.btnStatistics.TabIndex = 8;
            this.btnStatistics.Text = "İstatistikler";
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // FrmBankProcesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(904, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FrmBankProcesses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBankProcesses";
            this.Load += new System.EventHandler(this.FrmBankProcesses_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDasboard;
        private System.Windows.Forms.Button btnBankProcesses;
        private System.Windows.Forms.Button btnSpending;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnUpdateProcess;
        private System.Windows.Forms.Button btnRemoveProcess;
        private System.Windows.Forms.DateTimePicker ProcessDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmBanks;
        private System.Windows.Forms.Button btnCreateProcess;
        private System.Windows.Forms.Button btnProcessList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProcessAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDecsription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProcessesId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProcessType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStatistics;
    }
}