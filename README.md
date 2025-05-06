<div align="left" style="position: relative;">
<h1>SOLAR_WATCH</h1>
<p align="left">
	<em>Shine Bright, Track Light, Embrace Daylight</em>
</p>
<p align="left">
	<img src="https://img.shields.io/github/last-commit/szoszo23/Solar_Watch?style=default&logo=git&logoColor=white&color=0080ff" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/szoszo23/Solar_Watch?style=default&color=0080ff" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/szoszo23/Solar_Watch?style=default&color=0080ff" alt="repo-language-count">
</p>
<p align="left"><!-- default option, no dependency badges. -->
</p>
<p align="left">
	<!-- default option, no dependency badges. -->
</p>
</div>
<br clear="right">

<p align="center">
		<em>Developed with the software and tools below.</em>
</p>
<p align="center">
	<a href="https://developer.mozilla.org/en-US/docs/Web/JavaScript" target="_blank">
  		<img src="https://img.shields.io/badge/JavaScript-F7DF1E.svg?style=flat&logo=JavaScript&logoColor=black" alt="JavaScript">
	</a>
	<a href="https://developer.mozilla.org/en-US/docs/Glossary/HTML5" target="_blank">
		<img src="https://img.shields.io/badge/HTML5-E34F26.svg?style=flat&logo=HTML5&logoColor=white" alt="HTML5">	
	</a>
	<a href="https://react.dev/reference/react" target="_blank">
		<img src="https://img.shields.io/badge/React-61DAFB.svg?style=flat&logo=React&logoColor=black" alt="React">
	</a>
 <a href="https://learn.microsoft.com/en-us/dotnet/csharp/" target="_blank">
	<img src="https://img.shields.io/badge/C%23-239120.svg?style=flat&logo=c-sharp&logoColor=white" alt="C#">
</a>
<a href="https://learn.microsoft.com/en-us/sql/sql-server/" target="_blank">
	<img src="https://img.shields.io/badge/MS_SQL_Server-CC2927.svg?style=flat&logo=microsoftsqlserver&logoColor=white" alt="MS SQL Server">
</a>
</p>

##  Table of Contents

- [ Overview](#-overview)
- [ Features](#-features)
- [ Project Structure](#-project-structure)
    - [ Project Index](#-project-index)
- [ Getting Started](#-getting-started)
    - [ Prerequisites](#-prerequisites)
    - [ Installation](#-installation)
    - [ Usage](#-usage)
- [ Contributing](#-contributing)


---

##  Overview

SolarWatch is a cutting-edge project that simplifies tracking sunrise and sunset times for various cities. With features like user authentication, city data management, and precise time retrieval, SolarWatch caters to weather enthusiasts, photographers, and outdoor enthusiasts. Stay informed and plan your day effectively with SolarWatch's intuitive interface and accurate data.

---

##  Features

|      | Feature         | Summary       |
| :--- | :---:           | :---          |
| ⚙️  | **Architecture**  | <ul><li>Modular architecture with clear separation of concerns.</li><li>Utilizes RESTful APIs for communication.</li></ul> |
| 🔩 | **Code Quality**  | <ul><li>Consistent coding style and conventions.</li></ul> |
| 📄 | **Documentation** | <ul><li>Comprehensive documentation in CSharp and JSON formats.</li><li>Includes setup instructions and API references.</li></ul> |
| 🔌 | **Integrations**  | <ul><li>Integrates with various package managers like NuGet and npm.</li><li>Uses external libraries for specific functionalities.</li><li>Supports easy integration with third-party services.</li></ul> |
| 🧩 | **Modularity**    | <ul><li>Well-structured codebase with reusable components.</li><li>Follows SOLID principles for better maintainability.</li><li>Allows easy addition of new features without impacting existing code.</li></ul> |
| 🛡️ | **Security**      | <ul><li>Follows best practices for data encryption and secure communication.</li><li>Implements role-based access control and authentication mechanisms.</li></ul> |
| 📦 | **Dependencies**  | <ul><li>Manages dependencies using NuGet and npm package managers.</li><li>Keeps dependencies up to date for security and compatibility.</li><li>Minimizes unnecessary dependencies for a leaner codebase.</li></ul> |

---

##  Project Structure

```sh
└── Solar_Watch/
    ├── README.md
    ├── Solar_Watch
    │   ├── .idea
    │   ├── Solar_Watch
    │   ├── Solar_Watch.sln
    │   └── global.json
    └── Solar_Watch_Frontend
        ├── .eslintrc.cjs
        ├── .gitignore
        ├── README.md
        ├── index.html
        ├── package-lock.json
        ├── package.json
        ├── public
        ├── src
        └── vite.config.js
```


###  Project Index
<details open>
	<summary><b><code>SOLAR_WATCH/</code></b></summary>
	<details> <!-- __root__ Submodule -->
		<summary><b>__root__</b></summary>
		<blockquote>
			<table>
			</table>
		</blockquote>
	</details>
	<details> <!-- Solar_Watch Submodule -->
		<summary><b>Solar_Watch</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/global.json'>global.json</a></b></td>
				<td>Defines the SDK version and update behavior for the project, ensuring compatibility and stability.</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch.sln'>Solar_Watch.sln</a></b></td>
				<td>Facilitates the management of the Solar Watch project within the Visual Studio Solution.</td>
			</tr>
			</table>
			<details>
				<summary><b>Solar_Watch</b></summary>
				<blockquote>
					<table>
					<tr>
						<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/appsettings.Development.json'>appsettings.Development.json</a></b></td>
						<td>Manages logging configurations for the Solar Watch project during development.</td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/appsettings.json'>appsettings.json</a></b></td>
						<td>Define logging and JWT settings in the appsettings.json file to configure logging levels and authentication settings for the Solar Watch project.</td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Program.cs'>Program.cs</a></b></td>
						<td>- Implements the setup of authentication, authorization, and database context for the Solar Watch project<br>- Configures Swagger documentation and adds necessary services to the container<br>- Seeds initial authentication roles and admin user<br>- Maps controllers and runs the application.</td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Solar_Watch.csproj'>Solar_Watch.csproj</a></b></td>
						<td>- Manages project dependencies for Solar Watch using .NET SDK<br>- Configures target framework, enables nullable and implicit usings<br>- Includes packages for authentication, JWT bearer, OpenAPI, Entity Framework Core, Moq, NUnit, and Swagger<br>- Enhances project functionality and testing capabilities.</td>
					</tr>
					</table>
					<details>
						<summary><b>Controllers</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Controllers/AuthController.cs'>AuthController.cs</a></b></td>
								<td>- Manages user authentication and authorization within the Solar Watch application<br>- Handles user registration, login, and retrieval of user information based on the provided token<br>- Utilizes the IAuthService interface to interact with the authentication service for user operations<br>- The controller ensures proper validation and error handling for user-related requests.</td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Controllers/SolarController.cs'>SolarController.cs</a></b></td>
								<td>- Implements SolarController for managing sunrise and sunset data<br>- Handles GET, DELETE, and PATCH requests to retrieve, delete, and update this information for specified cities and dates<br>- Includes authorization roles for user and admin access levels.</td>
							</tr>
							</table>
						</blockquote>
					</details>
					<details>
						<summary><b>Migrations</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Migrations/20240406143841_InitialCreate.Designer.cs'>20240406143841_InitialCreate.Designer.cs</a></b></td>
								<td>- Defines initial database schema for Solar Watch project, including City and SunriseSunset entities with relationships<br>- Configures model properties and constraints using Entity Framework Core<br>- Establishes table mappings and foreign key associations for data retrieval and storage.</td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Migrations/20240406143841_InitialCreate.cs'>20240406143841_InitialCreate.cs</a></b></td>
								<td>- Defines database schema for cities and their corresponding sunrise/sunset times<br>- Creates tables for cities and sunrise/sunsets with necessary columns and constraints<br>- Establishes relationships between cities and sunrise/sunsets<br>- Handles database migrations for initial setup and rollback.</td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Migrations/SolarWatchDbContextModelSnapshot.cs'>SolarWatchDbContextModelSnapshot.cs</a></b></td>
								<td>- Defines database schema for cities and their corresponding sunrise/sunset times<br>- Establishes relationships between City and SunriseSunset entities, including geo-coordinates<br>- Configures model properties and constraints for data storage.</td>
							</tr>
							</table>
							<details>
								<summary><b>User</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Migrations/User/20240407233251_initialMigration.Designer.cs'>20240407233251_initialMigration.Designer.cs</a></b></td>
										<td>- Defines initial database schema for user authentication and authorization in the project, utilizing Microsoft Identity framework<br>- Configures tables for user roles, claims, logins, and tokens with necessary properties and relationships<br>- Establishes constraints and indexes for efficient data management and access control.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Migrations/User/20240407233251_initialMigration.cs'>20240407233251_initialMigration.cs</a></b></td>
										<td>- Creates initial database tables for user authentication and authorization in the project, defining structures for roles, users, role claims, user claims, logins, user roles, and tokens<br>- Manages relationships between these entities to enable secure access control and user management functionalities within the application.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Migrations/User/UserContextModelSnapshot.cs'>UserContextModelSnapshot.cs</a></b></td>
										<td>- Defines database schema for user authentication and authorization using Entity Framework Core in the Solar Watch project<br>- Configures tables for user roles, claims, logins, tokens, and relationships between users and roles<br>- Facilitates secure user management within the application.</td>
									</tr>
									</table>
								</blockquote>
							</details>
						</blockquote>
					</details>
					<details>
						<summary><b>Services</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Services/SolarWatchDbContext.cs'>SolarWatchDbContext.cs</a></b></td>
								<td>Defines database schema for cities and sunrise/sunset times, mapping relationships between them.</td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Services/UserContext.cs'>UserContext.cs</a></b></td>
								<td>Defines UserContext class extending IdentityDbContext for managing user and role data in the Solar Watch project, utilizing Entity Framework Core.</td>
							</tr>
							</table>
							<details>
								<summary><b>Repositories</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Services/Repositories/CityRepository.cs'>CityRepository.cs</a></b></td>
										<td>- Manages city data in the Solar Watch project, providing methods to retrieve, add, update, and delete city information from the database<br>- The CityRepository class acts as an intermediary between the application and the database, facilitating seamless interaction with city entities.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Services/Repositories/SunriseSunsetRepository.cs'>SunriseSunsetRepository.cs</a></b></td>
										<td>- Manages sunrise and sunset data in the Solar Watch project<br>- Retrieves, adds, updates, and deletes sunrise and sunset information for cities<br>- Acts as an interface between the application and the database for sunrise and sunset records.</td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Processor</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Services/Processor/IJsonProcessor.cs'>IJsonProcessor.cs</a></b></td>
										<td>- Defines interfaces for processing JSON data related to geo-coordinates, sunrise/sunset times, and city information<br>- This abstraction allows for decoupling of JSON processing logic from the main codebase, promoting modularity and flexibility in handling different types of JSON data within the Solar Watch project.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Services/Processor/JsonProcessor.cs'>JsonProcessor.cs</a></b></td>
										<td>- Processes JSON data to extract geo-coordinates, sunrise/sunset times, and city information<br>- Implements methods to parse and retrieve specific data fields for use in the Solar Watch project.</td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Authentication</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Services/Authentication/AuthService.cs'>AuthService.cs</a></b></td>
										<td>- Handles user authentication and authorization within the Solar Watch project<br>- The AuthService class manages user registration, login, and token verification<br>- It interacts with the Identity framework for user management and token generation<br>- This component plays a crucial role in securing access to the application's resources.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Services/Authentication/ITokenService.cs'>ITokenService.cs</a></b></td>
										<td>Defines an interface for creating authentication tokens based on user identity and role within the Solar Watch project.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Services/Authentication/AuthRequest.cs'>AuthRequest.cs</a></b></td>
										<td>Defines a data structure for handling authentication requests within the Solar Watch project.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Services/Authentication/IAuthService.cs'>IAuthService.cs</a></b></td>
										<td>- Defines authentication services interface for user registration, login, and token verification<br>- Facilitates user authentication processes within the Solar Watch project.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Services/Authentication/AuthenticationSeeder.cs'>AuthenticationSeeder.cs</a></b></td>
										<td>- Manages authentication roles and seeds initial admin user in the Solar Watch project<br>- Handles role creation and admin user setup using Identity framework<br>- Ensures 'Admin' and 'User' roles exist and creates an admin user if not already present.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Services/Authentication/TokenService.cs'>TokenService.cs</a></b></td>
										<td>- Generates JWT tokens for user authentication and authorization within the Solar Watch project<br>- The TokenService class creates tokens with specified expiration times, user claims, and signing credentials based on configuration settings<br>- This functionality enhances security and access control for the project's authentication services.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Services/Authentication/AuthResponse.cs'>AuthResponse.cs</a></b></td>
										<td>Defines an authentication response structure for the Solar Watch project, encapsulating user email and username.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Services/Authentication/AuthResult.cs'>AuthResult.cs</a></b></td>
										<td>- Defines an authentication result record with success status, email, username, and token fields<br>- Includes a dictionary for error messages.</td>
									</tr>
									</table>
								</blockquote>
							</details>
							<details>
								<summary><b>Utilities</b></summary>
								<blockquote>
									<table>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Services/Utilities/ISunApi.cs'>ISunApi.cs</a></b></td>
										<td>Defines an interface for retrieving sunrise and sunset times based on geographical coordinates and date.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Services/Utilities/IGeoCodingApi.cs'>IGeoCodingApi.cs</a></b></td>
										<td>Enables retrieving geographic coordinates for a given city, facilitating location-based functionality within the Solar Watch project.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Services/Utilities/GeoCodingApi.cs'>GeoCodingApi.cs</a></b></td>
										<td>- Implements a GeoCoding API service that retrieves coordinates for a given city using an API key<br>- Handles HTTP requests to the OpenWeatherMap API and logs responses<br>- If the city is not found, returns null; otherwise, returns the response content.</td>
									</tr>
									<tr>
										<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Services/Utilities/SunApi.cs'>SunApi.cs</a></b></td>
										<td>- Retrieve sunrise and sunset times by making an API call to fetch data based on provided coordinates and date<br>- The SunApi class encapsulates this functionality, utilizing HttpClient to communicate with the sunrise-sunset API.</td>
									</tr>
									</table>
								</blockquote>
							</details>
						</blockquote>
					</details>
					<details>
						<summary><b>Contracts</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Contracts/RegistrationRequest.cs'>RegistrationRequest.cs</a></b></td>
								<td>- Defines a data structure for user registration requests, enforcing required fields for email, username, and password<br>- This code file plays a crucial role in the project's architecture by standardizing the format of incoming registration data.</td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Contracts/RegistrationResponse.cs'>RegistrationResponse.cs</a></b></td>
								<td>Defines a data structure for handling registration responses in the Solar Watch project.</td>
							</tr>
							</table>
						</blockquote>
					</details>
					<details>
						<summary><b>Properties</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Properties/launchSettings.json'>launchSettings.json</a></b></td>
								<td>- Defines launch settings for various profiles in the Solar Watch project, specifying URLs, authentication settings, and environment variables<br>- Facilitates easy configuration of development environments with different launch options for HTTP and HTTPS protocols.</td>
							</tr>
							</table>
						</blockquote>
					</details>
					<details>
						<summary><b>Model</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Model/City.cs'>City.cs</a></b></td>
								<td>Defines the City model with properties for CityId, Name, Coordinates, Country, and SunriseSunset.</td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Model/SolarWatch.cs'>SolarWatch.cs</a></b></td>
								<td>- Defines a model for tracking solar data, including date, city, sunrise, and sunset times<br>- This class encapsulates essential information for solar monitoring within the project's architecture.</td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Model/GeoCoordinates.cs'>GeoCoordinates.cs</a></b></td>
								<td>Defines a class to store latitude and longitude coordinates, essential for location-based functionalities within the Solar Watch project.</td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Model/SunriseSunset.cs'>SunriseSunset.cs</a></b></td>
								<td>Defines sunrise and sunset data structure for cities in the Solar Watch project, facilitating accurate time tracking.</td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch/Solar_Watch/Model/JwtSettings.cs'>JwtSettings.cs</a></b></td>
								<td>- Defines JWT settings for authentication in the Solar Watch project, specifying the valid issuer and audience<br>- This class plays a crucial role in ensuring secure communication and authorization within the codebase architecture.</td>
							</tr>
							</table>
						</blockquote>
					</details>
				</blockquote>
			</details>
		</blockquote>
	</details>
	<details> <!-- Solar_Watch_Frontend Submodule -->
		<summary><b>Solar_Watch_Frontend</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch_Frontend/.eslintrc.cjs'>.eslintrc.cjs</a></b></td>
				<td>- Define linting rules for a React frontend project to ensure code quality and consistency<br>- The configuration enforces best practices, including recommended ESLint rules, React-specific guidelines, and React Hooks usage<br>- It also sets up parser options and ignores certain directories for linting<br>- The file plays a crucial role in maintaining clean and error-free code in the project.</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch_Frontend/package-lock.json'>package-lock.json</a></b></td>
				<td>- The code file provided in Solar_Watch_Frontend/package-lock.json manages the dependencies for the Solar Watch Frontend project<br>- It ensures that the necessary libraries like React, React DOM, and React Router DOM are included and maintained at specific versions<br>- This file plays a crucial role in orchestrating the frontend architecture by handling the versioning and resolution of dependencies, enabling a stable and efficient development environment for the project.</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch_Frontend/vite.config.js'>vite.config.js</a></b></td>
				<td>- Configures Vite to enable React support and sets up a proxy for API requests to a local server<br>- This file plays a crucial role in defining the project's build configuration and server settings, ensuring seamless integration of React components and proper routing of API requests during development.</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch_Frontend/package.json'>package.json</a></b></td>
				<td>- Manages frontend dependencies, scripts, and tooling for the Solar Watch project<br>- Handles development, building, linting, and previewing of the React application using Vite and ESLint<br>- Key dependencies include React, React Router, and related TypeScript types.</td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch_Frontend/index.html'>index.html</a></b></td>
				<td>- The index.html file serves as the entry point for the Solar Watch Frontend project, setting up the basic structure for the Vite + React application<br>- It defines the initial HTML layout, includes necessary meta tags, and links to the main JavaScript file for the application logic<br>- This file plays a crucial role in initializing the frontend user interface for the project.</td>
			</tr>
			</table>
			<details>
				<summary><b>src</b></summary>
				<blockquote>
					<table>
					<tr>
						<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch_Frontend/src/index.css'>index.css</a></b></td>
						<td>- Define global styling for the frontend, ensuring consistent typography, color scheme, and button styles across the application<br>- Establish a clean and accessible user interface with a focus on readability and visual appeal.</td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch_Frontend/src/App.css'>App.css</a></b></td>
						<td>- Define the styling for the root element, logo animations, and card layout in the frontend interface<br>- Implement hover effects and a spinning animation for the logo<br>- Ensure responsive design with a max-width of 1280px and centralized content<br>- Additionally, provide a color scheme for specific elements like 'read-the-docs'.</td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch_Frontend/src/App.jsx'>App.jsx</a></b></td>
						<td>- The App component fetches user data and displays a Solar Watch application interface<br>- It leverages React Router for navigation and state management to render dynamic content based on user authentication status<br>- This file serves as the main entry point for the Solar Watch frontend, orchestrating user data retrieval and rendering the application layout.</td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch_Frontend/src/main.jsx'>main.jsx</a></b></td>
						<td>- Defines routing structure for Solar Watch frontend, rendering components based on URL paths<br>- Integrates React Router for navigation between Register, Login, and SolarWatch pages.ReactDOM creates the root element for the application.</td>
					</tr>
					</table>
					<details>
						<summary><b>Pages</b></summary>
						<blockquote>
							<table>
							<tr>
								<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch_Frontend/src/Pages/Login.jsx'>Login.jsx</a></b></td>
								<td>- Enables user login functionality by handling form submission, sending login credentials to the server, and displaying appropriate alerts<br>- Upon successful login, redirects users to the home page<br>- This component plays a crucial role in the frontend architecture by facilitating user authentication within the application.</td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch_Frontend/src/Pages/Register.jsx'>Register.jsx</a></b></td>
								<td>- Handles user registration by sending registration data to the backend API and displaying appropriate messages based on the response<br>- Upon successful registration, it alerts the user and navigates to the login page<br>- In case of errors, it displays a failure message and logs the error for debugging purposes.</td>
							</tr>
							<tr>
								<td><b><a href='https://github.com/szoszo23/Solar_Watch/blob/master/Solar_Watch_Frontend/src/Pages/SolarWatch.jsx'>SolarWatch.jsx</a></b></td>
								<td>- Generates a SolarWatch page allowing users to input a city and date to retrieve sunrise and sunset times<br>- Displays loading status and results dynamically<br>- Offers a clear button to reset inputs and a cancel button to navigate back<br>- Built with React and React Router for seamless user experience.</td>
							</tr>
							</table>
						</blockquote>
					</details>
				</blockquote>
			</details>
		</blockquote>
	</details>
</details>

---
##  Getting Started

###  Prerequisites

Before getting started with Solar_Watch, ensure your runtime environment meets the following requirements:

- **Programming Language:** CSharp
- **Package Manager:** Nuget, Npm


###  Installation

Install Solar_Watch using one of the following methods:

**Build from source:**

1. Clone the Solar_Watch repository:
```sh
❯ git clone https://github.com/szoszo23/Solar_Watch
```

2. Navigate to the project directory:
```sh
❯ cd Solar_Watch
```

3. Install the project dependencies:


**Using `nuget`** &nbsp; [<img align="center" src="https://img.shields.io/badge/C%23-239120.svg?style={badge_style}&logo=c-sharp&logoColor=white" />](https://docs.microsoft.com/en-us/dotnet/csharp/)

```sh
❯ dotnet restore
```


**Using `npm`** &nbsp; [<img align="center" src="" />]()

```sh
❯ echo 'INSERT-INSTALL-COMMAND-HERE'
```




###  Usage
Run Solar_Watch using the following command:
**Using `nuget`** &nbsp; [<img align="center" src="https://img.shields.io/badge/C%23-239120.svg?style={badge_style}&logo=c-sharp&logoColor=white" />](https://docs.microsoft.com/en-us/dotnet/csharp/)

```sh
❯ dotnet run
```


**Using `npm`** &nbsp; [<img align="center" src="" />]()

```sh
❯ echo 'INSERT-RUN-COMMAND-HERE'
```


###  Testing
Run the test suite using the following command:
**Using `nuget`** &nbsp; [<img align="center" src="https://img.shields.io/badge/C%23-239120.svg?style={badge_style}&logo=c-sharp&logoColor=white" />](https://docs.microsoft.com/en-us/dotnet/csharp/)

```sh
❯ dotnet test
```


**Using `npm`** &nbsp; [<img align="center" src="" />]()

```sh
❯ echo 'INSERT-TEST-COMMAND-HERE'
```

---

##  Contributing

<details closed>
<summary>Contributing Guidelines</summary>

1. **Fork the Repository**: Start by forking the project repository to your github account.
2. **Clone Locally**: Clone the forked repository to your local machine using a git client.
   ```sh
   git clone https://github.com/szoszo23/Solar_Watch
   ```
3. **Create a New Branch**: Always work on a new branch, giving it a descriptive name.
   ```sh
   git checkout -b new-feature-x
   ```
4. **Make Your Changes**: Develop and test your changes locally.
5. **Commit Your Changes**: Commit with a clear message describing your updates.
   ```sh
   git commit -m 'Implemented new feature x.'
   ```
6. **Push to github**: Push the changes to your forked repository.
   ```sh
   git push origin new-feature-x
   ```
7. **Submit a Pull Request**: Create a PR against the original project repository. Clearly describe the changes and their motivations.
8. **Review**: Once your PR is reviewed and approved, it will be merged into the main branch. Congratulations on your contribution!
</details>

<details closed>
<summary>Contributor Graph</summary>
<br>
<p align="left">
   <a href="https://github.com{/szoszo23/Solar_Watch/}graphs/contributors">
      <img src="https://contrib.rocks/image?repo=szoszo23/Solar_Watch">
   </a>
</p>
</details>
