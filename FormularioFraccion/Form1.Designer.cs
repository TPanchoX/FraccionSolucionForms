namespace FormularioFraccion
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.lblNumerador = new System.Windows.Forms.Label();
            this.nudDenominador = new System.Windows.Forms.NumericUpDown();
            this.nudNumerador = new System.Windows.Forms.NumericUpDown();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.lblFraccion1 = new System.Windows.Forms.Label();
            this.lbln1 = new System.Windows.Forms.Label();
            this.lblDenominador = new System.Windows.Forms.Label();
            this.lblFraccion2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbld1 = new System.Windows.Forms.Label();
            this.lbln2 = new System.Windows.Forms.Label();
            this.lbld2 = new System.Windows.Forms.Label();
            this.lblnr = new System.Windows.Forms.Label();
            this.lbldr = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rbtFraccion1 = new System.Windows.Forms.RadioButton();
            this.rbtFraccion2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudDenominador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerador)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumerador
            // 
            this.lblNumerador.AutoSize = true;
            this.lblNumerador.BackColor = System.Drawing.Color.Transparent;
            this.lblNumerador.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumerador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumerador.Location = new System.Drawing.Point(24, 160);
            this.lblNumerador.Name = "lblNumerador";
            this.lblNumerador.Size = new System.Drawing.Size(201, 27);
            this.lblNumerador.TabIndex = 2;
            this.lblNumerador.Text = "Numerador (分子) :";
            // 
            // nudDenominador
            // 
            this.nudDenominador.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDenominador.Location = new System.Drawing.Point(273, 232);
            this.nudDenominador.Name = "nudDenominador";
            this.nudDenominador.Size = new System.Drawing.Size(72, 28);
            this.nudDenominador.TabIndex = 4;
            // 
            // nudNumerador
            // 
            this.nudNumerador.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumerador.Location = new System.Drawing.Point(273, 159);
            this.nudNumerador.Name = "nudNumerador";
            this.nudNumerador.Size = new System.Drawing.Size(72, 28);
            this.nudNumerador.TabIndex = 5;
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(605, 32);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(89, 70);
            this.btnSuma.TabIndex = 6;
            this.btnSuma.Text = "   +     追加";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnCat
            // 
            this.btnCat.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCat.BackgroundImage = global::FormularioFraccion.Properties.Resources.boton;
            this.btnCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCat.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCat.Location = new System.Drawing.Point(667, 203);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(114, 84);
            this.btnCat.TabIndex = 10;
            this.btnCat.Text = " Limpiar  (クリーン)";
            this.btnCat.UseVisualStyleBackColor = false;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // lblFraccion1
            // 
            this.lblFraccion1.AutoSize = true;
            this.lblFraccion1.BackColor = System.Drawing.Color.Transparent;
            this.lblFraccion1.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraccion1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFraccion1.Location = new System.Drawing.Point(192, 307);
            this.lblFraccion1.Name = "lblFraccion1";
            this.lblFraccion1.Size = new System.Drawing.Size(113, 27);
            this.lblFraccion1.TabIndex = 11;
            this.lblFraccion1.Text = "Fracción 1";
            // 
            // lbln1
            // 
            this.lbln1.AutoSize = true;
            this.lbln1.BackColor = System.Drawing.Color.Transparent;
            this.lbln1.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbln1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbln1.Location = new System.Drawing.Point(223, 381);
            this.lbln1.Name = "lbln1";
            this.lbln1.Size = new System.Drawing.Size(36, 27);
            this.lbln1.TabIndex = 12;
            this.lbln1.Text = "n1";
            this.lbln1.Click += new System.EventHandler(this.lbln1_Click);
            // 
            // lblDenominador
            // 
            this.lblDenominador.AutoSize = true;
            this.lblDenominador.BackColor = System.Drawing.Color.Transparent;
            this.lblDenominador.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenominador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDenominador.Location = new System.Drawing.Point(24, 233);
            this.lblDenominador.Name = "lblDenominador";
            this.lblDenominador.Size = new System.Drawing.Size(226, 27);
            this.lblDenominador.TabIndex = 20;
            this.lblDenominador.Text = "Denominador (分母) :";
            // 
            // lblFraccion2
            // 
            this.lblFraccion2.AutoSize = true;
            this.lblFraccion2.BackColor = System.Drawing.Color.Transparent;
            this.lblFraccion2.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraccion2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFraccion2.Location = new System.Drawing.Point(356, 307);
            this.lblFraccion2.Name = "lblFraccion2";
            this.lblFraccion2.Size = new System.Drawing.Size(113, 27);
            this.lblFraccion2.TabIndex = 21;
            this.lblFraccion2.Text = "Fracción 2";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResultado.Location = new System.Drawing.Point(567, 307);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(110, 27);
            this.lblResultado.TabIndex = 22;
            this.lblResultado.Text = "Resultado";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl4.Location = new System.Drawing.Point(208, 334);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(69, 27);
            this.lbl4.TabIndex = 23;
            this.lbl4.Text = "分数1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(590, 334);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 27);
            this.label14.TabIndex = 25;
            this.label14.Text = "結果";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(378, 334);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 27);
            this.label15.TabIndex = 26;
            this.label15.Text = "分数2";
            // 
            // lbld1
            // 
            this.lbld1.AutoSize = true;
            this.lbld1.BackColor = System.Drawing.Color.Transparent;
            this.lbld1.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbld1.Location = new System.Drawing.Point(223, 410);
            this.lbld1.Name = "lbld1";
            this.lbld1.Size = new System.Drawing.Size(36, 27);
            this.lbld1.TabIndex = 27;
            this.lbld1.Text = "d1";
            this.lbld1.Click += new System.EventHandler(this.lbld1_Click);
            // 
            // lbln2
            // 
            this.lbln2.AutoSize = true;
            this.lbln2.BackColor = System.Drawing.Color.Transparent;
            this.lbln2.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbln2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbln2.Location = new System.Drawing.Point(390, 381);
            this.lbln2.Name = "lbln2";
            this.lbln2.Size = new System.Drawing.Size(36, 27);
            this.lbln2.TabIndex = 28;
            this.lbln2.Text = "n2";
            this.lbln2.Click += new System.EventHandler(this.lbln2_Click);
            // 
            // lbld2
            // 
            this.lbld2.AutoSize = true;
            this.lbld2.BackColor = System.Drawing.Color.Transparent;
            this.lbld2.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbld2.Location = new System.Drawing.Point(390, 411);
            this.lbld2.Name = "lbld2";
            this.lbld2.Size = new System.Drawing.Size(36, 27);
            this.lbld2.TabIndex = 29;
            this.lbld2.Text = "d2";
            this.lbld2.Click += new System.EventHandler(this.lbld2_Click);
            // 
            // lblnr
            // 
            this.lblnr.AutoSize = true;
            this.lblnr.BackColor = System.Drawing.Color.Transparent;
            this.lblnr.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblnr.Location = new System.Drawing.Point(600, 381);
            this.lblnr.Name = "lblnr";
            this.lblnr.Size = new System.Drawing.Size(34, 27);
            this.lblnr.TabIndex = 30;
            this.lblnr.Text = "nr";
            // 
            // lbldr
            // 
            this.lbldr.AutoSize = true;
            this.lbldr.BackColor = System.Drawing.Color.Transparent;
            this.lbldr.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbldr.Location = new System.Drawing.Point(600, 411);
            this.lbldr.Name = "lbldr";
            this.lbldr.Size = new System.Drawing.Size(34, 27);
            this.lbldr.TabIndex = 31;
            this.lbldr.Text = "dr";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(225, 408);
            this.label13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label13.MinimumSize = new System.Drawing.Size(30, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 2);
            this.label13.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(394, 409);
            this.label16.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label16.MinimumSize = new System.Drawing.Size(30, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 2);
            this.label16.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(604, 409);
            this.label17.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label17.MinimumSize = new System.Drawing.Size(30, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 2);
            this.label17.TabIndex = 33;
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(752, 32);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(89, 70);
            this.btnResta.TabIndex = 34;
            this.btnResta.Text = "   -     減法";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.Location = new System.Drawing.Point(605, 117);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(89, 70);
            this.btnMultiplicacion.TabIndex = 35;
            this.btnMultiplicacion.Text = "   x     乗算";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(752, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 70);
            this.button4.TabIndex = 36;
            this.button4.Text = "   /     分割";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // rbtFraccion1
            // 
            this.rbtFraccion1.AutoSize = true;
            this.rbtFraccion1.BackColor = System.Drawing.Color.Transparent;
            this.rbtFraccion1.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFraccion1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtFraccion1.Location = new System.Drawing.Point(43, 71);
            this.rbtFraccion1.Name = "rbtFraccion1";
            this.rbtFraccion1.Size = new System.Drawing.Size(212, 31);
            this.rbtFraccion1.TabIndex = 37;
            this.rbtFraccion1.TabStop = true;
            this.rbtFraccion1.Text = "Fracción 1 (分数1)";
            this.rbtFraccion1.UseVisualStyleBackColor = false;
            this.rbtFraccion1.CheckedChanged += new System.EventHandler(this.rbtFraccion1_CheckedChanged);
            // 
            // rbtFraccion2
            // 
            this.rbtFraccion2.AutoSize = true;
            this.rbtFraccion2.BackColor = System.Drawing.Color.Transparent;
            this.rbtFraccion2.Font = new System.Drawing.Font("Perpetua", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFraccion2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtFraccion2.Location = new System.Drawing.Point(305, 71);
            this.rbtFraccion2.Name = "rbtFraccion2";
            this.rbtFraccion2.Size = new System.Drawing.Size(212, 31);
            this.rbtFraccion2.TabIndex = 38;
            this.rbtFraccion2.TabStop = true;
            this.rbtFraccion2.Text = "Fracción 2 (分数2)";
            this.rbtFraccion2.UseVisualStyleBackColor = false;
            this.rbtFraccion2.CheckedChanged += new System.EventHandler(this.rbtFraccion2_CheckedChanged);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::FormularioFraccion.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 502);
            this.Controls.Add(this.rbtFraccion2);
            this.Controls.Add(this.rbtFraccion1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbldr);
            this.Controls.Add(this.lblnr);
            this.Controls.Add(this.lbld2);
            this.Controls.Add(this.lbln2);
            this.Controls.Add(this.lbld1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblFraccion2);
            this.Controls.Add(this.lblDenominador);
            this.Controls.Add(this.lbln1);
            this.Controls.Add(this.lblFraccion1);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.nudNumerador);
            this.Controls.Add(this.nudDenominador);
            this.Controls.Add(this.lblNumerador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.Text = "Calculadora (電卓)";
            ((System.ComponentModel.ISupportInitialize)(this.nudDenominador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumerador;
        private System.Windows.Forms.NumericUpDown nudDenominador;
        private System.Windows.Forms.NumericUpDown nudNumerador;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Label lblFraccion1;
        private System.Windows.Forms.Label lbln1;
        private System.Windows.Forms.Label lblDenominador;
        private System.Windows.Forms.Label lblFraccion2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbld1;
        private System.Windows.Forms.Label lbln2;
        private System.Windows.Forms.Label lbld2;
        private System.Windows.Forms.Label lblnr;
        private System.Windows.Forms.Label lbldr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton rbtFraccion1;
        private System.Windows.Forms.RadioButton rbtFraccion2;
    }
}

