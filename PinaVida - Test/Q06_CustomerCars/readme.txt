Welcome to Customer Cars.

##DataBase##
1. Create a link between Customers table and the Cars table that allows a customer to have more than one Car.

2. Create a post deployment script to add the following data to the relevant tables:
	Read PostDeployData.txt


##Front End##
1. We have already created a view with ViewModel for the Customers.
	When I click on the Customers Button and the Customers View is opened, a list of all the Customers needs to be displayd.
	A service needs to be created to fecth the relevant information from the database.

2. Create a View and ViewModel for Cars information. 
	Add a Cars button to the Main View and implement the button to open the newly created Cars View.
	A list of Cars information needs to be displayed when the Cars View is opened.(information needs to be retrieved from the database)

3.  a) Create a View and ViewModel for CustomerCars
	Add a Customer Cars button to the main view and implement the button to open the newly created CustomerCars View.

	b) A list of CustomerCars information needs to be displayed when the CustomerCars view is opened.(information needs to be retrieved from the database).
	The information needs to be ordered by DateManufactured and IdNumber.
	The Combobox mention in d) should be populated with the relevant information.

	c) We also don't want to display any Car information if the DateManufactured is older than 10 Years from today, 
	however the customers information still needs to be displayed.

	d) Add a combobox which displays each customers FirstName and LastName.
	When I select a Customer, the customers information with the relevant cars information needs to be displayed below the combobox.


