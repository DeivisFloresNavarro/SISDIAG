using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDiagnostico.Negocio;

namespace UnitTestProjectSistemaDiagnostico
{
    [Binding]
    public class ActualizarPacienteSteps
    {

        string resultado = null;
        string dni, nombre, apellido, sexo, direccion, celular, estado;


        [Given(@"hace doble click en un pacinete listado")]
        public void GivenHaceDobleClickEnUnPacineteListado()
        {
            
        }
        
        [Given(@"modifica algunos de los datos del paciente ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void GivenModificaAlgunosDeLosDatosDelPaciente(string p0, string p1, string p2, string p3, string p4, string p5, string p6)
        {
            dni = p0;
            nombre = p1;
            apellido = p2;
            sexo = p3;
            direccion = p4;
            celular = p5;
            estado = p6;
        }
        
        [When(@"presiona el boton actualizar")]
        public void WhenPresionaElBotonActualizar()
        {
            resultado = PacienteNegocio.Actualizar(dni, nombre, apellido, sexo, direccion, celular, estado);
        }
        
        [Then(@"Visualiza un ventana con un mensaje")]
        public void ThenVisualizaUnVentanaConUnMensaje()
        {
            Assert.IsNotNull(resultado);
            /*te esta devolviendo dos posibles mensajes*/
        }
    }
}
