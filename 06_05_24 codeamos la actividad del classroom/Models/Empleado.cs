using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_05_24_codeamos_la_actividad_del_classroom.Models
{   //creo la clase
    internal class Empleado
    {
        //creo los atributos
        public string nombre;
        public string apellido;
        public DateTime fechaNacimiento;
        public int numDocumento;
        public TipoDoc tipoDocumento;
        public Puesto puesto;

        //creo el constructor sin parametros
        public Empleado() { }
        
        //creo el constructor con parametros
        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, int numDocumento, TipoDoc tipoDocumento, Puesto puesto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.numDocumento = numDocumento;
            this.tipoDocumento = tipoDocumento;
            this.puesto = puesto;
        }

        //metodos getter setter (metodos basicos que tienen que estar)
        public string getNombre() { return nombre; }
        public void setNombre(string nombre) { this.nombre = nombre; }

        public string getApellido() {  return apellido; }
        public void setApellido(string apellido) { this.apellido = apellido; }

        public DateTime getFechaNacimiento() {  return fechaNacimiento; }
        public void setFechaNacimiento(DateTime fechaNacimiento) { this.fechaNacimiento=fechaNacimiento; }
        
        public int getNumDocumento() {  return numDocumento; }        
        public void setNumDocumento(int numDocumento) { this.numDocumento=numDocumento; }

        public TipoDoc getTipoDocumento() { return tipoDocumento; }
        public void setTipoDocumento(int tipoDocumento) { this.tipoDocumento=tipoDocumento; }

        public Puesto getPuesto() { return puesto; }
        public void setPuesto(string puesto) { this.puesto = puesto; }


    }
    
}
