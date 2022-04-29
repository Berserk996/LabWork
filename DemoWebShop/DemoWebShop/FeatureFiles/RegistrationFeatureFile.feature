Feature: RegistrationFeatureFile
	Coverage of registraton by autotest.

@reg
Scenario: It is posible to register new user
	Given 'Register' page is open
	When I enter the folowing details to register
		| First name  | Last name       | Email        | Password        | Confirm pasword |
		| unique name | unique lastName | unique email | unique password | unique password |
	Then 'Your registration completed' is displayed

@registration
Scenario: It is imposible to register with already existing email in system
	Given 'Register' page is open
	When I enter the folowing details to register
		| First name | Last name | Email                    | Password  | Confirm pasword |
		| Vasya      | Pupkin    | vasya_pupkin@1221mail.ru | vasya1221 | vasya1221       |
	Then Error message with 'The specified email already exists' text throws

@p1
Scenario Outline: It is impossibe to register with invalid data
	Given 'Register' page is open
	When I enter the folowing details to register
		| First name   | Last name   | Email   | Password   | Confirm pasword   |
		| <First name> | <Last name> | <Email> | <Password> | <Confirm pasword> |
	Then Error message with '<errorText>' text is displaed

	Examples:
		| errorText                                            | First name | Last name | Email                    | Password  | Confirm pasword |
		| First name is required.                              |            | Pupkin    | vasya_pupkin@1221mail.ru | vasya1221 | vasya1221       |
		| Last name is required.                               | Vasya      |           | vasya_pupkin@1221mail.ru | vasya1221 | vasya1221       |
		| Email is required.                                   | Vasya      | Pupkin    |                          | vasya1221 | vasya1221       |
		| Password is required.                                | Vasya      | Pupkin    | vasya_pupkin@1221mail.ru |           |                 |
		| The password and confirmation password do not match. | Vasya      | Pupkin    | vasya_pupkin@1221mail.ru | vasya1221 | vasadaf         |
		| Wrong email                                          | Vasya      | Pupkin    | vasya_pupkin             | vasya1221 | vasya1221       |
		| The password should have at least 6 characters.      | Vasya      | Pupkin    | vasya_pupkin@1221mail.ru | vasya     | vasya1221       |