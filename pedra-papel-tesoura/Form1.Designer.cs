namespace pedra_papel_tesoura
{
    partial class JOKENPO
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JOKENPO));
            this.buttonTESOURA = new System.Windows.Forms.Button();
            this.buttonPAPEL = new System.Windows.Forms.Button();
            this.v = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.labelIGUAL = new System.Windows.Forms.Label();
            this.pictureVOCE = new System.Windows.Forms.PictureBox();
            this.picturePC = new System.Windows.Forms.PictureBox();
            this.pictureRESULTADO = new System.Windows.Forms.PictureBox();
            this.labelVOCE = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVOCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRESULTADO)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTESOURA
            // 
            this.buttonTESOURA.BackgroundImage = global::pedra_papel_tesoura.Properties.Resources.Tesoura;
            this.buttonTESOURA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTESOURA.Location = new System.Drawing.Point(464, 207);
            this.buttonTESOURA.Name = "buttonTESOURA";
            this.buttonTESOURA.Size = new System.Drawing.Size(135, 107);
            this.buttonTESOURA.TabIndex = 3;
            this.buttonTESOURA.UseVisualStyleBackColor = true;
            this.buttonTESOURA.Click += new System.EventHandler(this.buttonTESOURA_Click);
            // 
            // buttonPAPEL
            // 
            this.buttonPAPEL.BackgroundImage = global::pedra_papel_tesoura.Properties.Resources.Papel;
            this.buttonPAPEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPAPEL.Location = new System.Drawing.Point(276, 207);
            this.buttonPAPEL.Name = "buttonPAPEL";
            this.buttonPAPEL.Size = new System.Drawing.Size(135, 107);
            this.buttonPAPEL.TabIndex = 4;
            this.buttonPAPEL.UseVisualStyleBackColor = true;
            this.buttonPAPEL.Click += new System.EventHandler(this.buttonPAPEL_Click);
            // 
            // v
            // 
            this.v.BackgroundImage = global::pedra_papel_tesoura.Properties.Resources.Pedra;
            this.v.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.v.Location = new System.Drawing.Point(80, 207);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(135, 107);
            this.v.TabIndex = 5;
            this.v.UseVisualStyleBackColor = true;
            this.v.Click += new System.EventHandler(this.buttonPEDRA_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.BackColor = System.Drawing.Color.Transparent;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelX.Location = new System.Drawing.Point(235, 83);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(26, 25);
            this.labelX.TabIndex = 6;
            this.labelX.Text = "X";
            // 
            // labelIGUAL
            // 
            this.labelIGUAL.AutoSize = true;
            this.labelIGUAL.BackColor = System.Drawing.Color.Transparent;
            this.labelIGUAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIGUAL.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelIGUAL.Location = new System.Drawing.Point(426, 83);
            this.labelIGUAL.Name = "labelIGUAL";
            this.labelIGUAL.Size = new System.Drawing.Size(24, 25);
            this.labelIGUAL.TabIndex = 7;
            this.labelIGUAL.Text = "=";
            this.labelIGUAL.Click += new System.EventHandler(this.labelIGUAL_Click);
            // 
            // pictureVOCE
            // 
            this.pictureVOCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureVOCE.Location = new System.Drawing.Point(80, 41);
            this.pictureVOCE.Name = "pictureVOCE";
            this.pictureVOCE.Size = new System.Drawing.Size(135, 109);
            this.pictureVOCE.TabIndex = 8;
            this.pictureVOCE.TabStop = false;
            // 
            // picturePC
            // 
            this.picturePC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturePC.Location = new System.Drawing.Point(276, 41);
            this.picturePC.Name = "picturePC";
            this.picturePC.Size = new System.Drawing.Size(135, 109);
            this.picturePC.TabIndex = 9;
            this.picturePC.TabStop = false;
            // 
            // pictureRESULTADO
            // 
            this.pictureRESULTADO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureRESULTADO.Location = new System.Drawing.Point(464, 41);
            this.pictureRESULTADO.Name = "pictureRESULTADO";
            this.pictureRESULTADO.Size = new System.Drawing.Size(135, 109);
            this.pictureRESULTADO.TabIndex = 10;
            this.pictureRESULTADO.TabStop = false;
            // 
            // labelVOCE
            // 
            this.labelVOCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVOCE.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelVOCE.Location = new System.Drawing.Point(110, 19);
            this.labelVOCE.Name = "labelVOCE";
            this.labelVOCE.Size = new System.Drawing.Size(75, 23);
            this.labelVOCE.TabIndex = 11;
            this.labelVOCE.Text = "Você";
            this.labelVOCE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(309, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pc";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(110, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pedra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(316, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Papel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(501, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tesoura";
            // 
            // JOKENPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 378);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelVOCE);
            this.Controls.Add(this.pictureRESULTADO);
            this.Controls.Add(this.picturePC);
            this.Controls.Add(this.pictureVOCE);
            this.Controls.Add(this.labelIGUAL);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.v);
            this.Controls.Add(this.buttonPAPEL);
            this.Controls.Add(this.buttonTESOURA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JOKENPO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JOKENPO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureVOCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRESULTADO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonTESOURA;
        private System.Windows.Forms.Button buttonPAPEL;
        private System.Windows.Forms.Button v;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelIGUAL;
        private System.Windows.Forms.PictureBox pictureVOCE;
        private System.Windows.Forms.PictureBox picturePC;
        private System.Windows.Forms.PictureBox pictureRESULTADO;
        private System.Windows.Forms.Label labelVOCE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

