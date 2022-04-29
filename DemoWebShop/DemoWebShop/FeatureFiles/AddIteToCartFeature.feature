Feature: AddIteToCartFeature
	Check, if you are able to add a product to cart

@functional
Scenario: It is possible add item to cart
	Given Current was user authorized
		| Email                    | Password  |
		| vasya_pupkin@1221mail.ru | vasya1221 |
	When I add item to cart with data
		| title            | 
		| 14.1-inch Laptop |
	Then Item '14.1-inch Laptop' in cart