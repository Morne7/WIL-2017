﻿namespace WIL
{
    partial class TripForm
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
            this.updateTripButton = new System.Windows.Forms.Button();
            this.report6Button = new System.Windows.Forms.Button();
            this.printReportButton = new System.Windows.Forms.Button();
            this.addTripButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.truckID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wILDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wILDBDataSetBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.wILDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // updateTripButton
            // 
            this.updateTripButton.Location = new System.Drawing.Point(11, 25);
            this.updateTripButton.Name = "updateTripButton";
            this.updateTripButton.Size = new System.Drawing.Size(110, 33);
            this.updateTripButton.TabIndex = 0;
            this.updateTripButton.Text = "Update Trips";
            this.updateTripButton.UseVisualStyleBackColor = true;
            // 
            // report6Button
            // 
            this.report6Button.Location = new System.Drawing.Point(11, 293);
            this.report6Button.Name = "report6Button";
            this.report6Button.Size = new System.Drawing.Size(104, 40);
            this.report6Button.TabIndex = 1;
            this.report6Button.Text = "Print Report 6";
            this.report6Button.UseVisualStyleBackColor = true;
            // 
            // printReportButton
            // 
            this.printReportButton.Location = new System.Drawing.Point(121, 293);
            this.printReportButton.Name = "printReportButton";
            this.printReportButton.Size = new System.Drawing.Size(104, 40);
            this.printReportButton.TabIndex = 2;
            this.printReportButton.Text = "Print Report 7";
            this.printReportButton.UseVisualStyleBackColor = true;
            // 
            // addTripButton
            // 
            this.addTripButton.Location = new System.Drawing.Point(543, 25);
            this.addTripButton.Name = "addTripButton";
            this.addTripButton.Size = new System.Drawing.Size(110, 33);
            this.addTripButton.TabIndex = 3;
            this.addTripButton.Text = "Add Trip";
            this.addTripButton.UseVisualStyleBackColor = true;
            this.addTripButton.Click += new System.EventHandler(this.addTripButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(545, 306);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 27);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit ";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.truckID,
            this.customerID,
            this.startDate,
            this.endDate,
            this.departure,
            this.destination});
            this.dataGridView1.DataSource = this.wILDBDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 186);
            this.dataGridView1.TabIndex = 5;
            // 
            // truckID
            // 
            this.truckID.HeaderText = "Truck ID";
            this.truckID.Name = "truckID";
            // 
            // customerID
            // 
            this.customerID.HeaderText = "Customer ID";
            this.customerID.Name = "customerID";
            // 
            // startDate
            // 
            this.startDate.HeaderText = "Start Date";
            this.startDate.Name = "startDate";
            // 
            // endDate
            // 
            this.endDate.HeaderText = "End Date";
            this.endDate.Name = "endDate";
            // 
            // departure
            // 
            this.departure.HeaderText = "Departure";
            this.departure.Name = "departure";
            // 
            // destination
            // 
            this.destination.HeaderText = "Destination";
            this.destination.Name = "destination";
            // 
            // wILDBDataSetBindingSource
            // 
            //this.wILDBDataSetBindingSource.DataSource = this.wILDBDataSet;
            this.wILDBDataSetBindingSource.Position = 0;
            // 
            // wILDBDataSet
            // 
            //this.wILDBDataSet.DataSetName = "WILDBDataSet";
            //this.wILDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 345);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addTripButton);
            this.Controls.Add(this.printReportButton);
            this.Controls.Add(this.report6Button);
            this.Controls.Add(this.updateTripButton);
            this.Name = "tripForm";
            this.Text = "tripForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wILDBDataSetBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.wILDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateTripButton;
        private System.Windows.Forms.Button report6Button;
        private System.Windows.Forms.Button printReportButton;
        private System.Windows.Forms.Button addTripButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn truckID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.BindingSource wILDBDataSetBindingSource;
    }
}