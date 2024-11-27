# DynamicFormBlazor

Project Overview
This project is a Blazor WebAssembly application that dynamically generates a form based on a configuration. 
The form supports various field types, including text, email, number, dropdown, and checkbox. The form data 
is validated and submitted, and the results are displayed in JSON format.

Key Components
1.	FormField Class: Represents a form field with properties like Type, Label, Required, Value, ValueBool, 
	Values, Min, and Max. It also includes a method GetValidationAttributes to get validation attributes 
	based on the field type.
2.	TextField Component: A Blazor component that renders different input elements based on the field type.
  It supports text, email, number, dropdown, and checkbox fields.
4.	DropdownField Component: A Blazor component that renders a dropdown list and binds the selected value.
5.	CheckboxField Component: A Blazor component that renders a checkbox and binds the checked value.
6.	Home Component: The main page that renders the form using the TextField component for each field. 
	It handles form submission, validation, and displays the output in JSON format.
	

Step-by-Step Execution
1.	Clone the Repository: Clone the project repository to your local machine.
    git clone https://github.com/vcodutti/DynamicFormBlazor-IC-TechChallenge.git
2.	Open the Project in Visual Studio: Open the solution file (.sln) in Visual Studio.
3.	Restore NuGet Packages: Restore the required NuGet packages by right-clicking on the solution.
4.	Build the Project: Build the project to ensure that all dependencies are resolved and there are no 
	compilation errors. 
5.	Run the Project: Run the project by pressing F5. This will launch the Blazor WebAssembly application in 
	your default web browser.
6.	Interact with the Form: The form will be displayed on the home page. Fill in the form fields and submit 
	the form. The form data will be validated, and the results will be displayed in JSON format below the form.
	
Decision-making statements
- The application is structured using reusable Blazor components (TextField, DropdownField, CheckboxField).
  Component-based architecture promotes reusability, maintainability, and separation of concerns. Each component
  encapsulates its own logic and rendering, making it easier to manage and test individual parts of the application.
- The application uses Blazor's data binding and validation features (@bind, DataAnnotationsValidator, ValidationMessage).
  Blazor's data binding simplifies the process of synchronizing the UI with the underlying data model. Using data
  annotations for validation ensures that form inputs are validated on the client side, providing immediate feedback to
  users and improving the overall user experience.
- The application includes error handling and user feedback mechanisms (alerts for success and error messages). Providing
  feedback to users is essential for a good user experience. By displaying success and error messages, the application
  informs users about the status of their actions, helping them understand whether their input was processed correctly or
  if there were issues that need to be addressed.![BlazorResults](https://github.com/user-attachments/assets/fc07ca5a-3114-4232-b8a8-54d6a6801218)

