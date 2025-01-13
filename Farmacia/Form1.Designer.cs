namespace Farmacia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            nombreMed = new TextBox();
            label2 = new Label();
            tipoMed = new ComboBox();
            label3 = new Label();
            cantidadMed = new TextBox();
            label4 = new Label();
            rbCofarma = new RadioButton();
            rbEmpsephar = new RadioButton();
            rbCemefar = new RadioButton();
            Confirmar = new Button();
            Borrar = new Button();
            distribuidor = new GroupBox();
            cbPrincipal = new CheckBox();
            cbSecundaria = new CheckBox();
            distribuidor.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 30);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Medicamento";
            // 
            // nombreMed
            // 
            nombreMed.Location = new Point(199, 27);
            nombreMed.Name = "nombreMed";
            nombreMed.Size = new Size(242, 23);
            nombreMed.TabIndex = 1;
            nombreMed.KeyPress += nombreMed_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 72);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo de Medicamento";
            // 
            // tipoMed
            // 
            tipoMed.FormattingEnabled = true;
            tipoMed.Items.AddRange(new object[] { "Analgésico", "Analéptico", "Anestésico", "Antiácido", "Antidepresivo", "Antibióticos" });
            tipoMed.Location = new Point(199, 69);
            tipoMed.Name = "tipoMed";
            tipoMed.Size = new Size(121, 23);
            tipoMed.TabIndex = 3;
            tipoMed.Text = "Seleccionar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 113);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "Cantidad";
            label3.Click += label3_Click;
            // 
            // cantidadMed
            // 
            cantidadMed.Location = new Point(199, 110);
            cantidadMed.Name = "cantidadMed";
            cantidadMed.Size = new Size(121, 23);
            cantidadMed.TabIndex = 5;
            cantidadMed.KeyPress += cantidadMed_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 155);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Sucursal";
            // 
            // rbCofarma
            // 
            rbCofarma.AutoSize = true;
            rbCofarma.Location = new Point(6, 26);
            rbCofarma.Name = "rbCofarma";
            rbCofarma.Size = new Size(71, 19);
            rbCofarma.TabIndex = 8;
            rbCofarma.TabStop = true;
            rbCofarma.Text = "Cofarma";
            rbCofarma.UseVisualStyleBackColor = true;
            // 
            // rbEmpsephar
            // 
            rbEmpsephar.AutoSize = true;
            rbEmpsephar.Location = new Point(83, 26);
            rbEmpsephar.Name = "rbEmpsephar";
            rbEmpsephar.Size = new Size(84, 19);
            rbEmpsephar.TabIndex = 9;
            rbEmpsephar.TabStop = true;
            rbEmpsephar.Text = "Empsephar";
            rbEmpsephar.UseVisualStyleBackColor = true;
            // 
            // rbCemefar
            // 
            rbCemefar.AutoSize = true;
            rbCemefar.Location = new Point(173, 26);
            rbCemefar.Name = "rbCemefar";
            rbCemefar.Size = new Size(70, 19);
            rbCemefar.TabIndex = 10;
            rbCemefar.TabStop = true;
            rbCemefar.Text = "Cemefar";
            rbCemefar.UseVisualStyleBackColor = true;
            // 
            // Confirmar
            // 
            Confirmar.Location = new Point(46, 249);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(75, 23);
            Confirmar.TabIndex = 12;
            Confirmar.Text = "Confirmar";
            Confirmar.UseVisualStyleBackColor = true;
            Confirmar.Click += Confirmar_Click;
            // 
            // Borrar
            // 
            Borrar.Location = new Point(366, 249);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(75, 23);
            Borrar.TabIndex = 13;
            Borrar.Text = "Borrar";
            Borrar.UseVisualStyleBackColor = true;
            // 
            // distribuidor
            // 
            distribuidor.Controls.Add(rbCofarma);
            distribuidor.Controls.Add(rbEmpsephar);
            distribuidor.Controls.Add(rbCemefar);
            distribuidor.Location = new Point(46, 155);
            distribuidor.Name = "distribuidor";
            distribuidor.Size = new Size(248, 74);
            distribuidor.TabIndex = 14;
            distribuidor.TabStop = false;
            distribuidor.Text = "Distribuidor Farmacéutico";
            // 
            // cbPrincipal
            // 
            cbPrincipal.AutoSize = true;
            cbPrincipal.Location = new Point(321, 181);
            cbPrincipal.Name = "cbPrincipal";
            cbPrincipal.Size = new Size(72, 19);
            cbPrincipal.TabIndex = 15;
            cbPrincipal.Text = "Principal";
            cbPrincipal.UseVisualStyleBackColor = true;
            // 
            // cbSecundaria
            // 
            cbSecundaria.AutoSize = true;
            cbSecundaria.Location = new Point(321, 198);
            cbSecundaria.Name = "cbSecundaria";
            cbSecundaria.Size = new Size(84, 19);
            cbSecundaria.TabIndex = 16;
            cbSecundaria.Text = "Secundaria";
            cbSecundaria.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 284);
            Controls.Add(cbSecundaria);
            Controls.Add(cbPrincipal);
            Controls.Add(distribuidor);
            Controls.Add(Borrar);
            Controls.Add(Confirmar);
            Controls.Add(label4);
            Controls.Add(cantidadMed);
            Controls.Add(label3);
            Controls.Add(tipoMed);
            Controls.Add(label2);
            Controls.Add(nombreMed);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Sistema Pedido Medicamentos";
            Load += Form1_Load;
            distribuidor.ResumeLayout(false);
            distribuidor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nombreMed;
        private Label label2;
        private ComboBox tipoMed;
        private Label label3;
        private TextBox cantidadMed;
        private Label label4;
        private RadioButton rbCofarma;
        private RadioButton rbEmpsephar;
        private RadioButton rbCemefar;
        private Button Confirmar;
        private Button Borrar;
        private GroupBox distribuidor;
        private CheckBox cbPrincipal;
        private CheckBox cbSecundaria;
    }
}
