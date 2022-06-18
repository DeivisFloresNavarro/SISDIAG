using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDiagnostico.AccesoDatos;

namespace UnitTestProjectSistemaDiagnostico
{
    [Binding]
    public class EliminarPacienteSteps
    {

        String resultado;
        String codigo;

        [Given(@"selecciono la casilla al lado del dni (.*)")]
        public void GivenSeleccionoLaCasillaAlLadoDelDni(String dni)
        {
            codigo = dni;
        }
        
        [When(@"hago click en el boton eliminar")]
        public void WhenHagoClickEnElBotonEliminar()
        {
            PacienteDatos eliminar = new PacienteDatos();
            resultado = eliminar.Eliminar(codigo);
        }
        
        [Then(@"Se visualiza un mensaje con la palabra ""(.*)""")]
        public void ThenSeVisualizaUnMensajeConLaPalabra(string p0)
        {
            Assert.AreEqual(resultado, p0);
        }
    }
}
