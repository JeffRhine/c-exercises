# Database Design Exercise

### Implement a database to hold the contents of simple Project Organizer.

The Project Organizer tracks what department and individual employees are working on a given project.

Each employee has the following attributes:

* employee number
* job title
* lastname
* firstname
* gender
* birthday
* hiredate
* works for a department

Each department has the following attributes:

* department number
* name
* has zero-to-many employees

Each project has the following attributes:

* project number
* name
* startdate
* has zero-to-many employees

**Requirements**

All tables are required to have a primary key.

Populate the tables with data for at least four projects, three departments, and eight employees. 

Make sure each project has at least one employee assigned to it, and each department has at least two employees in it.

**Design Tips:**
	
Questions you should ask yourself.

* What data type should be used for each column?
* What attribues are required? Which are optional?
* Are there additional constraints such as length, data format, or restricted values for any columns?
* Is there an table of valid job titles?

Don't forget to normalize.
