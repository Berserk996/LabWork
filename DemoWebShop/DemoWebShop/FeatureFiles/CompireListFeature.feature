Feature: CompireListFeature
	Computer price in the compare list is valid 

@mytag
Scenario: Prices of item in compare list and Desktops page are equal
	Given Default user authorized
		| Email                    | Password  |
		| vasya_pupkin@1221mail.ru | vasya1221 |
	And Sort by name Z to A completed at 'Desktops' page
	When I select first computer in list
	Then Prices of items are equal