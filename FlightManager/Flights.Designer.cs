namespace FlightManager
{
    partial class Flights
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
            this.flightAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearchByFlightNo = new System.Windows.Forms.TextBox();
            this.labelSearchByDeparture = new System.Windows.Forms.Label();
            this.textBoxSearchByDeparture = new System.Windows.Forms.TextBox();
            this.labelSearchByDestination = new System.Windows.Forms.Label();
            this.textBoxSearchByDestination = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flightAdd
            // 
            this.flightAdd.Location = new System.Drawing.Point(809, 443);
            this.flightAdd.Name = "flightAdd";
            this.flightAdd.Size = new System.Drawing.Size(75, 23);
            this.flightAdd.TabIndex = 0;
            this.flightAdd.Text = "Book Flight";
            this.flightAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 42);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(848, 391);
            this.dataGridView1.TabIndex = 1;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(36, 448);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(93, 13);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "Search by flight #:";
            // 
            // textBoxSearchByFlightNo
            // 
            this.textBoxSearchByFlightNo.Location = new System.Drawing.Point(135, 445);
            this.textBoxSearchByFlightNo.Name = "textBoxSearchByFlightNo";
            this.textBoxSearchByFlightNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchByFlightNo.TabIndex = 3;
            this.textBoxSearchByFlightNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelSearchByDeparture
            // 
            this.labelSearchByDeparture.AutoSize = true;
            this.labelSearchByDeparture.Location = new System.Drawing.Point(266, 448);
            this.labelSearchByDeparture.Name = "labelSearchByDeparture";
            this.labelSearchByDeparture.Size = new System.Drawing.Size(125, 13);
            this.labelSearchByDeparture.TabIndex = 4;
            this.labelSearchByDeparture.Text = "Search by departure city:";
            // 
            // textBoxSearchByDeparture
            // 
            this.textBoxSearchByDeparture.Location = new System.Drawing.Point(397, 445);
            this.textBoxSearchByDeparture.Name = "textBoxSearchByDeparture";
            this.textBoxSearchByDeparture.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchByDeparture.TabIndex = 5;
            this.textBoxSearchByDeparture.TextChanged += new System.EventHandler(this.textBoxSearchByDeparture_TextChanged);
            // 
            // labelSearchByDestination
            // 
            this.labelSearchByDestination.AutoSize = true;
            this.labelSearchByDestination.Location = new System.Drawing.Point(530, 448);
            this.labelSearchByDestination.Name = "labelSearchByDestination";
            this.labelSearchByDestination.Size = new System.Drawing.Size(131, 13);
            this.labelSearchByDestination.TabIndex = 6;
            this.labelSearchByDestination.Text = "Search by destination city:";
            // 
            // textBoxSearchByDestination
            // 
            this.textBoxSearchByDestination.Location = new System.Drawing.Point(667, 445);
            this.textBoxSearchByDestination.Name = "textBoxSearchByDestination";
            this.textBoxSearchByDestination.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchByDestination.TabIndex = 7;
            this.textBoxSearchByDestination.TextChanged += new System.EventHandler(this.textBoxSearchByDestination_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Available flights:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Please, choose a flight and click Book Flight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Flights can be sorted by clicking on column headers";
            // 
            // Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 532);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearchByDestination);
            this.Controls.Add(this.labelSearchByDestination);
            this.Controls.Add(this.textBoxSearchByDeparture);
            this.Controls.Add(this.labelSearchByDeparture);
            this.Controls.Add(this.textBoxSearchByFlightNo);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.flightAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Flights";
            this.Text = "Flights";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button flightAdd;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearchByFlightNo;
        private System.Windows.Forms.Label labelSearchByDeparture;
        private System.Windows.Forms.TextBox textBoxSearchByDeparture;
        private System.Windows.Forms.Label labelSearchByDestination;
        private System.Windows.Forms.TextBox textBoxSearchByDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

