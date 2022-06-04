using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDiagnostico.Negocio;
using System;
using System.Data;
using TechTalk.SpecFlow;

namespace UnitTestProjectSistemaDiagnostico
{
    [Binding]
    public class ListarEmpleadosSteps
    {
        bool respuesta;
        DataTable resultado;
        [Given(@"ingresa a la opcion empleado")]
        public void GivenIngresaALaOpcionEmpleado()
        {
            
        }
        
        [When(@"hace clic en la pestaña listar pacientes")]
        public void WhenHaceClicEnLaPestanaListarPacientes()
        {
            resultado = EmpleadoNegocio.Listar();
        }
        
        [Then(@"Debería ver todos los empleados registrados")]
        public void ThenDeberiaVerTodosLosEmpleadosRegistrados()
        {
            if (resultado.Rows.Count >= 1)
            {
                respuesta = true;
            }

            Assert.IsTrue(respuesta);
        }
    }
}
