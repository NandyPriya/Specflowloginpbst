Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](Logout/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: logout
	Given the input is 0
	
	When the logout operation
	Then the result1 should be successfully logout

Scenario: AddProductToCart
	Given the prodname is Laptop
	And the quantity is 2
	When the addtocart operation
	Then the result2 should be addtocart successfully 