# Madplanner Developer Guide

### Database 
    dotnet ef migrations add migration-name
    dotnet ef database update 

### Seeding Data
    Seeds data if there is none.

### Run Application
    dotnet watch

### TODO
 - Fix year on create madplan
 - Handle kcal and grams == 0 / null

### Features
 - Switch log to count amount of times a Ret has been switched
 - Auth
 - Statistics page with the amount of times each dish has been used
Rema 1000 API
https://cphapp.rema1000.dk/api/v3/products/404899?include=declaration,nutrition_info,declaration,warnings