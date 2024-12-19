CREATE TABLE TransactionCategories (
    TransactionId NUMBER NOT NULL,
    CategoryId NUMBER NOT NULL,
    PRIMARY KEY (TransactionId, CategoryId),
    FOREIGN KEY (TransactionId) REFERENCES Transactions(TransactionId),
    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);
