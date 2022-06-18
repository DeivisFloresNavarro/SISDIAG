Feature: RegistrarEmpleado
	Testear la funcionalidad de registrar empleados

@mytag
Scenario: Administrador registra empleado
	Given He ingresado los datos del empleado: '72303120','luis','fernandez','Empleado','Calle Arica','932135789','A'
	When hago clic en el boton INSERTAR
	Then Deberia ver el mensaje 'Correcto'
