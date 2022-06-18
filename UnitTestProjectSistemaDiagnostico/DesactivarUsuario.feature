Feature: DesactivarUsuario
	Testear la funcionalidad desactivar pacientes

@mytag
Scenario: Empleado desactiva paciente
	Given selecciona la casilla al lado del dni 74527943
	When haga click en el boton desactivar
	Then se visualiza un mensaje con la palabra "Correcto"