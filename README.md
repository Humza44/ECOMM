# ECOMM
we will add the project details later.

# Project setup
Pre-requisite
1) Visual Studio > 2022
2) Postgre SQL > 15

# DB Setup
Add connection string in development.setting.json file under this parameter "ApplicationConnectionString"
Then you have to run the migration in the VS Package Manager Console from this command "Update-database".

Now you can run your project.

# Setup Login
Register user using this endpoint api/Account/RegisterAdmin Or you can use swagger 
Register model
{
  "username": "string",
  "email": "string",
  "password": "string"
}

after registration you can login.

and you can use the rest of the endpoints.


