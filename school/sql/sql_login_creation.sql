CREATE LOGIN usertest WITH PASSWORD = 'ChangeMe123!' , DEFAULT_DATABASE = [vendas]
GO
CREATE USER usertest FOR LOGIN [usertest]
GO
