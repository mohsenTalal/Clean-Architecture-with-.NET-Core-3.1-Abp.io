**Over the past two years, I’ve read the teaching programmers how to build enterprise applications interface using Clean Architecture with .NET Core.  Recently, I’ve developed a new Clean Architecture Solution Template for .NET Core. and today I will share my our design with Abp.io template, is working as a microservices template.**

**This Solution template an of Clean Architecture with Abp.io and our proposal of design the new Clean Architecture Solution Template of API and microservices,a .NET Core Project template for building API and microservices-based on best practices, ASP.NET Core 3.1, and Clean Architecture.**
**ABP Documentation
ABP is an open-source application framework focused on ASP.NET Core based web application development. It also supports developing other types of applications.**

**ABP Documentation
ABP is an open-source application framework focused on ASP.NET Core based web application development. It also supports developing other types of applications.**

## Let’s start with an overview of Clean Architecture.

**Overview**


**With Clean Architecture, the Domain and Application layers are at the center of the design. This is known as the Core of the system.**

**We have two layers "Application" and "Application.Contracts"**
**Also, We have two layers "Domain" and "Domain.Shared" and Entity Framework Core layer    
The Domain layer contains enterprise logic and types and the Application layer contains business logic and types. The difference is that enterprise logic could be shared across many systems, whereas the business logic will typically only be used within this system.**

**Core should not be dependent on data access and other infrastructure, Infrastructure layer not implemented until now, next version I'll implement, So concerns so those dependencies are inverted. This is achieved by adding interfaces or abstractions within Core that are implemented by layers outside of Core. For example, if you wanted to implement the Repository pattern you would do so by adding an interface within Core and adding the implementation within Infrastructure.**
