using System;
using TechTalk.SpecFlow;
using SistemaDiagnostico.AccesoDatos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectSistemaDiagnostico
{
    [Binding]
    public class DesactivarUsuarioSteps
    {

        String resultado;
        int codigo;

        [Given(@"selecciona la casilla al lado del dni (.*)")]
        public void GivenSeleccionaLaCasillaAlLadoDelDni(int dni)
        {
            codigo = dni;
        }
        
        [When(@"haga click en el boton desactivar")]
        public void WhenHagaClickEnElBotonDesactivar()
        {
            PacienteDatos activar = new PacienteDatos();
            resultado = activar.Activar(codigo);
        }
        
        [Then(@"se visualiza un mensaje con la palabra ""(.*)""")]
        public void ThenSeVisualizaUnMensajeConLaPalabra(string p0)
        {
            Assert.AreEqual(resultado, p0);
        }
    }
}
