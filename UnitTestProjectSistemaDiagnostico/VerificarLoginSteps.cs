using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDiagnostico.Negocio;
using System;
using System.Data;
using TechTalk.SpecFlow;

namespace UnitTestProjectSistemaDiagnostico
{
    [Binding]
    public class VerificarLoginSteps
    {
        string busqueda;
        string DNI2;
        DataTable resultado;

        [Given(@"El dni del usuario es (.*)")]
        public void GivenElDniDelUsuarioEs(string dni)
        {
            busqueda = dni;
        }
        
        [When(@"hagla click en diagnostico")]
        public void WhenHaglaClickEnDiagnostico()
        {
            resultado = UsuarioNegocio.LoginVerificar(busqueda);
        }
        
        [Then(@"se deberia confirmar DNI")]
        public void ThenSeDeberiaConfirmarDNI()
        {
            
            DNI2 = Convert.ToString(resultado.Rows[0][0]);
            Assert.AreEqual(DNI2, busqueda);
        }
    }
}
