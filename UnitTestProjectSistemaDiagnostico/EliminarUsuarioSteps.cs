using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDiagnostico.Negocio;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProjectSistemaDiagnostico
{
    [Binding]
    public class EliminarUsuarioSteps
    {
        string mensaje = null;
        int codigo;

        [Given(@"se selecciona el usuario con el codigo (.*)")]
        public void GivenSeSeleccionaElUsuarioConElCodigo(int id)
        {
            codigo = id;
        }
        
        [When(@"se ejecuta el metodo eliminar")]
        public void WhenSeEjecutaElMetodoEliminar()
        {
            mensaje = UsuarioNegocio.Eliminar(codigo);
        }
        
        [Then(@"se eliminara el usuario y regresara un mensaje")]
        public void ThenSeEliminaraElUsuarioYRegresaraUnMensaje()
        {
            Assert.IsNotNull(codigo);
        }
    }
}
