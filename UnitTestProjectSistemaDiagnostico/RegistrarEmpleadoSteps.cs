using System;
using TechTalk.SpecFlow;

namespace UnitTestProjectSistemaDiagnostico
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    using SistemaDiagnostico.Negocio;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [Binding]
    public class RegistrarEmpleadoSteps
    {
        string resultado;
        string dni, nombre, apellido, cargo, direccion, celular, estado;
        [Given(@"He ingresado los datos del empleado: '(.*)','(.*)','(.*)','(.*)','(.*)','(.*)','(.*)'")]
        public void GivenHeIngresadoLosDatosDelEmpleado(string dni, string nombre, string apellido, string cargo, string direccion, string celular, string estado)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cargo = cargo;
            this.direccion = direccion;
            this.celular = celular;
            this.estado = estado;
        }
        
        [When(@"hago clic en el boton INSERTAR")]
        public void WhenHagoClicEnElBotonINSERTAR()
        {
            resultado = EmpleadoNegocio.Insertar(dni, nombre, apellido, cargo, direccion, celular, estado);
        }
        
        [Then(@"Deberia ver el mensaje '(.*)'")]
        public void ThenDeberiaVerElMensaje(string resultado)
        {
            Assert.AreEqual(this.resultado, resultado);
        }
    }
}
