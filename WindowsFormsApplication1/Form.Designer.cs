namespace PTS
{
    partial class Form
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.l1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roomscb = new System.Windows.Forms.CheckedListBox();
            this.runsim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 147);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(519, 670);
            this.dataGrid.TabIndex = 0;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(7, 9);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(217, 25);
            this.l1.TabIndex = 5;
            this.l1.Text = "Zone you are running";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Story zones don\'t include Atziri and map rooms";
            // 
            // roomscb
            // 
            this.roomscb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomscb.FormattingEnabled = true;
            this.roomscb.Items.AddRange(new object[] {
            "Maps (24 rooms)",
            "Story Zone (22 rooms)"});
            this.roomscb.Location = new System.Drawing.Point(12, 51);
            this.roomscb.Name = "roomscb";
            this.roomscb.Size = new System.Drawing.Size(255, 56);
            this.roomscb.TabIndex = 10;
            // 
            // runsim
            // 
            this.runsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runsim.Location = new System.Drawing.Point(359, 9);
            this.runsim.Name = "runsim";
            this.runsim.Size = new System.Drawing.Size(172, 132);
            this.runsim.TabIndex = 11;
            this.runsim.Text = "Run Sim";
            this.runsim.UseVisualStyleBackColor = true;
            this.runsim.Click += new System.EventHandler(this.runsim_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 829);
            this.Controls.Add(this.runsim);
            this.Controls.Add(this.roomscb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form";
            this.Text = "Temple Simulation";
            this.Load += new System.EventHandler(this.PathTemples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox roomscb;
        private System.Windows.Forms.Button runsim;
    }
}

