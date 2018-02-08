# JavaScript

## 0) Initialize an NPM package in this folder

 -  create `.gitignore` file for `node_modules` directory
 -  save your dependencies to the `package.json` file

## 1) Green Fox Notebook Error Reporter

Build a webapp that people can use to report technical issues.

### Frontend

The application consists of two screens.

#### Home (index.html)

![home](assets/corsac-ori-form-js.png)

It is built up from:

 -  a navigation bar, with a link to the tickets screen
 -  a heading with the title of the page
 -  a form to register a ticket
     -  dropdown list with all the names from the database
     -  input field to set the manufacturer
     -  input field to set the serial number
     -  textarea to set the description
     -  a REPORT button which should start an AJAX call to the `/issues` endpoint with the form data

#### Tickets (tickets.html)

![list example](assets/corsac-ori-list-js.png)

It is built up from:

 -  a navigation bar, with a link to the home screen
 -  a heading with the title of the page
 -  a table to display all the tickets from the database
     -  In the last column you should render a delete button which will remove the ticket permanently (also from the database)

### Backend

The backend should handle all the issue related http requests and serve the static content for the application.

#### Static content

All the static files should be served from a dedicated folder (eg.: public, client, etc...)

#### Endpoints

##### GET `/issues`

This endpoint should be responsible to list the issues from the database.

 -  if there is no query parameter, the backend must send all the issues.
 -  if there is a manufacturer query parameter, the backend must filter only the issues with the given manufacturer
 -  if there is a user_id query parameter, the backend must filter only the the issues which are reported by the given user.

 Example query:

`http://localhost:8080/issues?manufacturer=dell`

 -  this should return a json with every ticket where the manufacturer is "dell"

```json
{
    "tickets":
    [
        {
            "id" : "21",
            "reporter" : "Egg",
            "manufacturer" : "dell",
            "serialNumber" : 123456789,
            "description" : "screen pixel error",
            "date" : "2018.01.10"
        },
        {
            "id" : "27",
            "reporter" : "Brian",
            "manufacturer" : "dell",
            "serialNumber" : 987654321,
            "description" : "touchpad is not working",
            "date" : "2018.01.17"
        }
    ]
}
```

`http://localhost:8080/issues?reporter=1`

 -  this should return a json with every ticket where the reporter's id is 1


`http://localhost:8080/issues`

 -  this should return a json with all the tickets from the database

##### POST `/issues`

This endpoint should:

 -  validate the sent data according to the following rules:
    -  reporter is a number
    -  manufacturer is set
    -  serial number is set
 -  supplement the issue with the current date
 -  save the issue into database if the reporter's name is valid

##### DELETE `/issues/:id`

This endpoint should delete the specified ticket if the request's header contains the Authorization `HTTP header` with the value of 'voala'

## 2) Question time

### a, What's the difference between Array.prototype.forEach and Array.prototype.map?

### b, Give us a an example usage of the map and forEach function.
