using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDiagnostico.Negocio;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace UnitTestProjectSistemaDiagnostico
{
    [Binding]
    public class ActivarEmpleadosSteps
    {
        List<string> listadni = new List<string>();
        List<string> resultados = new List<string>();
        [Given(@"He seleccionado a empleado con los dni siguientes '(.*)'")]
        public void GivenHeSeleccionadoAEmpleadoConLosDniSiguientes(string listadni)
        {
            this.listadni = new List<string>(listadni.Split(','));
        }
        
        [When(@"Hago clic en el botón ACTIVAR")]
        public void WhenHagoClicEnElBotonACTIVAR()
        {
            foreach (string dni in listadni)
            {
                resultados.Add(EmpleadoNegocio.Activar(dni));
            }
        }
        
        [Then(@"Los resultados deben ser '(.*)'")]
        public void ThenLosResultadosDebenSer(string resultados)
        {
            List<String> listaresultados = new List<string>(resultados.Split(','));
            CollectionAssert.AreEqual(this.resultados, listaresultados);
        }
    }
}
