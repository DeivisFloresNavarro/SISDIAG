using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDiagnostico.Negocio;
using System;
using System.Data;
using TechTalk.SpecFlow;

namespace UnitTestProjectSistemaDiagnostico
{
    [Binding]
    public class IniciarSesionSteps
    {
        DataTable tabla1 ;
        string usuario;
        string clave;

        [Given(@"se digita el usuario ""(.*)"" con clave ""(.*)""")]
        public void GivenSeDigitaElUsuarioConClave(string usu, string cla)
        {
            usuario = usu;
            clave = cla;
        }
        
        [When(@"Hago click en el botón ingresar")]
        public void WhenHagoClickEnElBotonIngresar()
        {
           tabla1 = UsuarioNegocio.Login(usuario, clave);
        }
        
        [Then(@"Debería buscar en la base de datos y confirmasr su existencia")]
        public void ThenDeberiaBuscarEnLaBaseDeDatosYConfirmasrSuExistencia(Table table)
        {
            DataTable usuario = Utils.TableExtensions.ToDataTable(table);
            Assert.AreEqual(tabla1.Rows.Count, usuario.Rows.Count);
        }
    }
}
