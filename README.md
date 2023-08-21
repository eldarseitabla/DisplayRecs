# DisplayRecs

Exercise 1 - Windows App

* Create a delimited text file within Notepad or Visual Studio called ManagementRecs.txt. Include sample records similar to management table used in mock assignment e.g.

1;Joe;Bloggs;111

* Create a Helper Class containing the following methods:

- Method to read in a file and store in a String array and return String array

- Method to take in a string array and convert to list and return list
  (needed as more or less records will be added/removed over time)

* Take newly created list and bind data to a datagrid - Test to make sure data is shown

Exercise 2 - Console App

* You will require the use of the Helper class and shapes classes created previously with this exercise

* Create a delimited text file - sample records shown below of measurements for different shape calculations. 

Sample Records

Rec;SA;10;5;5 
Sq;SA;10;5 
Cyl;V;10;5 
Sq;A;5
Cir;SA;10;5 
Rec;A;10;5 
Cir;A;5

  - First field in file represents room shape i.e. Rec = Rectangle 

  - Second field represents calculation to return based on values provided i.e. SA = Surface Area, V = Volume & A = Area

  - Remaining fields represents length, width and height where applicable 

    e.g. Record 1 above 10 = length : 5 = width : 5 = height

* Convert file to a list using previous methods as you need to loop through records

* Note : you must have all classes implemented especially the area, perimeter and volume methods based on shapes class diagram 

* Might be best to work out expected results initially to help with overall testing 
