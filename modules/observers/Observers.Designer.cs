namespace election.modules.observes
{
    partial class Observers
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
            this.btnAddObserver = new System.Windows.Forms.Button();
            this.btnSaveAndExit = new System.Windows.Forms.Button();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressAndPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordTime = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.Nam,
            this.Nname,
            this.Status,
            this.From,
            this.AddressAndPhone,
            this.Time,
            this.RecordTime});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(848, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAddObserver
            // 
            this.btnAddObserver.Location = new System.Drawing.Point(582, 168);
            this.btnAddObserver.Name = "btnAddObserver";
            this.btnAddObserver.Size = new System.Drawing.Size(153, 23);
            this.btnAddObserver.TabIndex = 4;
            this.btnAddObserver.Text = "Добавить наблюдателя";
            this.btnAddObserver.UseVisualStyleBackColor = true;
            this.btnAddObserver.Click += new System.EventHandler(this.btnAddObserver_Click);
            // 
            // btnSaveAndExit
            // 
            this.btnSaveAndExit.Location = new System.Drawing.Point(741, 168);
            this.btnSaveAndExit.Name = "btnSaveAndExit";
            this.btnSaveAndExit.Size = new System.Drawing.Size(119, 23);
            this.btnSaveAndExit.TabIndex = 3;
            this.btnSaveAndExit.Text = "Сохранить и Выйти";
            this.btnSaveAndExit.UseVisualStyleBackColor = true;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Nam
            // 
            this.Nam.HeaderText = "Имя";
            this.Nam.Name = "Nam";
            this.Nam.ReadOnly = true;
            // 
            // Nname
            // 
            this.Nname.HeaderText = "Отчество";
            this.Nname.Name = "Nname";
            this.Nname.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус присутствующегоо лица";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // From
            // 
            this.From.HeaderText = "Кого представляет**";
            this.From.Name = "From";
            this.From.ReadOnly = true;
            // 
            // AddressAndPhone
            // 
            this.AddressAndPhone.HeaderText = "Контактный телефон и адрес места жительства";
            this.AddressAndPhone.Name = "AddressAndPhone";
            this.AddressAndPhone.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Указанное лицо присутствовало с __ч. ___ мин. по __ч. __.мин";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // RecordTime
            // 
            this.RecordTime.HeaderText = "Запомнить время";
            this.RecordTime.Name = "RecordTime";
            // 
            // Observers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 214);
            this.Controls.Add(this.btnAddObserver);
            this.Controls.Add(this.btnSaveAndExit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Observers";
            this.Text = "Наблюдатели";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddObserver;
        private System.Windows.Forms.Button btnSaveAndExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressAndPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewButtonColumn RecordTime;
    }
}