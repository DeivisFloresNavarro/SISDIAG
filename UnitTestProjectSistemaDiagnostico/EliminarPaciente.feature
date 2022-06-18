Feature: EliminarPaciente
	Testear la funcionalidad de eliminar paciente

@mytag
Scenario: Empleado elimina paciente
	Given selecciono la casilla al lado del dni 74527943
	When hago click en el boton eliminar
	Then Se visualiza un mensaje con la palabra "Correcto"
		