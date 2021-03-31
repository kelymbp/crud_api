# crud_api
This is a simple API to Create, Read, Update and Delete itens from database.

This implementation doesn't have an interface, you can manipulate this just through the endpoints.

You can open this solution in Visual Studio, run and use endpoints inside Postman, for example.

The solution has only an entity named "Clientes".

The available endpoints are:

POST http://localhost:51688/api/Clientes?nome="name"

GET http://localhost:51688/api/Clientes

DELETE http://localhost:51688/api/Clientes?nome="name"

PUT http://localhost:51688/api/Clientes?id="number"&nome="name"

The database server it's set inside the project folder.

---
Initial code was based on https://www.youtube.com/watch?v=_8jvU15p9p4

Database code was based on https://www.youtube.com/watch?v=yBsl84hDtUg&t=739s
