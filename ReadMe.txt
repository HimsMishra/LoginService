
07.02.2021

DBContext --DML Operation (SQL Connection and SQL Command)
    OnModelCreating -- virtual function, major user in EF. follow open close principle.
    SaveChanges -- DML Operation
DBSet --Local Manipulations (DataTable)
DbContextOptions -- this class is meant for accessing the connection string from any source and providing to 
base class(DBContext)

Conclusion:-
    We identified, in this application 
        1. IUserRepository, UserRepository 
        2. ApplicationDBContext
    Who will allocate the memory of these two above classes? 
    Dotnet core support dependency resolver.
        IServiceCollection (Startup.cs)
            Microsoft.Extensions.DependencyInjection
    

10.02.2021
--to install global ef tool
dotnet tool install --global dotnet-ef
--to check installtion 
dotnet ef
-- to generate database
dotnet ef migrations add Test



    



