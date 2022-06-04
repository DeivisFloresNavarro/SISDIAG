Feature: EliminarEmpleado
	Testear la funcionalidad de eliminar empleado

@mytag
Scenario: Empleado elimina paciente
	Given selecciono el empleado con el dni 72303120
	When selecciono la opcion eliminar
	Then Se visualiza el mensaje "Correcto"