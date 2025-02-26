UserRegistrationMVC         database name 



CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY, 
    Name NVARCHAR(100) NOT NULL,  
    Email NVARCHAR(255) UNIQUE NOT NULL, 
    Password NVARCHAR(255) NOT NULL, 
    Role NVARCHAR(50) NOT NULL  
);


INSERT INTO Users (Name, Email, Password, Role) 
VALUES 
('John Doe', 'john@example.com', 'hashed_password_123', 'Admin'),
('Alice Smith', 'alice@example.com', 'hashed_password_456', 'User');

