namespace GIP_Programma_JonasCassaer_MatteoSarens
{
    partial class HomeScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictemperatureicon = new System.Windows.Forms.PictureBox();
            this.pichumidityicon = new System.Windows.Forms.PictureBox();
            this.pickleinstewaardeco2icon = new System.Windows.Forms.PictureBox();
            this.picgrootstewaardeco2icon = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btngrootstemicrometer = new System.Windows.Forms.Button();
            this.btnkleinstemicrometer = new System.Windows.Forms.Button();
            this.btnhumidity = new System.Windows.Forms.Button();
            this.btntemperature = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picsettingsicon = new System.Windows.Forms.PictureBox();
            this.picprofileicon = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.dgvgegevens = new System.Windows.Forms.DataGridView();
            this.piclogonameicon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictemperatureicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichumidityicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickleinstewaardeco2icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgrootstewaardeco2icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picsettingsicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picprofileicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgegevens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogonameicon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictemperatureicon);
            this.panel1.Controls.Add(this.pichumidityicon);
            this.panel1.Controls.Add(this.pickleinstewaardeco2icon);
            this.panel1.Controls.Add(this.picgrootstewaardeco2icon);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btngrootstemicrometer);
            this.panel1.Controls.Add(this.btnkleinstemicrometer);
            this.panel1.Controls.Add(this.btnhumidity);
            this.panel1.Controls.Add(this.btntemperature);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 608);
            this.panel1.TabIndex = 2;
            // 
            // pictemperatureicon
            // 
            this.pictemperatureicon.Image = global::GIP_Programma_JonasCassaer_MatteoSarens.Properties.Resources.temperature_icon1;
            this.pictemperatureicon.Location = new System.Drawing.Point(110, 128);
            this.pictemperatureicon.Name = "pictemperatureicon";
            this.pictemperatureicon.Size = new System.Drawing.Size(48, 54);
            this.pictemperatureicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictemperatureicon.TabIndex = 12;
            this.pictemperatureicon.TabStop = false;
            // 
            // pichumidityicon
            // 
            this.pichumidityicon.Image = global::GIP_Programma_JonasCassaer_MatteoSarens.Properties.Resources.humidity_icon2;
            this.pichumidityicon.Location = new System.Drawing.Point(110, 194);
            this.pichumidityicon.Name = "pichumidityicon";
            this.pichumidityicon.Size = new System.Drawing.Size(48, 54);
            this.pichumidityicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pichumidityicon.TabIndex = 11;
            this.pichumidityicon.TabStop = false;
            // 
            // pickleinstewaardeco2icon
            // 
            this.pickleinstewaardeco2icon.Image = global::GIP_Programma_JonasCassaer_MatteoSarens.Properties.Resources.co2_icon;
            this.pickleinstewaardeco2icon.Location = new System.Drawing.Point(110, 263);
            this.pickleinstewaardeco2icon.Name = "pickleinstewaardeco2icon";
            this.pickleinstewaardeco2icon.Size = new System.Drawing.Size(48, 54);
            this.pickleinstewaardeco2icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pickleinstewaardeco2icon.TabIndex = 10;
            this.pickleinstewaardeco2icon.TabStop = false;
            // 
            // picgrootstewaardeco2icon
            // 
            this.picgrootstewaardeco2icon.Image = global::GIP_Programma_JonasCassaer_MatteoSarens.Properties.Resources.co2_icon;
            this.picgrootstewaardeco2icon.Location = new System.Drawing.Point(110, 334);
            this.picgrootstewaardeco2icon.Name = "picgrootstewaardeco2icon";
            this.picgrootstewaardeco2icon.Size = new System.Drawing.Size(48, 54);
            this.picgrootstewaardeco2icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picgrootstewaardeco2icon.TabIndex = 9;
            this.picgrootstewaardeco2icon.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 104);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btngrootstemicrometer
            // 
            this.btngrootstemicrometer.FlatAppearance.BorderSize = 0;
            this.btngrootstemicrometer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngrootstemicrometer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrootstemicrometer.ForeColor = System.Drawing.Color.White;
            this.btngrootstemicrometer.Location = new System.Drawing.Point(3, 348);
            this.btngrootstemicrometer.Name = "btngrootstemicrometer";
            this.btngrootstemicrometer.Size = new System.Drawing.Size(73, 23);
            this.btngrootstemicrometer.TabIndex = 4;
            this.btngrootstemicrometer.Text = "10 µm";
            this.btngrootstemicrometer.UseVisualStyleBackColor = true;
            // 
            // btnkleinstemicrometer
            // 
            this.btnkleinstemicrometer.FlatAppearance.BorderSize = 0;
            this.btnkleinstemicrometer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkleinstemicrometer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkleinstemicrometer.ForeColor = System.Drawing.Color.White;
            this.btnkleinstemicrometer.Location = new System.Drawing.Point(3, 273);
            this.btnkleinstemicrometer.Name = "btnkleinstemicrometer";
            this.btnkleinstemicrometer.Size = new System.Drawing.Size(73, 23);
            this.btnkleinstemicrometer.TabIndex = 3;
            this.btnkleinstemicrometer.Text = "2,5 µm";
            this.btnkleinstemicrometer.UseVisualStyleBackColor = true;
            // 
            // btnhumidity
            // 
            this.btnhumidity.FlatAppearance.BorderSize = 0;
            this.btnhumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhumidity.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhumidity.ForeColor = System.Drawing.Color.White;
            this.btnhumidity.Location = new System.Drawing.Point(7, 203);
            this.btnhumidity.Name = "btnhumidity";
            this.btnhumidity.Size = new System.Drawing.Size(73, 23);
            this.btnhumidity.TabIndex = 2;
            this.btnhumidity.Text = "Humidity";
            this.btnhumidity.UseVisualStyleBackColor = true;
            // 
            // btntemperature
            // 
            this.btntemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btntemperature.FlatAppearance.BorderSize = 0;
            this.btntemperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntemperature.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntemperature.ForeColor = System.Drawing.Color.White;
            this.btntemperature.Location = new System.Drawing.Point(0, 141);
            this.btntemperature.Name = "btntemperature";
            this.btntemperature.Size = new System.Drawing.Size(104, 23);
            this.btntemperature.TabIndex = 1;
            this.btntemperature.Text = "Temperature";
            this.btntemperature.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picsettingsicon);
            this.panel2.Controls.Add(this.picprofileicon);
            this.panel2.Location = new System.Drawing.Point(3, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 130);
            this.panel2.TabIndex = 0;
            // 
            // picsettingsicon
            // 
            this.picsettingsicon.Image = global::GIP_Programma_JonasCassaer_MatteoSarens.Properties.Resources._505_5051718_camera_settings_icon_white_social_media_marketing_blogs;
            this.picsettingsicon.Location = new System.Drawing.Point(45, 69);
            this.picsettingsicon.Name = "picsettingsicon";
            this.picsettingsicon.Size = new System.Drawing.Size(72, 61);
            this.picsettingsicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picsettingsicon.TabIndex = 1;
            this.picsettingsicon.TabStop = false;
            // 
            // picprofileicon
            // 
            this.picprofileicon.Image = global::GIP_Programma_JonasCassaer_MatteoSarens.Properties.Resources.profile_icon_white_22;
            this.picprofileicon.Location = new System.Drawing.Point(42, 0);
            this.picprofileicon.Name = "picprofileicon";
            this.picprofileicon.Size = new System.Drawing.Size(72, 61);
            this.picprofileicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picprofileicon.TabIndex = 0;
            this.picprofileicon.TabStop = false;
            // 
            // dgvgegevens
            // 
            this.dgvgegevens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgegevens.Location = new System.Drawing.Point(550, 0);
            this.dgvgegevens.Name = "dgvgegevens";
            this.dgvgegevens.Size = new System.Drawing.Size(701, 426);
            this.dgvgegevens.TabIndex = 4;
            // 
            // piclogonameicon
            // 
            this.piclogonameicon.Image = global::GIP_Programma_JonasCassaer_MatteoSarens.Properties.Resources.Dusttracker__1_;
            this.piclogonameicon.Location = new System.Drawing.Point(954, 404);
            this.piclogonameicon.Name = "piclogonameicon";
            this.piclogonameicon.Size = new System.Drawing.Size(404, 281);
            this.piclogonameicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogonameicon.TabIndex = 3;
            this.piclogonameicon.TabStop = false;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1249, 608);
            this.Controls.Add(this.dgvgegevens);
            this.Controls.Add(this.piclogonameicon);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeScreen";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictemperatureicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichumidityicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickleinstewaardeco2icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgrootstewaardeco2icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picsettingsicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picprofileicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgegevens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogonameicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox picprofileicon;
        private System.Windows.Forms.PictureBox picsettingsicon;
        private System.Windows.Forms.PictureBox piclogonameicon;
        private System.Windows.Forms.Button btngrootstemicrometer;
        private System.Windows.Forms.Button btnkleinstemicrometer;
        private System.Windows.Forms.Button btnhumidity;
        private System.Windows.Forms.Button btntemperature;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picgrootstewaardeco2icon;
        private System.Windows.Forms.DataGridView dgvgegevens;
        private System.Windows.Forms.PictureBox pictemperatureicon;
        private System.Windows.Forms.PictureBox pichumidityicon;
        private System.Windows.Forms.PictureBox pickleinstewaardeco2icon;
    }
}