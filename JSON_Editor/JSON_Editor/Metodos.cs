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
        public List<Oferentes> user = new List<Oferentes>();

        public void Insertar(int id, string nombre, string apellido, string direccion, string correo, string profesion, string puesto_solicitante, int salario_base, string ultimo_trabajo)
        {
            user.Add(new Oferentes
                (
                    id, nombre, apellido, direccion, correo, profesion, puesto_solicitante, salario_base, ultimo_trabajo
                ));
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
                StreamWriter sw = new StreamWriter("C:/JSON/Oferentes.json", false, Encoding.UTF8);
                sw.Write(json);
                sw.Close();

                return "Datos Guardados con Exito";
            }
            
        }
    }
}
