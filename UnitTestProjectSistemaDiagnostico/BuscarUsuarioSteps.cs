using System;
using System.Data;
using TechTalk.SpecFlow;
using SistemaDiagnostico.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectSistemaDiagnostico
{
    [Binding]
    public class BuscarUsuarioSteps
    {
        string busqueda;
        DataTable resultado;

        [Given(@"se digita (.*) en el buscador")]
        public void GivenSeDigitaEnElBuscador(string digitos)
        {
            busqueda = digitos;
        }
        
        [When(@"Hago click en el botón de búsqueda")]
        public void WhenHagoClickEnElBotonDeBusqueda()
        {
            resultado = UsuarioNegocio.Buscar(busqueda);
        }
        
        [Then(@"Debería ver los Usuarios a los que sus dni coincidan con los digitos ingresados")]
        public void ThenDeberiaVerLosUsuariosALosQueSusDniCoincidanConLosDigitosIngresados(Table table)
        {
            DataTable usuarios = Utils.TableExtensions.ToDataTable(table);
            Assert.AreEqual(resultado.Rows.Count, usuarios.Rows.Count);
        }
    }
}
