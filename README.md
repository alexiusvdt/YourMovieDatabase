# Your Movie Database
#### By Alex Johnson, Aitana Shough, Jennifer Holcomb, Dominik Magic, Richard Cha

A client for users to manage their personal movie collections

[API Integration](#api-integration)

[Project Details](#project-details)

[Setup/Installation Guide](#setup/installation-guide)

[Bugs](#known-bugs)

[License](#license)


## Technologies Used

   * C#
   * ASP.Net 6
   * EFCore
   * MySQL
   * LINQ
   * Newtonsoft
   * RESTsharp
   * bootstrap

## Project Details

## Objectives

#### User Stories

A user can create and log in to a user profile.
When logged in, a user can:

* Search for a movie
* View movie details, including movie poster, title, overview, and release date
* Add a movie to a personal list/watchlist
* Mark movies they have watched
* Add a personal rating and/or review to a movie
* Create, view, update, and delete personal lists


### API Integration

Integration with [TheMovieDatabase API](https://developers.themoviedb.org/3/getting-started/introduction). 

![TheMovieDB logo](https://www.themoviedb.org/assets/2/v4/logos/v2/blue_long_2-9665a76b1ae401a510ec1e0ca40ddcb3b0cfe45f1d51b77a308fea0845885648.svg)




#### Stretch Goals

##### Functionality

* Add support for TV shows, books, and other media types
* Allow users to upload their own display photo


## #Setup/Installation Guide
 
 This project may be viewed online [if we acrually host it with Azure....]. Alternatively, you may clone it to your device.

 #### To run this project, you will need:
* .NET 6.0
[https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download)

* .NET Core CLI
```
dotnet tool install --global dotnet-ef --version 6.0.0
```

* API Key from [TMDB](https://developers.themoviedb.org/)
*Instructions on acquiring a free API key can be found [here](https://developers.themoviedb.org/3/getting-started/introduction).*

1. Clone this repository to your workspace.

2. Navigate to the `MovieClient` directory.

3. Create a file named `appsettings.json` with the following code. Be sure to update the Default Connection to your MySQL credentials.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=movie_database;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];",
  }
}
```

4. Create database via Migrations
```
dotnet ef database update
```

5. Install dependencies within the `MovieClient` directory
```
$ dotnet restore
````

6. Build and run the program 
 ```
 $ dotnet run
 ```

7. Enjoy!


# Running the program
* Start the client by opening a command line in the `MovieClient` directory and enter `dotnet run`



## Known Bugs
it doesnt work yet... SIKE it does now !

## Thanks


## License

MIT License

Copyright (c) 2023 Alex Johnson, Aitana Shough, Jennifer Holcomb, Dominik Magik, Richard Cha

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
