UserRegistrationMVC         database name 



CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,  -- Auto-incrementing ID
    Name NVARCHAR(100) NOT NULL,       -- User's name
    Email NVARCHAR(255) UNIQUE NOT NULL, -- Unique Email
    Password NVARCHAR(255) NOT NULL,   -- Hashed Password Storage
    Role NVARCHAR(50) NOT NULL         -- Role (e.g., Admin, User)
);
