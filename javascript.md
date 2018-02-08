# JavaScript

## 0) Initialize an NPM package in this folder

 -  create `.gitignore` file for `node_modules` directory
 -  save your dependencies to the `package.json` file

## 1) Green Fox Notebook Error Reporter

Build a webapp that people can use to report technical issues.

### Frontend

The application consists of two screens.

#### Home

![home](assets/corsac-ori-form-js.png)

It should have:

 -  a navigation bar, with a link to the tickets screen
 -  a heading with the title of the page
 -  a form to register a ticket
     -  dropdown list with all the names from the database
     -  input field to set the manufacturer
     -  input field to set the serial number
     -  textarea to set the description
     -  a REPORT button which should start an AJAX call to the `/report` endpoint with the form data

#### Tickets

![list example](assets/corsac-ori-list-js.png)

It should have:

 -  a navigation bar, with a link to the home screen
 -  a heading with the title of the page
 -  a table to display all the tickets from the database
     -  In the last column you should render a delete button which will remove the ticket permanently (also from the database)

### Backend
The backend should
  - validate incoming data
  - perform database calls

#### Endpoints
- you should create these endpoints:

##### GET `/`
This endpoint should render an HTML displaying the report form(explained above)

##### GET `/list`
This endpoint should send the list of all tickets.

##### POST `/report`
This endpoint should 
  - receive all the information of the error
  - supplement the issue with date
  - save the issue into database if the reporter's name is valid

##### POST `/complete/:id`
This endpoint should delete the specified ticket if the request's body contains `"secret" : "voala"`
  
##### GET `/list/query`
This endpoint should return all the tickets which has matching either manufactorer or reporter from the database

Example query:

`http://localhost:8080/list/query?manufacturer=dell`

- this should return a json with every ticket where the manufacturer is "dell"

```json
{
    "result": "ok",
    "tickets":
    [
        {
            "id" : "21",
            "reporter" : "Egg",
            "manufacturer" : "dell",
            "serialnumber" : 123456789,
            "description" : "screen pixel error",
            "date" : "2018.01.10"
        },
        {
            "id" : "27",
            "reporter" : "Szilvi",
            "manufacturer" : "dell",
            "serial number" : 987654321,
            "description" : "touchpad not working",
            "date" : "2018.01.17"
        }
    ]
}
```

`http://localhost:8080/list/query?reporter=Egg`

- this should return a json with every ticket where the reporter is "Egg"

## 2) Question time
  What’s the difference between class & prototypal inheritance in javascript?
