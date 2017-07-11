using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace JSON_Editor
{
    class Metodos
    {
        public Oferentes of = new Oferentes();
        public List<Oferentes> user = new List<Oferentes>();

        public void Insertar(int id, string nombre, string apellido, string direccion, string correo, string profesion, string puesto_solicitante, int salario_base, string ultimo_trabajo)
        {
            of.Id = id;
            of.Nombre = nombre;
            of.Apellido = apellido;
            of.Direccion = direccion;
            of.Correo = correo;
            of.Profesion = profesion;
            of.Puesto_solicitante = puesto_solicitante;
            of.Salario_base = salario_base;
            of.Ultimo_trabajo = ultimo_trabajo;

            user.Add(of);
        }

        public string Guardar()
        {
            if(user.Count == 0)
            {
                return "No hay datos disponibles para guardar";
            }
            else
            {
                var json = JsonConvert.SerializeObject(user);
                StreamWriter sw = new StreamWriter("./Oferentes.json", false, Encoding.UTF8);
                sw.Write(json);
                sw.Close();

                return "Datos Guardados con Exito";
            }
            
        }
    }
}
