Feature: AuthorizationFeatureFile
	Coverage of autrorization by autotest.

@ValidAuthorization
Scenario: It is possible to authorize with valid data
	Given move on 'Welcome, Please Sign In!' page
	When I enter the folowing details to authorize
		| Email                    | Password  |
		| vasya_pupkin@1221mail.ru | vasya1221 |
	Then authorize with 'vasya_pupkin@1221mail.ru' passes successfully

@invalidAuthorization
Scenario Outline: It is impossible to register with invalid data
	Given move on 'Welcome, Please Sign In!' page
	When I enter the folowing details to authorize
		| Email   | Password   |
		| <Email> | <Password> |
	Then Error message with '<errorText1>' and '<errorText2>' text is displayed

	Examples:
		| errorText1                                                       | errorText2                             | Email                    | Password  |
		| Login was unsuccessful. Please correct the errors and try again. | No customer account found              | wewrfsdf@fef.rwe         |           |
		| Login was unsuccessful. Please correct the errors and try again. | The credentials provided are incorrect | vasya_pupkin@1221mail.ru | vasya     |
		| Login was unsuccessful. Please correct the errors and try again. | No customer account found              |                          | vasya1221 |