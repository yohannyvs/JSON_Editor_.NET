using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Editor
{
    class Oferentes
    {

        private String nombre;
        private String apellido;
        private String direccion;
        private String correo;
        private String profesion;
        private String puesto_solicitante;
        private int salario_base;
        private String ultimo_trabajo;

        public Oferentes() { }

        public Oferentes(string nombre, string apellido, string direccion, string correo, string profesion, string puesto_solicitante, int salario_base, string ultimo_trabajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.correo = correo;
            this.profesion = profesion;
            this.puesto_solicitante = puesto_solicitante;
            this.salario_base = salario_base;
            this.ultimo_trabajo = ultimo_trabajo;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getApellido()
        {
            return this.apellido;
        }

        public string getDreccion()
        {
            return this.direccion;
        }

        public string getCorreo()
        {
            return this.correo;
        }

        public string getProfecion()
        {
            return this.profesion;
        }

        public string getPuesto_Solicitante()
        {
            return this.puesto_solicitante;
        }

        public int getSalario_Base()
        {
            return this.salario_base;
        }

        public string getUltimo_Trabajo()
        {
            return this.ultimo_trabajo;
        }
    }
}
