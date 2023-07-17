
namespace formproject
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.sTAFFBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new formproject.DataSet3();
            this.sTAFFBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new formproject.DataSet2();
            this.dataSet1 = new formproject.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAFFTableAdapter = new formproject.DataSet2TableAdapters.STAFFTableAdapter();
            this.dONATEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dONATETableAdapter = new formproject.DataSet3TableAdapters.DONATETableAdapter();
            this.dONORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dONORTableAdapter = new formproject.DataSet3TableAdapters.DONORTableAdapter();
            this.cHARITYBRANCHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHARITY_BRANCHESTableAdapter = new formproject.DataSet3TableAdapters.CHARITY_BRANCHESTableAdapter();
            this.sTAFFTableAdapter1 = new formproject.DataSet3TableAdapters.STAFFTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONATEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHARITYBRANCHESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(288, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Value";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(293, 317);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 51);
            this.button2.TabIndex = 8;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(274, 113);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 138);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(148, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "DISCONNECTED FORM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sTAFFBindingSource2
            // 
            this.sTAFFBindingSource2.DataMember = "STAFF";
            this.sTAFFBindingSource2.DataSource = this.dataSet3BindingSource;
            // 
            // dataSet3BindingSource
            // 
            this.dataSet3BindingSource.DataSource = this.dataSet3;
            this.dataSet3BindingSource.Position = 0;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTAFFBindingSource1
            // 
            this.sTAFFBindingSource1.DataMember = "STAFF";
            this.sTAFFBindingSource1.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.dataSet2;
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // dONATEBindingSource
            // 
            this.dONATEBindingSource.DataMember = "DONATE";
            this.dONATEBindingSource.DataSource = this.dataSet3BindingSource;
            // 
            // dONATETableAdapter
            // 
            this.dONATETableAdapter.ClearBeforeFill = true;
            // 
            // dONORBindingSource
            // 
            this.dONORBindingSource.DataMember = "DONOR";
            this.dONORBindingSource.DataSource = this.dataSet3BindingSource;
            // 
            // dONORTableAdapter
            // 
            this.dONORTableAdapter.ClearBeforeFill = true;
            // 
            // cHARITYBRANCHESBindingSource
            // 
            this.cHARITYBRANCHESBindingSource.DataMember = "CHARITY_BRANCHES";
            this.cHARITYBRANCHESBindingSource.DataSource = this.dataSet3BindingSource;
            // 
            // cHARITY_BRANCHESTableAdapter
            // 
            this.cHARITY_BRANCHESTableAdapter.ClearBeforeFill = true;
            // 
            // sTAFFTableAdapter1
            // 
            this.sTAFFTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONATEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHARITYBRANCHESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private DataSet2TableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.BindingSource dataSet3BindingSource;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource dONATEBindingSource;
        private DataSet3TableAdapters.DONATETableAdapter dONATETableAdapter;
        private System.Windows.Forms.BindingSource dONORBindingSource;
        private DataSet3TableAdapters.DONORTableAdapter dONORTableAdapter;
        private System.Windows.Forms.BindingSource cHARITYBRANCHESBindingSource;
        private DataSet3TableAdapters.CHARITY_BRANCHESTableAdapter cHARITY_BRANCHESTableAdapter;
        private System.Windows.Forms.BindingSource sTAFFBindingSource1;
        private System.Windows.Forms.BindingSource sTAFFBindingSource2;
        private DataSet3TableAdapters.STAFFTableAdapter sTAFFTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}