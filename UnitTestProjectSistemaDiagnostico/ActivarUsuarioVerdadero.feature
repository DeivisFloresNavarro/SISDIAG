Feature: ActivarUsuarioVerdadero
	Testear la funcionalidad de activar Usuario

@mytag
Scenario: Administrador activa usuario
	Given Selecciono la casilla al lado del codigo 1002
	When se selecciona activar
	Then se recibe un mensaje de confirmacion "Correcto"