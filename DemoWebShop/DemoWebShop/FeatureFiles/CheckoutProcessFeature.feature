Feature: CheckoutProcessFeature
	Checkout process including the addition if various products

@mytag
Scenario: it is possuble to checkout items using a bank card
	Given Current already user authorized
		| Email                    | Password  |
		| vasya_pupkin@1221mail.ru | vasya1221 |
	When I add items to cart with data
		| title                        |
		| $100 Physical Gift Card      |
		| Computing and Internet       |
		| 14.1-inch Laptop             |
		| Denim Short with Rhinestones |
		| Black & White Diamond Heart  |
	Then I do checkout process with current data