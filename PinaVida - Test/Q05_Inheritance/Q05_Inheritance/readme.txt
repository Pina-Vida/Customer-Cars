1. Create an class called Account, ensure it can't be instansiated.
	Add the properties ClientNumber(string), AccountNumber(string) and Balance(decimal).

2. Create a class called IndividualAccount that inherits from Account.
	Add the properties FirstName(string), Surname(string) and IdNumber(string).

3. Create a class called CorporateAccount that inherits from Account.
	Add the properties CompanyName(string) and CompanyRegNo(string)

4. Add a method called PrintDetails() to the Account class which must print all the properties.

5. Override PrintDetails() in IndividualAccount and CorporateAccount.
	Print first the inherited properties and then the properties that belong to that specific class.

6. In the main program instantiate IndividualAccount and CorporateAccount, set all properties for both.
	Add them to a list and then loop through the list and call the PrintDetails() method.