Feature: ListarPaciente
	Testear la funcionalidad de listar de pacientes

@mytag
Scenario: Empleado lista pacientes
	Given ingresa a la opcion paciente
	When hace click en la pestaña listar pacientes
	Then Debería ver todos los pacientes registrados