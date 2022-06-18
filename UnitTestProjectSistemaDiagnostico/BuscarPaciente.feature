Feature: BuscarPaciente
	Testear la funcionalidad de búsqueda de pacientes

@mytag
Scenario: Empleado busca paciente
	Given he escrito los digitos 7452
	When hago clic en el botón de búsqueda
	Then Debería ver los pacientes a los que su dni coincidan con los digitos ingresados
		| Dni	   | Nombre | Apellido | Estado         |
		| 74527943 | lucas	| mendez  | A |