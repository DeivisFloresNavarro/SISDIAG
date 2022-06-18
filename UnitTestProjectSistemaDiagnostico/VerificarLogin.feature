Feature: VerificarLogin
	COnfirmar Dni a travezde login

@mytag
Scenario: verifiacion de dni exitosa
	Given El dni del usuario es 70323854
	When hagla click en diagnostico
	Then se deberia confirmar DNI