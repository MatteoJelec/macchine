namespace macchine
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.bgwBlackCar = new System.ComponentModel.BackgroundWorker();
            this.bgwRedCar = new System.ComponentModel.BackgroundWorker();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Btn_Rivincita = new System.Windows.Forms.Button();
            this.pctbBlackCar = new System.Windows.Forms.PictureBox();
            this.pctbRedCar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctbBlackCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRedCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bgwBlackCar
            // 
            this.bgwBlackCar.WorkerReportsProgress = true;
            this.bgwBlackCar.WorkerSupportsCancellation = true;
            this.bgwBlackCar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBlackCar_DoWork);
            this.bgwBlackCar.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwBlackCar_ProgressChanged);
            this.bgwBlackCar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwBlackCar_RunWorkerCompleted);
            // 
            // bgwRedCar
            // 
            this.bgwRedCar.WorkerReportsProgress = true;
            this.bgwRedCar.WorkerSupportsCancellation = true;
            this.bgwRedCar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBlackCar_DoWork);
            this.bgwRedCar.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwBlackCar_ProgressChanged);
            this.bgwRedCar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwBlackCar_RunWorkerCompleted);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(259, 28);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(108, 49);
            this.Btn_Start.TabIndex = 5;
            this.Btn_Start.Text = "START";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Btn_Rivincita
            // 
            this.Btn_Rivincita.Location = new System.Drawing.Point(395, 28);
            this.Btn_Rivincita.Name = "Btn_Rivincita";
            this.Btn_Rivincita.Size = new System.Drawing.Size(109, 48);
            this.Btn_Rivincita.TabIndex = 6;
            this.Btn_Rivincita.Text = "RIVINCITA";
            this.Btn_Rivincita.UseVisualStyleBackColor = true;
            this.Btn_Rivincita.Click += new System.EventHandler(this.Btn_Rivincita_Click);
            // 
            // pctbBlackCar
            // 
            this.pctbBlackCar.Image = global::macchine.Properties.Resources.macchinabianca;
            this.pctbBlackCar.Location = new System.Drawing.Point(12, 140);
            this.pctbBlackCar.Name = "pctbBlackCar";
            this.pctbBlackCar.Size = new System.Drawing.Size(133, 74);
            this.pctbBlackCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbBlackCar.TabIndex = 4;
            this.pctbBlackCar.TabStop = false;
            // 
            // pctbRedCar
            // 
            this.pctbRedCar.Image = global::macchine.Properties.Resources.macchinarossa;
            this.pctbRedCar.Location = new System.Drawing.Point(12, 309);
            this.pctbRedCar.Name = "pctbRedCar";
            this.pctbRedCar.Size = new System.Drawing.Size(144, 74);
            this.pctbRedCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbRedCar.TabIndex = 3;
            this.pctbRedCar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::macchine.Properties.Resources.road_trip_background_10864211;
            this.pictureBox1.Location = new System.Drawing.Point(12, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 450);
            this.Controls.Add(this.Btn_Rivincita);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.pctbBlackCar);
            this.Controls.Add(this.pctbRedCar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctbBlackCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRedCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker bgwBlackCar;
        private System.ComponentModel.BackgroundWorker bgwRedCar;
        private System.Windows.Forms.PictureBox pctbRedCar;
        private System.Windows.Forms.PictureBox pctbBlackCar;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_Rivincita;
    }
}

