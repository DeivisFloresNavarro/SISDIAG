Feature: ActualizarPaciente
	Testear la funcionalidad de actualizar pacientes

@mytag
Scenario: Empleado actualiza paciente
	Given hace doble click en un pacinete listado
	And modifica algunos de los datos del paciente "dni", "nombre", "apellido", "F", "direccion", "celular", "I"
	When presiona el boton actualizar
	Then Visualiza un ventana con un mensaje 