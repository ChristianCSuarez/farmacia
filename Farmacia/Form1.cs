using System.Windows.Forms;

namespace Farmacia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void Confirmar_Click(object sender, EventArgs e)
        {
            string nombreM, cantidadM, tipoM, distribuidor, sucursal;
            nombreM = nombreMed.Text;
            cantidadM = cantidadMed.Text;
            tipoM = (string)tipoMed.SelectedItem;
            distribuidor = "";

            // Validación de campo lleno o vacío
            if (string.IsNullOrEmpty(nombreMed.Text))
            {
                MessageBox.Show("Por favor ingrese nombre de medicamento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tipoMed.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de medicamento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cantidadMed.Text))
            {
                MessageBox.Show("Por favor ingrese cantidad de medicamentos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rbCofarma.Checked && !rbEmpsephar.Checked && !rbCemefar.Checked)
            {
                MessageBox.Show("No seleccionó ningún distribuidor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!cbPrincipal.Checked && !cbSecundaria.Checked)
            {
                MessageBox.Show("No seleccionó ninguna sucursal", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //VALIDACION DISTRIBUIDOR
            if (rbCofarma.Checked)
            {
                distribuidor = "Cofarma";
            }
            else if (rbEmpsephar.Checked)
            {
                distribuidor = "Empsephar";
            }
            else
            {
                distribuidor = "Cemefar";
            }

            //VALIDACIÓN SUCURSAL
            if (cbPrincipal.Checked && cbSecundaria.Checked)
            {
                sucursal = "Para la farmacia situada en Calle de la Rosa n.28 y para la situada en Calle Alcazabilla n. 3";
            }
            else if (cbPrincipal.Checked)
            {
                sucursal = "Para la farmacia situada en Calle de la Rosa n.28";
            }
            else
            {
                sucursal = "Para la farmacia situada en Calle Alcazabilla n. 3";
            }

            Form2 form2 = new Form2();
            form2.Show(); // Muestra el formulario
            this.Hide();  // Oculta el formulario actual

            form2.Text = "Pedido al distribuidor: " + distribuidor; // Configura el título del formulario

            // Asigna los valores a los controles del segundo formulario

            form2.lbltxtpedido.Text = cantidadM + " unidades del " + tipoM + " " + nombreM;
            form2.lbltxtdireccion.Text = sucursal;



        }

        private void cantidadMed_TextChanged(object sender, EventArgs e)
        {

        }

        private void cantidadMed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nombreMed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

        private void Borrar_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.borrarCampos(this);
            cbPrincipal.Checked = false;
            cbSecundaria.Checked = false;
            rbCofarma.Checked = false;
            rbCemefar.Checked = false;
            rbEmpsephar.Checked = false;


        }
    }
}
