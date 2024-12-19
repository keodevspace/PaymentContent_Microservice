INSERT INTO Users (Name, Email, Password)
VALUES ('John Doe', 'john.doe@example.com', 'password123');

INSERT INTO Categories (Name)
VALUES ('Food'), ('Transport'), ('Entertainment');

INSERT INTO Transactions (UserId, CategoryId, Amount)
VALUES (1, 1, 50.00), (1, 2, 15.00), (1, 3, 100.00);

INSERT INTO TransactionCategories (TransactionId, CategoryId)
VALUES (1, 1), (1, 2); -- A transação 1 está associada às categorias 1 e 2
