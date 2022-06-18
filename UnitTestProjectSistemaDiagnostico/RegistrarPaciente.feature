Feature: RegistrarPaciente
	Testear la funcionalidad de registrar pacientes

@mytag
Scenario: Empleado registra paciente
	Given selecciona la pestaña mantenimiento 
	And ingresa los datos del paciente "74527943", "lucas", "mendez", "masculino", "direccion", "123456789", "Activo"
	When presiona el boton insertar
	Then visualiza una ventana con un mensaje 