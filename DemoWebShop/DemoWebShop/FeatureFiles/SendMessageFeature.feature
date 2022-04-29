Feature: SendMessageFeature
	Send random message to administration

@mytag
Scenario: It is possible to send administration a random message
    Given Current user authorized
		| Email                    | Password  |
		| vasya_pupkin@1221mail.ru | vasya1221 |
	When 'Contact Us' page is opened
	Then I add random data
	And 'Your enquiry has been successfully sent to the store owner.' result is displayed