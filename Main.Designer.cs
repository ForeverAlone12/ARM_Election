namespace election
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonElection = new System.Windows.Forms.Button();
            this.buttonUIK = new System.Windows.Forms.Button();
            this.buttonMembers = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonObservers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(965, 517);
            this.splitContainer1.SplitterDistance = 229;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonElection);
            this.groupBox2.Controls.Add(this.buttonUIK);
            this.groupBox2.Controls.Add(this.buttonMembers);
            this.groupBox2.Location = new System.Drawing.Point(332, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 116);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Администрирование";
            // 
            // buttonElection
            // 
            this.buttonElection.Location = new System.Drawing.Point(7, 78);
            this.buttonElection.Name = "buttonElection";
            this.buttonElection.Size = new System.Drawing.Size(201, 24);
            this.buttonElection.TabIndex = 2;
            this.buttonElection.Text = "Выборы";
            this.buttonElection.UseVisualStyleBackColor = true;
            this.buttonElection.Click += new System.EventHandler(this.buttonElection_Click);
            // 
            // buttonUIK
            // 
            this.buttonUIK.Location = new System.Drawing.Point(7, 48);
            this.buttonUIK.Name = "buttonUIK";
            this.buttonUIK.Size = new System.Drawing.Size(201, 24);
            this.buttonUIK.TabIndex = 1;
            this.buttonUIK.Text = "Данные УИК";
            this.buttonUIK.UseVisualStyleBackColor = true;
            this.buttonUIK.Click += new System.EventHandler(this.buttonUIK_Click);
            // 
            // buttonMembers
            // 
            this.buttonMembers.Location = new System.Drawing.Point(6, 19);
            this.buttonMembers.Name = "buttonMembers";
            this.buttonMembers.Size = new System.Drawing.Size(202, 23);
            this.buttonMembers.TabIndex = 0;
            this.buttonMembers.Text = "Члены комиссии";
            this.buttonMembers.UseVisualStyleBackColor = true;
            this.buttonMembers.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonObservers);
            this.groupBox1.Location = new System.Drawing.Point(112, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню";
            // 
            // buttonObservers
            // 
            this.buttonObservers.Location = new System.Drawing.Point(7, 19);
            this.buttonObservers.Name = "buttonObservers";
            this.buttonObservers.Size = new System.Drawing.Size(201, 23);
            this.buttonObservers.TabIndex = 0;
            this.buttonObservers.Text = "Наблюдатели";
            this.buttonObservers.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 517);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Main";
            this.Text = "АРМ секретаря УИК";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonMembers;
        private System.Windows.Forms.Button buttonUIK;
        private System.Windows.Forms.Button buttonElection;
        private System.Windows.Forms.Button buttonObservers;
    }
}

