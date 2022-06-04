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

        [Given(@"selecciono el empleado con el dni (.*)")]
        public void GivenSeleccionoElEmpleadoConElDni(string dni)
        {
            codigo = dni;
        }
        
        [When(@"selecciono la opcion eliminar")]
        public void WhenSeleccionoLaOpcionEliminar()
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
