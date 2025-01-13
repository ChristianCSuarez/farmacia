namespace Farmacia
{
    partial class Form2
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
            lbltxtpedido = new Label();
            lbltxtdireccion = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lbltxtpedido
            // 
            lbltxtpedido.AutoSize = true;
            lbltxtpedido.Location = new Point(38, 48);
            lbltxtpedido.Name = "lbltxtpedido";
            lbltxtpedido.Size = new Size(0, 15);
            lbltxtpedido.TabIndex = 0;
            // 
            // lbltxtdireccion
            // 
            lbltxtdireccion.AutoSize = true;
            lbltxtdireccion.BorderStyle = BorderStyle.FixedSingle;
            lbltxtdireccion.Location = new Point(38, 78);
            lbltxtdireccion.Name = "lbltxtdireccion";
            lbltxtdireccion.Size = new Size(2, 17);
            lbltxtdireccion.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(33, 194);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 2;
            button1.Text = "Enviar pedido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(451, 194);
            button2.Name = "button2";
            button2.Size = new Size(114, 23);
            button2.TabIndex = 3;
            button2.Text = "Cancelar pedido";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 284);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbltxtdireccion);
            Controls.Add(lbltxtpedido);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lbltxtpedido;
        public Label lbltxtdireccion;
        private Button button1;
        private Button button2;
    }
}