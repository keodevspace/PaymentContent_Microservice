CREATE OR REPLACE PROCEDURE AddUser(
    p_name IN NVARCHAR2,
    p_email IN NVARCHAR2,
    p_password IN NVARCHAR2
) AS
BEGIN
    INSERT INTO Users (Name, Email, Password)
    VALUES (p_name, p_email, p_password);
END;
/

CREATE OR REPLACE PROCEDURE AddCategory(
    p_name IN NVARCHAR2
) AS
BEGIN
    INSERT INTO Categories (Name)
    VALUES (p_name);
END;
/

CREATE OR REPLACE PROCEDURE AddTransaction(
    p_userId IN NUMBER,
    p_categoryId IN NUMBER,
    p_amount IN NUMBER
) AS
BEGIN
    INSERT INTO Transactions (UserId, CategoryId, Amount)
    VALUES (p_userId, p_categoryId, p_amount);
END;
/
