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
        Oferentes of = new Oferentes();
        List<Oferentes> user = new List<Oferentes>();

        public void insertar(int id, string nombre, string apellido, string direccion, string correo, string profesion, string puesto_solicitante, int salario_base, string ultimo_trabajo)
        {
            of.setId(id);
            of.setNombre(nombre);
            of.setApellido(apellido);
            of.setDireccion(direccion);
            of.setCorreo(correo);
            of.setProfesion(profesion);
            of.setPuesto_Solicitante(puesto_solicitante);
            of.setSalario_Base(salario_base);
            of.setUltimo_Trabajo(ultimo_trabajo);

            user.Add(of);
        }

        public string guardar()
        {
            if(user.Count == 0)
            {
                return "No hay datos disponibles para guardar";
            }
            else
            {
                string json = JsonConvert.SerializeObject(user);
                StreamWriter sw = new StreamWriter("./Oferentes.json", false, Encoding.UTF8);
                sw.Write(json);
                sw.Close();

                return "Datos Guardados con Exito";
            }
            
        }
    }
}
