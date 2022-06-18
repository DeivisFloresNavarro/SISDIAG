Feature: ActivarEmpleados
	Testear la funcionalidad de activar empleados

@mytag
Scenario: Administrador activa empleados 
	Given He seleccionado a empleado con los dni siguientes '00425123,12345678'
	When Hago clic en el botón ACTIVAR
	Then Los resultados deben ser 'Correcto,Correcto'
