using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDiagnostico.Negocio;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProjectSistemaDiagnostico
{
    [Binding]
    public class RegistrarUsuarioSteps
    {
        string DNI, usuario, clave, estado;
        string resultado = null;
        [Given(@"selecciona la pestaña usuario")]
        public void GivenSeleccionaLaPestanaUsuario()
        {
            
        }
        
        [Given(@"ingresa los datos del usuario ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void GivenIngresaLosDatosDelUsuario(string dni, string usu, string cla, string est)
        {
            DNI = dni;
            usuario = usu;
            clave = cla;
            estado = est;

        }
        
        [When(@"se presiona el boton insertar")]
        public void WhenSePresionaElBotonInsertar()
        {
            resultado = UsuarioNegocio.Insertar(DNI, usuario, clave, estado);
        }
        
        [Then(@"se registra y se visualiza una ventana con un mensaje")]
        public void ThenSeRegistraYSeVisualizaUnaVentanaConUnMensaje()
        {
            Assert.IsNotNull(resultado); 
        }
    }
}
