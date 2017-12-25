namespace _13._21
{
    partial class Form1
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
            this.GameGrid = new System.Windows.Forms.DataGridView();
            this.SelectLevel = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartBtn = new System.Windows.Forms.Button();
            this.Win = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GameGrid
            // 
            this.GameGrid.AllowUserToAddRows = false;
            this.GameGrid.AllowUserToDeleteRows = false;
            this.GameGrid.AllowUserToResizeColumns = false;
            this.GameGrid.AllowUserToResizeRows = false;
            this.GameGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameGrid.ColumnHeadersVisible = false;
            this.GameGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.GameGrid.Location = new System.Drawing.Point(12, 39);
            this.GameGrid.Name = "GameGrid";
            this.GameGrid.ReadOnly = true;
            this.GameGrid.RowHeadersVisible = false;
            this.GameGrid.Size = new System.Drawing.Size(303, 303);
            this.GameGrid.TabIndex = 0;
            this.GameGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GameGrid_CellClick);
            this.GameGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GameGrid_CellPainting);
            // 
            // SelectLevel
            // 
            this.SelectLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectLevel.FormattingEnabled = true;
            this.SelectLevel.Location = new System.Drawing.Point(12, 12);
            this.SelectLevel.Name = "SelectLevel";
            this.SelectLevel.Size = new System.Drawing.Size(121, 21);
            this.SelectLevel.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(192, 12);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Start Game";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // Win
            // 
            this.Win.AutoSize = true;
            this.Win.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Win.Location = new System.Drawing.Point(57, 137);
            this.Win.Name = "Win";
            this.Win.Size = new System.Drawing.Size(210, 108);
            this.Win.TabIndex = 3;
            this.Win.Text = "Win";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 359);
            this.Controls.Add(this.Win);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.SelectLevel);
            this.Controls.Add(this.GameGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(341, 398);
            this.MinimumSize = new System.Drawing.Size(341, 398);
            this.Name = "Form1";
            this.Text = "13.21";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GameGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox SelectLevel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label Win;
    }
}

