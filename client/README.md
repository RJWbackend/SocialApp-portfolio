
# SocialApp - Dating Application

SocialApp is a modern dating application designed to connect people. Built with a .NET backend for the API and an Angular frontend for the client, SocialApp provides a seamless and feature-rich experience for users looking to find meaningful connections.

## Features

- **User Authentication**: Secure login and registration functionality.
- **User Profiles**: Edit profile details, including description, interests, location, and more.
- **Photo Gallery**: Upload and manage photos using the Cloudinary API.
- **Messaging**: Send and receive messages with other users.
- **Likes**: Like other users and view users who liked you.
- **Filters**: Filter matches based on age range, gender, and other criteria.
- **Detailed User Profiles**: View detailed profiles, including location, age, last active, member since, and more.
- **Tabs for Easy Navigation**:
  - **About**: View user descriptions and what they are looking for.
  - **Interests**: See user interests.
  - **Photo Gallery**: Browse user photos.
  - **Messages**: Send messages to users.

## Installation

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (for the API)
- [Node.js](https://nodejs.org/) and [Angular CLI](https://angular.io/cli) (for the client)
- A Cloudinary account for photo storage.

### Backend (API)

1. Clone the repository:bash
   git clone https://github.com/RJWbackend/SocialApp-portfolio.git
   cd socialapp/API
   ```

2. Restore dependencies:
   
   dotnet restore3. Update the `appsettings.json` file with your database connection string and Cloudinary API credentials.

4. Run the API:
   
   dotnet run

1. Navigate to the client directory:
   
   cd socialapp/client. Install dependencies:
   
   npm install. Start the development server:
   
   ng serve. Open your browser and navigate to `http://localhost:4200/`.

## Usage

1. **Register/Login**: Create an account or log in with your credentials.
2. **Edit Profile**: Update your profile details, including description, interests, and location.
3. **Upload Photos**: Add photos to your gallery using the Cloudinary API.
4. **Find Matches**: Use filters to find matches based on age range and gender.
5. **Interact with Users**: Like users, send messages, and view detailed profiles.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

For more information or contributions, feel free to contact the project maintainers.
