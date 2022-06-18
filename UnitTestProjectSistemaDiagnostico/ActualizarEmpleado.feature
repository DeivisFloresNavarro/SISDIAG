Feature: ActualizarEmpleado
	Testear la funcionalidad de actualizar empleados

@mytag
Scenario: Administrador actualiza empleado
	Given He ingresado los datos del empleado a modificar "71203043", "jose", "mendoza", "Administrador", "Av. Manuel A. Odria ", "97546445 ", "A"
	When Hago clic en el botón ACTUALIZAR
	Then Deberia dar el mensaje 'Correcto'