Feature: ListarEmpleados
	Testear la funcionalidad de listar de Empleados

@mytag
Scenario: Administrador lista Empleados
	Given ingresa a la opcion empleado
	When hace clic en la pestaña listar pacientes
	Then Debería ver todos los empleados registrados
