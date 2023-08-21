namespace DisplayRecs
{
    partial class DisplayRecords
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
            this.labelFeedback = new System.Windows.Forms.Label();
            this.dataGridViewAllRecords = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Location = new System.Drawing.Point(113, 315);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(80, 20);
            this.labelFeedback.TabIndex = 0;
            this.labelFeedback.Text = "Feedback";
            // 
            // dataGridViewAllRecords
            // 
            this.dataGridViewAllRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllRecords.Location = new System.Drawing.Point(66, 21);
            this.dataGridViewAllRecords.Name = "dataGridViewAllRecords";
            this.dataGridViewAllRecords.RowHeadersWidth = 62;
            this.dataGridViewAllRecords.RowTemplate.Height = 28;
            this.dataGridViewAllRecords.Size = new System.Drawing.Size(658, 262);
            this.dataGridViewAllRecords.TabIndex = 1;
            // 
            // DisplayRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewAllRecords);
            this.Controls.Add(this.labelFeedback);
            this.Name = "DisplayRecords";
            this.Text = "DisplayRecords";
            this.Load += new System.EventHandler(this.DisplayRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.DataGridView dataGridViewAllRecords;
    }
}

