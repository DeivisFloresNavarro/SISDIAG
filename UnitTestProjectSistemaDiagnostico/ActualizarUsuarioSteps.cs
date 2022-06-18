using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDiagnostico.Negocio;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProjectSistemaDiagnostico
{
    [Binding]
    public class ActualizarUsuarioSteps
    {
        string resultado = null;
        string dni, usuario, clave, estado;
        int codigo;
        [Given(@"se selecciona al paciente listado")]
        public void GivenSeSeleccionaAlPacienteListado()
        {
            
        }
        
        [Given(@"se modifica los datos por los siguientes ""(.*)"", ""(.*)"" , ""(.*)"", ""(.*)"", ""(.*)""")]
        public void GivenSeModificaLosDatosPorLosSiguientes(int p0, string p1, string p2, string p3, string p4)
        {
            codigo = p0;
            dni = p1;
            usuario = p2;
            clave = p3;
            estado = p4;

        }
        
        [When(@"se selecciona el boton actualizar")]
        public void WhenSeSeleccionaElBotonActualizar()
        {
            resultado = UsuarioNegocio.Actualizar(codigo,dni,usuario,clave,estado);
        }
        
        [Then(@"se realiza el cambio y regresa un mensaje")]
        public void ThenSeRealizaElCambioYRegresaUnMensaje()
        {
            Assert.IsNotNull(resultado);
        }
    }
}
