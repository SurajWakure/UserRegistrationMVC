UserRegistrationMVC         database name 



CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY, 
    Name NVARCHAR(100) NOT NULL,  
    Email NVARCHAR(255) UNIQUE NOT NULL, 
    Password NVARCHAR(255) NOT NULL, 
    Role NVARCHAR(50) NOT NULL  
);
