using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDiagnostico.Negocio;

namespace UnitTestProjectSistemaDiagnostico
{
    [Binding]
    public class RegistrarPacienteSteps
    {

        string resultado = null;
        string dni, nombre, apellido, sexo, direccion, celular, estado;

        [Given(@"selecciona la pestaña mantenimiento")]
        public void GivenSeleccionaLaPestanaMantenimiento()
        {
            
        }
        
        [Given(@"ingresa los datos del paciente ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void GivenIngresaLosDatosDelPaciente(string p0, string p1, string p2, string p3, string p4, string p5, string p6)
        {
            dni = p0;
            nombre = p1;
            apellido = p2;
            sexo = p3;
            direccion = p4;
            celular = p5;
            estado = p6;
        }
        
        [When(@"presiona el boton insertar")]
        public void WhenPresionaElBotonInsertar()
        {
            resultado = PacienteNegocio.Insertar(dni, nombre, apellido, sexo, direccion, celular, estado);
        }
        
        [Then(@"visualiza una ventana con un mensaje")]
        public void ThenVisualizaUnaVentanaConUnMensaje()
        {
            Assert.IsNotNull(resultado);
            /*te esta devolviendo dos posibles mensajes*/
        }
    }
}
