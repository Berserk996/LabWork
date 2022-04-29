Feature: FollowUsLinks
	Simple calculator for adding two numbers

@mytag
Scenario: It's possible to check FOLLOW US links
	Given Current  was user authorized
		| Email                    | Password  |
		| vasya_pupkin@1221mail.ru | vasya1221 |
	When I click on links
		| Links    |
		| Facebook |
		| Twitter  |
		| YouTube  |
	Then Pages are opening