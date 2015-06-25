



                                                            Sales Track
                                           Software Development Life Cycle
                                                      Trenton Thompson













Sale Tracker Planning Phase
1. Develop SalesTrack application
A. Why is this Application being developed?
•	Application allows anyone who wants to sell items add and delete items to be put on sale.
•	This  application keeps track of all of the items that are on sale at any given time.
•	 Application allows user to keep all sales in one list.
            B. Who will use this Application?
•	This application is great for anyone who works in retail or online sales and wants to keep track of all the items that are on sale on one list.
•	Ages 18 and over is the focus point for this application.
              C. What will be the languages and platforms for this application?
•	This application will be developed using C# programming language via visual studios. 
•	This application will store data in an XML file.
•	This application will be used by any device that is windows based.
             
 2. Design: Two Forms will be created with GUI named NewSales and SalesManager.
 A. NewSales form consists of 3 labels, 3 textboxes and two buttons. 
•	The labels are: Code,Description and Price. 
•	3 textboxes will be named in properties with txt following name of label to the right of corresponding textbox txtCode ,txtDescription and txtPrice.
•	3 text boxes will be tagged in properties with name of corresponding label to the right of box. Such as Code, Description and Price.
•	Labels, textboxes and buttons will have a 12pt font Microsoft Serif size. 
•	Buttons will be labeled Save and Cancel. 
•	When user clicks the add button on the SalesManager interface this frmNewSale interface will appear. User will enter code, item and price. Then they will click on the save button to finalize entry or they will click on the cancel button to cancel the entry. 
•	Two methods will be used for Save button and Cancel button.
•	Tool tip will be provided for each of the textboxes so that user knows what to enter if they forget or are new to the application.
•	Code textbox has a tool tip “Enter Item Code”.
•	Item textbox has a tool tip “Enter Item that is on sale”.
•	Price textbox has a tool tip “ Enter the Sale price for the item”
        B. 2nd Form is called Sales Manager consists of a listbox and 3 buttons. 
•	Listbox is called LstSales, buttons are called Delete Sale Item, Add Sale Item and Exit.
•	12pt Microsoft Serif is the font size for listBox and 3 buttons. 
•	Methods will be created for click events on Delete, Add and Exit.
•	LstSales is used to display all of the current existing sales. This interface is linked with the XML file to display for the user. 
3 Classes will be used and they are called Validator, Sale and SaleDB.
Validator class
•	This class handles all of the exceptions that would otherwise cause errors to occur.
•	Methods used in this class include: IsPresent method validates the textbox control and makes sure a value was entered. IsDecimal method validates that user has entered a decimal.
Sale class
•	This is the Sale class where encapsulation is used and values are assigned to my properties or fields.
•	code,description and price are declared as Private creating a      blackbox or in other words I encapsulate code,description and price in my class. 
•	An empty constructor is used to create an instance of the Sale class.
•	  A custom constructor is used to create an instance of the class and initializes the private fields passing them into 3 public fields called Code, Description and Price.            

•	A method called GetDisplaytext is used with a string parameter called set. This method concatenates or joins 2 or more strings via the sep parameter. This allows the Code Description and Price to be displayed together.

SaleDB class
•	This class is where the const string path is declared for the XML file. This is necessary for this class to know where to store the XML files.
•	2 methods called GetSales and SaveSales are implemented. These methods create xml objects and settings. Allowing for Sales to be entered into the listbox and saved into the listbox.
                         Xml file is created called Sale.xml this holds the xml samples of sales to be displayed for the user.
Screen shots of New Sales form: 
Screen shot for Sales Manager form:
 
