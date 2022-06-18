using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDiagnostico.Negocio;

namespace UnitTestProjectSistemaDiagnostico
{
    [Binding]
    public class ActivarUsuarioSteps
    {

        String resultado;
        int codigo;

        [Given(@"Selecciono la casilla al lado del dni (.*)")]
        public void GivenSeleccionoLaCasillaAlLadoDelDni(int dni)
        {
            codigo = dni;
        }
        
        [When(@"hago click en el boton activar")]
        public void WhenHagoClickEnElBotonActivar()
        {
            resultado = PacienteNegocio.Activar(codigo);
        }
        
        [Then(@"se un mensaje de confirmacion ""(.*)""")]
        public void ThenSeUnMensajeDeConfirmacion(string p0)
        {
            Assert.AreEqual(resultado, p0);
        }
    }
}
