CREATE OR REPLACE TRIGGER set_transaction_date
BEFORE INSERT ON Transactions
FOR EACH ROW
BEGIN
    :NEW.TransactionDate := NVL(:NEW.TransactionDate, SYSDATE);
END;
/
