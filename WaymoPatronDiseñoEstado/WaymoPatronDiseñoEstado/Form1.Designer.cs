using System;

namespace WaymoPatronDiseñoEstado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblEstado = new System.Windows.Forms.Label();
            this.panelRoad = new System.Windows.Forms.Panel();
            this.picDestino = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picAlto = new System.Windows.Forms.PictureBox();
            this.picObstaculo = new System.Windows.Forms.PictureBox();
            this.picCarro = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBateria = new System.Windows.Forms.Label();
            this.picSemaforo = new System.Windows.Forms.PictureBox();
            this.picPeaton = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panelRoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstaculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPeaton)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(604, 26);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 27);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // panelRoad
            // 
            this.panelRoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelRoad.Controls.Add(this.panel11);
            this.panelRoad.Controls.Add(this.picDestino);
            this.panelRoad.Controls.Add(this.panel9);
            this.panelRoad.Controls.Add(this.panel8);
            this.panelRoad.Controls.Add(this.panel7);
            this.panelRoad.Controls.Add(this.panel6);
            this.panelRoad.Controls.Add(this.panel5);
            this.panelRoad.Controls.Add(this.panel4);
            this.panelRoad.Controls.Add(this.panel3);
            this.panelRoad.Controls.Add(this.panel2);
            this.panelRoad.Controls.Add(this.picAlto);
            this.panelRoad.Controls.Add(this.picObstaculo);
            this.panelRoad.Controls.Add(this.picCarro);
            this.panelRoad.Location = new System.Drawing.Point(-5, 156);
            this.panelRoad.Name = "panelRoad";
            this.panelRoad.Size = new System.Drawing.Size(1336, 155);
            this.panelRoad.TabIndex = 6;
            this.panelRoad.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCarretera_Paint);
            // 
            // picDestino
            // 
            this.picDestino.BackgroundImage = global::WaymoPatronDiseñoEstado.Properties.Resources.meta1;
            this.picDestino.Location = new System.Drawing.Point(1285, 0);
            this.picDestino.Name = "picDestino";
            this.picDestino.Size = new System.Drawing.Size(48, 155);
            this.picDestino.TabIndex = 13;
            this.picDestino.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel9.Location = new System.Drawing.Point(614, 136);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(47, 11);
            this.panel9.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel8.Location = new System.Drawing.Point(614, 119);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(47, 11);
            this.panel8.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel7.Location = new System.Drawing.Point(614, 102);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(47, 11);
            this.panel7.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel6.Location = new System.Drawing.Point(614, 85);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(47, 11);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Location = new System.Drawing.Point(614, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(47, 11);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Location = new System.Drawing.Point(614, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(47, 11);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Location = new System.Drawing.Point(614, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(47, 11);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(614, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(47, 11);
            this.panel2.TabIndex = 4;
            // 
            // picAlto
            // 
            this.picAlto.BackgroundImage = global::WaymoPatronDiseñoEstado.Properties.Resources.stooop__1_;
            this.picAlto.Location = new System.Drawing.Point(349, 0);
            this.picAlto.Name = "picAlto";
            this.picAlto.Size = new System.Drawing.Size(40, 42);
            this.picAlto.TabIndex = 2;
            this.picAlto.TabStop = false;
            this.picAlto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picObstaculo
            // 
            this.picObstaculo.BackgroundImage = global::WaymoPatronDiseñoEstado.Properties.Resources.waaarning__1_;
            this.picObstaculo.Location = new System.Drawing.Point(997, 112);
            this.picObstaculo.Name = "picObstaculo";
            this.picObstaculo.Size = new System.Drawing.Size(100, 43);
            this.picObstaculo.TabIndex = 1;
            this.picObstaculo.TabStop = false;
            this.picObstaculo.Click += new System.EventHandler(this.picObstaculo_Click);
            // 
            // picCarro
            // 
            this.picCarro.BackgroundImage = global::WaymoPatronDiseñoEstado.Properties.Resources.carrooo__1_;
            this.picCarro.Location = new System.Drawing.Point(17, 102);
            this.picCarro.Name = "picCarro";
            this.picCarro.Size = new System.Drawing.Size(84, 45);
            this.picCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarro.TabIndex = 0;
            this.picCarro.TabStop = false;
            this.picCarro.Click += new System.EventHandler(this.picCarro_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(15, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(81, 31);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(117, 12);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(81, 31);
            this.btnReiniciar.TabIndex = 9;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(609, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 11);
            this.panel1.TabIndex = 3;
            // 
            // lblBateria
            // 
            this.lblBateria.AutoSize = true;
            this.lblBateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBateria.Location = new System.Drawing.Point(606, 65);
            this.lblBateria.Name = "lblBateria";
            this.lblBateria.Size = new System.Drawing.Size(0, 15);
            this.lblBateria.TabIndex = 12;
            this.lblBateria.Click += new System.EventHandler(this.lblBateria_Click);
            // 
            // picSemaforo
            // 
            this.picSemaforo.BackgroundImage = global::WaymoPatronDiseñoEstado.Properties.Resources.semaforo__1_;
            this.picSemaforo.Location = new System.Drawing.Point(133, 55);
            this.picSemaforo.Name = "picSemaforo";
            this.picSemaforo.Size = new System.Drawing.Size(50, 103);
            this.picSemaforo.TabIndex = 11;
            this.picSemaforo.TabStop = false;
            // 
            // picPeaton
            // 
            this.picPeaton.BackgroundImage = global::WaymoPatronDiseñoEstado.Properties.Resources.peaton__2_1;
            this.picPeaton.Location = new System.Drawing.Point(612, 94);
            this.picPeaton.Name = "picPeaton";
            this.picPeaton.Size = new System.Drawing.Size(41, 70);
            this.picPeaton.TabIndex = 10;
            this.picPeaton.TabStop = false;
            this.picPeaton.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel11.Location = new System.Drawing.Point(333, 86);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 62);
            this.panel11.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1325, 478);
            this.Controls.Add(this.lblBateria);
            this.Controls.Add(this.picSemaforo);
            this.Controls.Add(this.picPeaton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.panelRoad);
            this.Controls.Add(this.lblEstado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelRoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstaculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPeaton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Panel panelRoad;
        public System.Windows.Forms.PictureBox picCarro;
        private System.Windows.Forms.PictureBox picObstaculo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox picAlto;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPeaton;
        private System.Windows.Forms.PictureBox picSemaforo;
        private System.Windows.Forms.Label lblBateria;
        private System.Windows.Forms.PictureBox picDestino;
        private System.Windows.Forms.Panel panel11;

        public EventHandler Form1_Load { get; private set; }
    }
}

