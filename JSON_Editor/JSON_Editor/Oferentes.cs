using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Editor
{
    class Oferentes
    {
        private int id;
        private String nombre;
        private String apellido;
        private String direccion;
        private String correo;
        private String profesion;
        private String puesto_solicitante;
        private int salario_base;
        private String ultimo_trabajo;

        public Oferentes() { }

        public Oferentes(int id, string nombre, string apellido, string direccion, string correo, string profesion, string puesto_solicitante, int salario_base, string ultimo_trabajo)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.correo = correo;
            this.profesion = profesion;
            this.puesto_solicitante = puesto_solicitante;
            this.salario_base = salario_base;
            this.ultimo_trabajo = ultimo_trabajo;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Profesion { get => profesion; set => profesion = value; }
        public string Puesto_solicitante { get => puesto_solicitante; set => puesto_solicitante = value; }
        public int Salario_base { get => salario_base; set => salario_base = value; }
        public string Ultimo_trabajo { get => ultimo_trabajo; set => ultimo_trabajo = value; }
        
    }
}
