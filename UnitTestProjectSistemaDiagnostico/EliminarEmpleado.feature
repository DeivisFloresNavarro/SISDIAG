Feature: EliminarEmpleado
	testear la funcionalidad de eliminar empleado

@mytag
Scenario: Administrador elimina Empleado
	Given se selecciona al empleado con el dni 72303120
	When Se selecciona el boton ELIMINAR
	Then Se visualiza el mensaje "Correcto"