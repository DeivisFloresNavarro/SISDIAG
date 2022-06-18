using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDiagnostico.Negocio;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProjectSistemaDiagnostico
{
    [Binding]
    public class EliminarEmpleadoSteps
    {
        String resultado;
        String codigo;
        [Given(@"se selecciona al empleado con el dni (.*)")]
        public void GivenSeSeleccionaAlEmpleadoConElDni(string dni)
        {
            codigo = dni;
        }
        
        [When(@"Se selecciona el boton ELIMINAR")]
        public void WhenSeSeleccionaElBotonELIMINAR()
        {
            resultado = EmpleadoNegocio.Eliminar(codigo);
        }
        
        [Then(@"Se visualiza el mensaje ""(.*)""")]
        public void ThenSeVisualizaElMensaje(string p0)
        {
            Assert.AreEqual(resultado, p0);
        }
    }
}
