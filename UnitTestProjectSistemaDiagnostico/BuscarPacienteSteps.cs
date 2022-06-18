using System;
using TechTalk.SpecFlow;
using SistemaDiagnostico.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace UnitTestProjectSistemaDiagnostico
{

    
    [Binding]
    public class BuscarPacienteSteps
    {

        String busqueda;
        DataTable resultado;



        [Given(@"he escrito los digitos (.*)")]
        public void GivenHeEscritoLosDigitos(String dni)
        {
            busqueda = dni;
        }
        
        [When(@"hago clic en el botón de búsqueda")]
        public void WhenHagoClicEnElBotonDeBusqueda()
        {
            resultado = PacienteNegocio.Buscar(busqueda);
        }
        
        [Then(@"Debería ver los pacientes a los que su dni coincidan con los digitos ingresados")]
        public void ThenDeberiaVerLosPacientesALosQueSuDniCoincidanConLosDigitosIngresados(Table table)
        {
            DataTable paciente = Utils.TableExtensions.ToDataTable(table);
            Assert.AreEqual(resultado.Rows.Count, paciente.Rows.Count);
        }
    }
}
