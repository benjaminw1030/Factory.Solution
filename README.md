# Dr. Sillystringz's Factory

An administration page for a factory that tracks Engineers employed and Machines in use.

### By Ben Wilson

## Technologies Used

* _C#_
* _ASP.NET Core MVC_
* _.NET 5_
* _NuGet_
* _Microsoft.EntityFrameworkCore_
* _Dotnet EntityFramework Tool_
* _Microsoft.EntityFrameworkCore.Design_
* _MySQL_

## Description
This web application will allow the user to create engineers and machines, and also to add a relationship between the two. The engineer and machine models have full CRUD functionality with a many-to-many relationship between them.

### Technology Requirements

* [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* A text editor like [VS Code](https://code.visualstudio.com/)

## Setup/Installation Requirements

1. Install the [.NET framework](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net50).
2. If on MacOS, Install [MySQL Community Server](https://dev.mysql.com/downloads/file/?id=484914) and [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391). If on Windows 10 download the [MySQL Web Installer](https://downloads.mysql.com/archives/get/p/25/file/mysql-installer-web-community-8.0.19.0.msi) and follow installation instructions.
3. During installation, note the password used for your server.
4. [Clone](https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository-from-github/cloning-a-repository) this repository from GitHub to your local machine.
5. Open the new directory.
6. Create a new file called "appsettings.json" in the Factory directory.
7. Copy the following code into this file (noting where to insert your password):
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=root;pwd=YOUR_PASSWORD;"
  }
}
```
8. Open a new terminal instance in the Factory.Solution/Factory directory.
10. Open MySQL Workbench and connect to localhost:3306 at root.
11. Type "dotnet build" in the terminal to create the file structure and install packages.
12. Apply the included Migration file by typing "dotnet ef database update"
14. To view, type "dotnet watch run" in the terminal and navigate to http://localhost:5000 or https://localhost:5001 in any web browser.

## Known Bugs

* None

## License

* [MIT License](https://opensource.org/licenses/MIT)

## Contact Information

Ben Wilson: <benjaminw1030@gmail.com>