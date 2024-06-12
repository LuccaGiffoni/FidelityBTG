# Technical Test | 48-hours CRUD for Client Registration

Welcome to the BTG Pactual technical test! In this project, I developed a client registration application using .NET MAUI version 8, leveraging all the advantages of the MVVM architecture.

## Requirements

The test requirements were:

1. Utilization of the MVVM (Model-View-ViewModel) pattern.
2. Implementation of the `Client` class with the following attributes:
   - **Name**
   - **Lastname**
   - **Age**
   - **Address**
3. Initial screen with a client list and operations for adding, deleting, and editing.
   - The screens for these operations should open in a new window and close upon canceling the operation or saving the addition/edit.
   - For deletion, a confirmation message or a custom window can be used.
4. Use of dependency injection.
5. Publishing in a private repository on [GitHub](https://github.com).

All requirements were rigorously met, and additional features were added to the `Client` class, including automatic and facilitated validations.

## Optional Features

1. Data persistence so that when the application is run again, the data can be loaded and manipulated, using SQLite as the internal database of the application.
2. Verification of the data type entered in each field: all fields received validation during data entry by the user to avoid any type of error.

## Usage Instructions

1. Clone this repository to your local environment.
2. Open the solution in Visual Studio or another development environment compatible with .NET MAUI.
3. Run the application and test the functionalities as described in the requirements.

## Testing the Latest Release

The application tests can also be run on Windows machines by downloading the .zip file of the latest released version, installing via side-load, and authenticating with a new certificate.

## Screenshot of the Working Application

![FidelityBTG-RealApplication](https://github.com/LuccaGiffoni/FidelityBTG/assets/81778943/70749ba1-5e43-46c7-8458-3afe32b1de10)
