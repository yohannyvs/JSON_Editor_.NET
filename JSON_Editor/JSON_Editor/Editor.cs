using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSON_Editor
{
    public partial class Editor : Form
    {

        Metodos m = new Metodos();

        public Editor()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(m.Guardar());
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            string direccion = txt_direccion.Text;
            string correo = txt_correo.Text;
            string profesion = txt_prof.Text;
            string puesto_solicitante = txt_puest_sol.Text;
            int salario_base = Convert.ToInt32(txt_sal_base.Text);
            string ultimo_trabajo = txt_ult_trab.Text;

            m.Insertar(id, nombre, apellido, direccion, correo, profesion, puesto_solicitante, salario_base, ultimo_trabajo);

            MessageBox.Show("Datos Ingresados con Exito");
        }
    }
}
