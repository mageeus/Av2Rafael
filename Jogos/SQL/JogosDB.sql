-- Criação do banco de dados
CREATE DATABASE JogosDB;
GO

USE JogosDB;
GO

-- Criação da tabela Categoria
CREATE TABLE Categoria (
    CategoriaID INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100)
);
GO

-- Criação da tabela Jogos
CREATE TABLE Jogos (
    JogoID INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100),
    DataLancamento DATE,
    Quantidade INT
);
GO

-- Criação da tabela de junção JogosCategoria
CREATE TABLE JogosCategoria (
    JogoCategoriaID INT PRIMARY KEY IDENTITY(1,1),
    JogoID INT,
    CategoriaID INT,
    FOREIGN KEY (JogoID) REFERENCES Jogos(JogoID),
    FOREIGN KEY (CategoriaID) REFERENCES Categoria(CategoriaID)
);
GO
