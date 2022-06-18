Feature: ActivarUsuario
	Testear la funcionalidad de activar pacientes

@mytag
Scenario: Empleado activa paciente
	Given Selecciono la casilla al lado del dni 74527943
	When hago click en el boton activar
	Then se un mensaje de confirmacion "Correcto"