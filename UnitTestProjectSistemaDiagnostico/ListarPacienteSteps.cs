using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDiagnostico.Negocio;
using System;
using System.Data;
using TechTalk.SpecFlow;

namespace UnitTestProjectSistemaDiagnostico
{
    [Binding]
    public class ListarPacienteSteps
    {
        bool respuesta;
        DataTable resultado;
        [Given(@"ingresa a la opcion paciente")]
        public void GivenIngresaALaOpcionPaciente()
        {
            
        }
        
        [When(@"hace click en la pestaña listar pacientes")]
        public void WhenHaceClickEnLaPestanaListarPacientes()
        {
            resultado = PacienteNegocio.Listar();
        }
        
        [Then(@"Debería ver todos los pacientes registrados")]
        public void ThenDeberiaVerTodosLosPacientesRegistrados()
        {
            if (resultado.Rows.Count >= 1)
            {
                respuesta = true;
            }

            Assert.IsTrue(respuesta);
        }
    }
}
