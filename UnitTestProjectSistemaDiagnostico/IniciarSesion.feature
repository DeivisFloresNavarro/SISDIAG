Feature: IniciarSesion
	Iniciar Sesion del sistema

@mytag
Scenario: Add two numbers
	Given se digita el usuario "daniel" con clave "1234"
	When Hago click en el botón ingresar
	Then Debería buscar en la base de datos y confirmasr su existencia
		|Usuario	| Clave |
		| daniel	|1234	|