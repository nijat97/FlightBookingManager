namespace FlightManager
{
    partial class NewBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonBook = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.labelLuggage = new System.Windows.Forms.Label();
            this.buttonAddLuggage = new System.Windows.Forms.Button();
            this.checkBoxBusiness = new System.Windows.Forms.CheckBox();
            this.checkBoxStudent = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxEntertainment = new System.Windows.Forms.CheckBox();
            this.checkBoxLunch = new System.Windows.Forms.CheckBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonRemoveLuggage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passport No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Luggage (max 3, each 20kg):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Business class:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Student:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total price:";
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(339, 363);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(75, 23);
            this.buttonBook.TabIndex = 7;
            this.buttonBook.Text = "Book";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(71, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(85, 93);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 9;
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.Location = new System.Drawing.Point(101, 131);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassport.TabIndex = 10;
            // 
            // labelLuggage
            // 
            this.labelLuggage.AutoSize = true;
            this.labelLuggage.Location = new System.Drawing.Point(172, 172);
            this.labelLuggage.Name = "labelLuggage";
            this.labelLuggage.Size = new System.Drawing.Size(13, 13);
            this.labelLuggage.TabIndex = 11;
            this.labelLuggage.Text = "0";
            // 
            // buttonAddLuggage
            // 
            this.buttonAddLuggage.Location = new System.Drawing.Point(191, 167);
            this.buttonAddLuggage.Name = "buttonAddLuggage";
            this.buttonAddLuggage.Size = new System.Drawing.Size(75, 23);
            this.buttonAddLuggage.TabIndex = 12;
            this.buttonAddLuggage.Text = "Add";
            this.buttonAddLuggage.UseVisualStyleBackColor = true;
            this.buttonAddLuggage.Click += new System.EventHandler(this.buttonAddLuggage_Click);
            // 
            // checkBoxBusiness
            // 
            this.checkBoxBusiness.AutoSize = true;
            this.checkBoxBusiness.Location = new System.Drawing.Point(112, 210);
            this.checkBoxBusiness.Name = "checkBoxBusiness";
            this.checkBoxBusiness.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBusiness.TabIndex = 13;
            this.checkBoxBusiness.UseVisualStyleBackColor = true;
            this.checkBoxBusiness.CheckedChanged += new System.EventHandler(this.checkBoxBusiness_CheckedChanged);
            // 
            // checkBoxStudent
            // 
            this.checkBoxStudent.AutoSize = true;
            this.checkBoxStudent.Location = new System.Drawing.Point(80, 248);
            this.checkBoxStudent.Name = "checkBoxStudent";
            this.checkBoxStudent.Size = new System.Drawing.Size(15, 14);
            this.checkBoxStudent.TabIndex = 14;
            this.checkBoxStudent.UseVisualStyleBackColor = true;
            this.checkBoxStudent.CheckedChanged += new System.EventHandler(this.checkBoxStudent_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "InFlight Entertainment:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Lunch Menu:";
            // 
            // checkBoxEntertainment
            // 
            this.checkBoxEntertainment.AutoSize = true;
            this.checkBoxEntertainment.Location = new System.Drawing.Point(137, 285);
            this.checkBoxEntertainment.Name = "checkBoxEntertainment";
            this.checkBoxEntertainment.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEntertainment.TabIndex = 17;
            this.checkBoxEntertainment.UseVisualStyleBackColor = true;
            this.checkBoxEntertainment.CheckedChanged += new System.EventHandler(this.checkBoxEntertainment_CheckedChanged);
            // 
            // checkBoxLunch
            // 
            this.checkBoxLunch.AutoSize = true;
            this.checkBoxLunch.Location = new System.Drawing.Point(97, 324);
            this.checkBoxLunch.Name = "checkBoxLunch";
            this.checkBoxLunch.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLunch.TabIndex = 18;
            this.checkBoxLunch.UseVisualStyleBackColor = true;
            this.checkBoxLunch.CheckedChanged += new System.EventHandler(this.checkBoxLunch_CheckedChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(86, 368);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(13, 13);
            this.labelPrice.TabIndex = 19;
            this.labelPrice.Text = "0";
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(27, 22);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 13);
            this.labelInfo.TabIndex = 20;
            // 
            // buttonRemoveLuggage
            // 
            this.buttonRemoveLuggage.Location = new System.Drawing.Point(272, 167);
            this.buttonRemoveLuggage.Name = "buttonRemoveLuggage";
            this.buttonRemoveLuggage.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveLuggage.TabIndex = 21;
            this.buttonRemoveLuggage.Text = "Remove";
            this.buttonRemoveLuggage.UseVisualStyleBackColor = true;
            this.buttonRemoveLuggage.Click += new System.EventHandler(this.buttonRemoveLuggage_Click);
            // 
            // NewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 396);
            this.Controls.Add(this.buttonRemoveLuggage);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.checkBoxLunch);
            this.Controls.Add(this.checkBoxEntertainment);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBoxStudent);
            this.Controls.Add(this.checkBoxBusiness);
            this.Controls.Add(this.buttonAddLuggage);
            this.Controls.Add(this.labelLuggage);
            this.Controls.Add(this.textBoxPassport);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewBooking";
            this.Text = "NewBooking";
            this.Load += new System.EventHandler(this.NewBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPassport;
        private System.Windows.Forms.Label labelLuggage;
        private System.Windows.Forms.Button buttonAddLuggage;
        private System.Windows.Forms.CheckBox checkBoxBusiness;
        private System.Windows.Forms.CheckBox checkBoxStudent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxEntertainment;
        private System.Windows.Forms.CheckBox checkBoxLunch;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonRemoveLuggage;
    }
}