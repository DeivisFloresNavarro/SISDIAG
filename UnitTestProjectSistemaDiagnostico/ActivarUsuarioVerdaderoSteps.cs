using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDiagnostico.Negocio;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProjectSistemaDiagnostico
{
    [Binding]
    public class ActivarUsuarioVerdaderoSteps
    {
        String resultado;
        int codigo;
        [Given(@"Selecciono la casilla al lado del codigo (.*)")]
        public void GivenSeleccionoLaCasillaAlLadoDelCodigo(int p0)
        {
            codigo = p0;
        }
        
        [When(@"se selecciona activar")]
        public void WhenSeSeleccionaActivar()
        {
            resultado = UsuarioNegocio.Activar(codigo);
        }
        
        [Then(@"se recibe un mensaje de confirmacion ""(.*)""")]
        public void ThenSeRecibeUnMensajeDeConfirmacion(string p0)
        {
            Assert.AreEqual(resultado, p0);
        }
    }
}
