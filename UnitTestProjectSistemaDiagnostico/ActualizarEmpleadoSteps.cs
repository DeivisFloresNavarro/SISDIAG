using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDiagnostico.Negocio;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProjectSistemaDiagnostico
{
    [Binding]
    public class ActualizarEmpleadoSteps
    {
        string resultado = null;
        string dni, nombre, apellido, cargo, direccion, celular, estado;

        [Given(@"He ingresado los datos del empleado a modificar ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void GivenHeIngresadoLosDatosDelEmpleadoAModificar(string dni, string nombre, string apellido, string cargo, string direccion, string celular, string estado)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cargo = cargo;
            this.direccion = direccion;
            this.celular = celular;
            this.estado = estado;
        }
        
        [When(@"Hago clic en el botón ACTUALIZAR")]
        public void WhenHagoClicEnElBotonACTUALIZAR()
        {
            resultado = EmpleadoNegocio.Actualizar(dni, nombre, apellido, cargo, direccion, celular, estado);
        }
        
        [Then(@"Deberia dar el mensaje '(.*)'")]
        public void ThenDeberiaDarElMensaje(string resultado)
        {
            Assert.AreEqual(this.resultado, resultado);
        }
    }
}
