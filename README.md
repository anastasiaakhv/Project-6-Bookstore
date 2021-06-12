# Project-6-Bookstore


					     Project Report

	The aim of this report is to consider the functionalities of the project as well as working logic behind it. The paper will consider three different forms. One of them represents main menu. The other two forms aim perform the act of managing customers as well as managing books. The project involves extra credit activity as well. What is more, this report includes the codes for all of the forms. 
	In order to test the program please use the SQL code that is provided below in this report. The connection string has to be changed as well.

____Form4____________________________________________________________________

	Form4 refers to a main menu form. As one runs the program main menu is displayed. There are three buttons. To me more precise, the user has the options of managing customers, managing books and placing the order. Please refer to screenshot 1.1 for the resulting display.

  Screenshot 1.1

![Screenshot 1.1](https://github.com/anastasiaakhv/Project-6-Bookstore/blob/main/1.1.png)

____Form3____________________________________________________________________

	When pressing “Manage Books” button a new form, known as Form3 is being displayed (2.1). There is a combobox at the top of the form. The form includes four buttons. These buttons are: “Back”, “New Book”, “Save” and “Cancel”. The field ISBN is the primary key of the corresponding DB table which is called Table_1_Books.

	By pressing “Back”, the user gets back to main menu. 

	As one presses the button “New Book” the combobox gets disabled and all of the fields (textboxes) get empty so that the user is able to insert new data.

	If one wants to save the data, one has to press the “Save” button. There are two options when it comes to “Save” button. 

Insert 

	If one wants to add a new book to the bookstore, first, one has to press “New Button” and after all of the textboxes are filled out “Save” button has to be pressed. If none of the textboxes are empty and all the preconditions are met the book will be inserted in the database Table_1_Books and the message box will notify the user that the record has been inserted successfully. 
	The act of inserting a record in the database is performed by calling the function “myInsertFunction”. This function executes the SQL command of INSERT and takes the values entered in the textboxes. 

Update

	In case of update a book has to be chosen from the combobox. One can modify all of the fields except ISBN since it represents primary key. As the desired changes are made, one has to press “Save” button and the record will be updated. 
	The act of updating a record in the database is performed by calling the function “myUpdateFunction”. This function executes the SQL command of UPDATE and takes the values entered in the textboxes.
	Form3 includes “Cancel” button too. As one clicks this button, one is asked if one truly wants to cancel or not. If yes, the record is not being inserted into database. If the answer is no, the program notifies the user to click the cancel button in order to cancel. 

____Form5___________________________________________________________________

	By pressing “Manage Customers” Form5 is displayed to the user. This form is very similar to the “Manage Books” form. What is more, it has a corresponding table called “Table_1_Customers” in the Bookstore database. Id represents the primary kay. What’s more, the customer id is distributed automatically since id was noted as identity while creating table. The difference between the codes for managing books and managing customers is that regular expressions are used for managing customers. Regex is used in order to detect an error while checking against precondition. Please refer to the screenshots 2.1, 2.2, 2.3 and 2.4 to view the resulting displays for INSERT and UPDATE. Since the managing books and managing customers are very much alike, the screenshots for managing books are not included in the repost in order to avoid duplicate documentation. 

 Screenshot 2.1 
 This screenshot displays the process of pressing save when inserting a new customer. 
 
 ![Screenshot 2.1](https://github.com/anastasiaakhv/Project-6-Bookstore/blob/main/2.1.png)

 Screenshot 2.2 
 This screenshot represents post insert situation.
 
 ![Screenshot 2.2](https://github.com/anastasiaakhv/Project-6-Bookstore/blob/main/2.2.png)

 Screenshot 2.3 
 This screenshot displays pre update situation.
 
 ![Screenshot 2.3](https://github.com/anastasiaakhv/Project-6-Bookstore/blob/main/2.3.png)

 Screenshot 2.4

 This screenshot displays post update situation.
 
 ![Screenshot 2.4](https://github.com/anastasiaakhv/Project-6-Bookstore/blob/main/2.4.png)


____Form6___________________________________________________________________

	Form6 represents a form for placing an order. There are two combo boxes. One of the boxes serves the purpose of choosing the books while the other one is for choosing a customer. Before choosing a book, quantity field has to be filled in order to display subtotal, tax and total. Once a book is selected from the combobox, the corresponding information is displayed through the textboxes. What is more, the user has to choose a customer in order to place the order. There are two databases that correspond to this form. These databases are: Table_1_Orders and Table_1_OrderDetails. 
	
	When testing this form firstly the books and the customers must be chosen from the combo boxes. Next the quantity textbox has to be filled. Once the user selects the desired book again the subtotal, tax and total textboxes will show the results.

	There are five buttons on this form. It is obvious that by pressing “Back” the user revisits main menu form. Moreover, by pressing “Add Title” the user goes to the managing books form where he/she is able to insert a new book to the book database. The purpose of “Cancel Order” is the same as in the two previous forms, the data will not be saved in the databases.
	
	The most functional buttons are “Confirm Orders” and “Order Report”. The functionalities of “Order Report” were described as extra credit activity in the assignment description. By pressing “Condirm Orders” the user stores the order in the databases Table_1_Orders and Table_1_OrderDetails. The user is able to purchase multiple copies of one book, because otherwise the data would not be normalized in the databases. However, once several purchases are made, the user is able to view all orders by a particular customer by pressing “Order Report”. To be more precise, the user has to choose a customer from combobox and then click the button. Please refer to screenshots 3.1. for the resulting display of pressing “Confirm Order”. The screenshots 3.2.1 and 3.2.2 represent the resulting displays of pressing “Order Report”.

 Screenshot 3.1
 ![Screenshot 3.1](https://github.com/anastasiaakhv/Project-6-Bookstore/blob/main/3.1.png)

 Screenshot 3.2.1
 ![Screenshot 3.2.1](https://github.com/anastasiaakhv/Project-6-Bookstore/blob/main/3.2.1.png)

 Screenshot 3.2.2
 ![Screenshot 3.2.2](https://github.com/anastasiaakhv/Project-6-Bookstore/blob/main/3.2.2.png)
