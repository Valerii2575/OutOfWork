# UnitOfWork

We are going do discuss the Unit of work design pattern with the help of
generic repository and and implementation using .NET Core 6 Web API.

## Repository Pattern

The repository pattern is used to create an abstraction layer 
between the data access layer and business layer of an application

This pattern helps to reduce code duplication and follows the DRY principle

It also help to create loose coupling between multiple components, 
when we want to change somthing inside the data access layer that time 
does not need to change another layer where we consume that functionality

Implementing repository patterns hepls us write unit test case efficiently and easily

## Unit of work

Repository pattern helps us creste abstraction, decouple the code,
and avoid redundant code.

## Configure application

    Create three class library projects inside the main solution

    - API
    - Core
    - Infrastructure
    - Services

    Add model class ProductDetails.cs inside the Core project.

    In Infrastructure project, add an implementation of all repositories that we created befor
    and add DbContextClass
    For work with DbContext, need to add references
        - Microsoft.EntityFrameworkCore
        - Microsoft.EntityFrameworkCore.SqlServer
        - Microsoft.EntityFrameworkCore.Tools

    and add reference to API
        - Microsoft.entityFramework.Design
        - Microsoft.EntityFrameworkCore.Sqlite - for work with SQLite server

    and add reference to Core project

    After that, create Extentions classes for used to registering DI services and configure 
    that inside the Program.cs

    Generate migration using command
    dotnet ef --startup-project ../OutOfWork.API  migrations add InitialDb

    and update DB
    dotnet ef --startup-project ../OutOfWork.API  database update

    ## Create Product Service and Controller

    Next, create a product service inside Service project 
    which we inject and consume inside the main controller


# Add Angular client application

In this part we will create dashboard

## First step

    - Install angular material
        ng add @angular/material
    - Install highcharts packages
        npm i highcharts-angular --save
        npm i highcharts --save 
    - Install Flex Layout package
        npm i @angular/flex-layout @angular/sdk --save

## Layout definition

    - Create the first layout
    - Create a component for Dashboard page
    - Use the first layout as a Parent Rout Component in app-routing.module.ts 
        and the Dashboard page as Child Component



