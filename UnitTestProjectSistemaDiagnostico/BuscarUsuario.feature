Feature: BuscarUsuario
	Administrador busca Usuario

@mytag
Scenario: Administrador busca Usuario
	Given se digita 7032 en el buscador
	When Hago click en el botón de búsqueda
	Then Debería ver los Usuarios a los que sus dni coincidan con los digitos ingresados
		| Codigo	| Dni		| Usuario	| Clave         |
		| 70323854	| daniel	| gonzalez  | 1234 |