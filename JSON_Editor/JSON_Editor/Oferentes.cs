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

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getApellido()
        {
            return this.apellido;
        }

        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string getDreccion()
        {
            return this.direccion;
        }

        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }

        public string getCorreo()
        {
            return this.correo;
        }

        public void setCorreo(string correo)
        {
            this.correo = correo;
        }

        public string getProfesion()
        {
            return this.profesion;
        }

        public void setProfesion(string profesion)
        {
            this.profesion = profesion;
        }

        public string getPuesto_Solicitante()
        {
            return this.puesto_solicitante;
        }

        public void setPuesto_Solicitante(string puesto_solicitante)
        {
            this.puesto_solicitante = puesto_solicitante;
        }

        public int getSalario_Base()
        {
            return this.salario_base;
        }

        public void setSalario_Base(int salario_base)
        {
            this.salario_base = salario_base;
        }

        public string getUltimo_Trabajo()
        {
            return this.ultimo_trabajo;
        }

        public void setUltimo_Trabajo(string ultimo_trabajo)
        {
            this.ultimo_trabajo = ultimo_trabajo;
        }
    }
}
