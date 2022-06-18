Feature: DesactivarEmpleados
	Testear la funcionalidad de desactivar empleados

@mytag
Scenario: Administrador desactiva empleados 
	Given He seleccionado a empleado con los siguientes dni '00425123,12345678'
	When Hago clic en el botón DESACTIVAR
	Then Los resultados deberian ser 'Correcto,Correcto'