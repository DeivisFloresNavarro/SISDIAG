using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDiagnostico.Negocio;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace UnitTestProjectSistemaDiagnostico
{
    [Binding]
    public class DesactivarEmpleadosSteps
    {
        List<string> listadni = new List<string>();
        List<string> resultados = new List<string>();
        [Given(@"He seleccionado a empleado con los siguientes dni '(.*)'")]
        public void GivenHeSeleccionadoAEmpleadoConLosSiguientesDni(string listadni)
        {
            this.listadni = new List<string>(listadni.Split(','));
        }
        
        [When(@"Hago clic en el botón DESACTIVAR")]
        public void WhenHagoClicEnElBotonDESACTIVAR()
        {
            foreach (string dni in listadni)
            {
                resultados.Add(EmpleadoNegocio.Desactivar(dni));
            }
        }
        
        [Then(@"Los resultados deberian ser '(.*)'")]
        public void ThenLosResultadosDeberianSer(string resultados)
        {
            List<String> listaresultados = new List<string>(resultados.Split(','));
            CollectionAssert.AreEqual(this.resultados, listaresultados);
        }
    }
}
