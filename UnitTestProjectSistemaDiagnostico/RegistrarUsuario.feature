Feature: RegistrarUsuario
	Testear la funcionalidad de registrar usuarios

@mytag
Scenario: Admin registra usuario
	Given selecciona la pestaña usuario
	And ingresa los datos del usuario "1234", "Lozano", "1234", "A"
	When se presiona el boton insertar
	Then  se registra y se visualiza una ventana con un mensaje 