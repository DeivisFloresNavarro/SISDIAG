Feature: ActualizarUsuario
	Simple calculator for adding two numbers

@mytag
Scenario: Add two numbers
	Given se selecciona al paciente listado
	And se modifica los datos por los siguientes "1002", "1234" , "luis", "1234", "A"
	When se selecciona el boton actualizar
	Then se realiza el cambio y regresa un mensaje