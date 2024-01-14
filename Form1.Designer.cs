namespace WeatherApp
{
    partial class Form1
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
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxTemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWindSpeed = new System.Windows.Forms.TextBox();
            this.btnShowWeather = new System.Windows.Forms.Button();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnWeek = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(570, 81);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(165, 31);
            this.txtCity.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Temp. °F";
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Location = new System.Drawing.Point(148, 35);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Size = new System.Drawing.Size(100, 20);
            this.txtMaxTemp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min Temp. °F";
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(148, 78);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(100, 20);
            this.txtMinTemp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wind Speed mph";
            // 
            // txtWindSpeed
            // 
            this.txtWindSpeed.Location = new System.Drawing.Point(148, 118);
            this.txtWindSpeed.Name = "txtWindSpeed";
            this.txtWindSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtWindSpeed.TabIndex = 7;
            // 
            // btnShowWeather
            // 
            this.btnShowWeather.Location = new System.Drawing.Point(287, 199);
            this.btnShowWeather.Name = "btnShowWeather";
            this.btnShowWeather.Size = new System.Drawing.Size(96, 38);
            this.btnShowWeather.TabIndex = 8;
            this.btnShowWeather.Text = "Show Weather";
            this.btnShowWeather.UseVisualStyleBackColor = true;
            this.btnShowWeather.Click += new System.EventHandler(this.btnShowWeather_Click);
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(148, 155);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(100, 20);
            this.txtHumidity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Humidity";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(262, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(311, 54);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 13;
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 226);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnWeek
            // 
            this.btnWeek.Location = new System.Drawing.Point(673, 485);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(103, 38);
            this.btnWeek.TabIndex = 15;
            this.btnWeek.Text = "Week";
            this.btnWeek.UseVisualStyleBackColor = true;
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(564, 486);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 37);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnWeek);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHumidity);
            this.Controls.Add(this.btnShowWeather);
            this.Controls.Add(this.txtWindSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMinTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaxTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWindSpeed;
        private System.Windows.Forms.Button btnShowWeather;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.Button btnClose;
    }
}

