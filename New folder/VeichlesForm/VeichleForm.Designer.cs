namespace VeichlesForm
{
    partial class VeichleDataForm
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
            this.components = new System.ComponentModel.Container();
            this.DisplayDataButton = new System.Windows.Forms.Button();
            this.veichlesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.veichlesDataSet = new VeichlesForm.VeichlesDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veichleModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veichlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veichlesTableAdapter = new VeichlesForm.VeichlesDataSetTableAdapters.VeichlesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.veichlesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veichlesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veichlesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayDataButton
            // 
            this.DisplayDataButton.AllowDrop = true;
            this.DisplayDataButton.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.veichlesBindingSource1, "Student_ID", true));
            this.DisplayDataButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DisplayDataButton.Location = new System.Drawing.Point(0, 0);
            this.DisplayDataButton.Name = "DisplayDataButton";
            this.DisplayDataButton.Size = new System.Drawing.Size(1082, 55);
            this.DisplayDataButton.TabIndex = 0;
            this.DisplayDataButton.Text = "Display";
            this.DisplayDataButton.UseVisualStyleBackColor = true;
            this.DisplayDataButton.Click += new System.EventHandler(this.DisplayDataButton_Click);
            // 
            // veichlesBindingSource1
            // 
            this.veichlesBindingSource1.DataMember = "Veichles";
            this.veichlesBindingSource1.DataSource = this.veichlesDataSet;
            this.veichlesBindingSource1.CurrentChanged += new System.EventHandler(this.veichlesBindingSource1_CurrentChanged);
            // 
            // veichlesDataSet
            // 
            this.veichlesDataSet.DataSetName = "VeichlesDataSet";
            this.veichlesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.veichleModelDataGridViewTextBoxColumn,
            this.registrationDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn,
            this.apartmentDataGridViewTextBoxColumn,
            this.permitDataGridViewTextBoxColumn,
            this.feesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.veichlesBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 370);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // veichleModelDataGridViewTextBoxColumn
            // 
            this.veichleModelDataGridViewTextBoxColumn.DataPropertyName = "Veichle_Model";
            this.veichleModelDataGridViewTextBoxColumn.HeaderText = "Veichle_Model";
            this.veichleModelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.veichleModelDataGridViewTextBoxColumn.Name = "veichleModelDataGridViewTextBoxColumn";
            this.veichleModelDataGridViewTextBoxColumn.Width = 150;
            // 
            // registrationDataGridViewTextBoxColumn
            // 
            this.registrationDataGridViewTextBoxColumn.DataPropertyName = "Registration";
            this.registrationDataGridViewTextBoxColumn.HeaderText = "Registration";
            this.registrationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.registrationDataGridViewTextBoxColumn.Name = "registrationDataGridViewTextBoxColumn";
            this.registrationDataGridViewTextBoxColumn.Width = 150;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.ownerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.Width = 150;
            // 
            // apartmentDataGridViewTextBoxColumn
            // 
            this.apartmentDataGridViewTextBoxColumn.DataPropertyName = "Apartment";
            this.apartmentDataGridViewTextBoxColumn.HeaderText = "Apartment";
            this.apartmentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.apartmentDataGridViewTextBoxColumn.Name = "apartmentDataGridViewTextBoxColumn";
            this.apartmentDataGridViewTextBoxColumn.Width = 150;
            // 
            // permitDataGridViewTextBoxColumn
            // 
            this.permitDataGridViewTextBoxColumn.DataPropertyName = "Permit";
            this.permitDataGridViewTextBoxColumn.HeaderText = "Permit";
            this.permitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.permitDataGridViewTextBoxColumn.Name = "permitDataGridViewTextBoxColumn";
            this.permitDataGridViewTextBoxColumn.Width = 150;
            // 
            // feesDataGridViewTextBoxColumn
            // 
            this.feesDataGridViewTextBoxColumn.DataPropertyName = "Fees";
            this.feesDataGridViewTextBoxColumn.HeaderText = "Fees";
            this.feesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.feesDataGridViewTextBoxColumn.Name = "feesDataGridViewTextBoxColumn";
            this.feesDataGridViewTextBoxColumn.Width = 150;
            // 
            // veichlesBindingSource
            // 
            this.veichlesBindingSource.DataMember = "Veichles";
            this.veichlesBindingSource.DataSource = this.veichlesDataSet;
            // 
            // veichlesTableAdapter
            // 
            this.veichlesTableAdapter.ClearBeforeFill = true;
            // 
            // VeichleDataForm
            // 
            this.AcceptButton = this.DisplayDataButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1082, 425);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DisplayDataButton);
            this.MinimizeBox = false;
            this.Name = "VeichleDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VeichleDataForm";
            this.Load += new System.EventHandler(this.VeichleDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veichlesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veichlesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veichlesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DisplayDataButton;
        private VeichlesDataSet veichlesDataSet;
        private System.Windows.Forms.BindingSource veichlesBindingSource;
        private VeichlesDataSetTableAdapters.VeichlesTableAdapter veichlesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veichleModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource veichlesBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

