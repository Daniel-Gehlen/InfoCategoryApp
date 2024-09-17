# CategorySelector

**CategorySelector** is an interactive web application developed with Blazor WebAssembly. This application allows users to choose from different categories (Weather, Traffic, Sports) and receive a response based on the selected choice.

## Technologies Used

- **Blazor WebAssembly**: Used to create an interactive web application using C# on the client side.
- **C#**: Programming language used for business logic and event handling.
- **HTML**: For structuring the web page.
- **CSS**: For styling the interface with a modern and responsive design.

## Features

- **Category Selection**: Users can choose from the following categories:
  - Weather
  - Traffic
  - Sports
  - Exit
- **Dynamic Response**: Based on the user's choice, an informative response is displayed.

## Environment Setup

To run the application locally, follow these steps:

1. **Install Visual Studio**
   - Download and install [Visual Studio](https://visualstudio.microsoft.com/) with the components for ASP.NET development and Blazor WebAssembly.

2. **Clone the Repository**
   - Clone this repository to your local machine using the command:
     ```bash
     git clone https://github.com/Daniel-Gehlen/InfoCategoryApp
     ```

3. **Open the Project in Visual Studio**
   - Open Visual Studio and select "Open a project or solution".
   - Navigate to the folder where you cloned the repository and open the `.sln` file.

4. **Restore Dependencies**
   - In Visual Studio, restore the project dependencies by right-clicking on the project in the Solution Explorer and selecting "Restore NuGet Packages".

5. **Build and Run**
   - Build and run the application by pressing `F5` or clicking on "Start Debugging" in Visual Studio.

6. **View in Browser**
   - The application will start in a web browser. You can interact with the interface to select categories and see the informative responses.

## Contributing

Contributions are welcome! If you would like to contribute to the project, please follow these steps:

1. Fork the repository.
2. Create a branch for your feature (`git checkout -b my-new-feature`).
3. Make your changes and commit (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin my-new-feature`).
5. Open a pull request.

## License

This project is licensed under the [MIT License](LICENSE).

## Fluxogram

```

stateDiagram
    [*] --> Start
    Start --> ChooseCategory: Continue
    ChooseCategory --> Weather: Choice 1
    ChooseCategory --> Traffic: Choice 2
    ChooseCategory --> Sports: Choice 3
    ChooseCategory --> Exit: Choice 4
    Weather --> Start
    Traffic --> Start
    Sports --> Start
    Exit --> [*]
```
