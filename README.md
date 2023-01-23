### Your Movie Database
## By Alex Johnson, Aitana Shough, Jennifer Holcomb, Dominik Magic, Richard Cha
# WIP

A client for users to manage their personal movie collection(s)

[Documentation](#api-documentation)

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

#### Database Schema



#### API Integration

Integration with [TheMovieDatabase API](https://developers.themoviedb.org/3/getting-started/introduction). 

![TheMovieDB logo](https://www.themoviedb.org/assets/2/v4/logos/v2/blue_long_2-9665a76b1ae401a510ec1e0ca40ddcb3b0cfe45f1d51b77a308fea0845885648.svg)




#### Stretch Goals

##### Functionality

* Add support for TV shows, books, and other media types
* Allow users to upload their own display photo


## #Setup/Installation Guide
 
# Set up the API
* Clone the repository 
* Navigate to the `MovieApi` folder
* Open a command line and enter the following:
  ```
  dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
  dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
  dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
  dotnet add package RestSharp --version 108.0.3	
  dotnet add package Newtonsoft.Json --version 13.0.2
  dotnet ef database update
  ```
* add a file in the PetShelterApi directory called `appsettings.json` and add the following code, replacing the password/user field with your credentials:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=PetShelterApi;uid=[YOUR_UID];pwd=[YOUR_PASSWORD];"
  }
}
```

# Running the program
* Start the API by opening a command line in the `MovieApi` directory and enter `dotnet run`


### API Documentation

## Endpoints
```
GET http://localhost:5000/api/animals/
GET http://localhost:5000/api/animals/{id}
POST http://localhost:5000/api/animals/
PUT http://localhost:5000/api/animals/{id}
DELETE http://localhost:5000/api/animals/{id}
```
    
## Query Examples
  * The following query will return all animals with pagination enabled (first page, 5 elements per page):
      ```
      GET https://localhost:5001/api/Animals?PageNumber=1&PageSize=5
      ```
  * You may query specific entry IDs by appending it to the end:
      ```
      GET https://localhost:5001/api/Animals/4
      ```

  * A body is required for POST requests. Example of a good request would be:
      ```
      { 
        "name": "Bongo Jones",
        "species": "Cat",
        "subSpecies": "Tabby",
        "age": 3,
      }
      ```
  * An ID is required for PUT requests (modifying an existing entry) including the ID of the entry:
      ```
      {
        "animalId": 1,
        "name": "Kvothe",
        "species": "Cat",
        "subSpecies": "Himalayan",
        "age": 10,
      }
      ```
  * To delete an entry, simply enter the id of the entry you'd like to delete:
      ```
      DELETE  https://localhost:5001/api/Animals/8
      ```


## Known Bugs
it doesnt work yet

## Thanks


## License

MIT License

Copyright (c) 2023 Alex Johnson, Aitana Shough, Jennifer Holcomb, Dominik Magik, Richard Cha

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.