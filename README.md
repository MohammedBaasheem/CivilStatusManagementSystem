# Civil Status Management System

The Civil Status Management System is a Windows Forms application designed to manage and issue civil documents such as birth certificates, passports, and identification cards. This application provides a user-friendly interface for creating, searching, and managing these documents.

## Features

- **Birth Certificate Management**: 
  - Create and store birth certificates.
  - Search for existing birth certificates using encrypted ID numbers.

- **Identification Card Management**: 
  - Create and store identification cards.
  - Search for existing identification cards using encrypted ID numbers.

- **Passport Management**: 
  - Create and store passports.
  - Search for existing passports using encrypted passport numbers.

- **Employee Management**: 
  - Add and delete employee accounts for managing civil status documents.
  - Search for employee accounts using their IDs.

- **User Authentication**: 
  - Authenticate managers and employees using username and password.

## Usage

1. **Installation**: 
   - Ensure you have .NET Framework installed on your machine.
   - Clone or download the repository.

2. **Running the Application**:
   - Open the solution in Visual Studio.
   - Build the project.
   - Run the application from Visual Studio.

3. **Interacting with the System**:
   - Use the navigation options in the Windows Forms interface to create and manage documents.
   - Follow on-screen prompts to add, search, or delete records.

## Project Structure

- **Controllers**:
  - **Birth_certificate_Controller**: Handles operations related to birth certificates.
  - **Identification_Card_Controller**: Manages identification card records.
  - **Passport_Controller**: Manages passport records.
  - **Login_Controller**: Manages user authentication.
  - **Manager**: Handles employee management functions.

- **Entities**: Contains the data models representing birth certificates, identification cards, passports, and user logins.

## Encryption

The application uses Base64 encoding to encrypt sensitive information such as ID numbers for added security during storage and retrieval.

## Contribution

If you would like to contribute to this project, feel free to open a Pull Request or submit issues for any bugs or feature requests.

## Notes

- Ensure that the database is properly configured and accessible for the application to function correctly.
- Review the code for further customization or additional features as needed.
