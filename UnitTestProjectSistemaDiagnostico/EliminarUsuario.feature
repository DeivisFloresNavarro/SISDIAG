Feature: EliminarUsuario
	pruena de eliminaicon de usuario

@mytag
Scenario: eliminar usuario exitoso
	Given se selecciona el usuario con el codigo 1004
	When se ejecuta el metodo eliminar
	Then se eliminara el usuario y regresara un mensaje