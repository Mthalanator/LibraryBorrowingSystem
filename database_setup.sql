IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'library')
BEGIN
    CREATE DATABASE library;
END
GO

USE library;
GO

-- Drop child and parent tables in safe order
IF OBJECT_ID('borrowrecords', 'U') IS NOT NULL DROP TABLE borrowrecords;
IF OBJECT_ID('borrow_records', 'U') IS NOT NULL DROP TABLE borrow_records;
IF OBJECT_ID('books', 'U') IS NOT NULL DROP TABLE books;
IF OBJECT_ID('members', 'U') IS NOT NULL DROP TABLE members;
GO

-- 1. Create books table
CREATE TABLE books (
    book_id INT PRIMARY KEY IDENTITY(0, 1),
    title VARCHAR(100) NOT NULL,
    author VARCHAR(100) NOT NULL,
    genre VARCHAR(50) NOT NULL,
    available BIT NULL DEFAULT 1
);
GO

-- 2. Create members table
CREATE TABLE members (
    member_id INT PRIMARY KEY IDENTITY(0, 1),
    name VARCHAR(100) NOT NULL,
    email VARCHAR(50) NULL
);
GO

-- 3. Create borrow_records table
CREATE TABLE borrow_records (
    transaction_id INT PRIMARY KEY IDENTITY(1, 1),
    book_id INT NOT NULL,
    member_id INT NOT NULL,
    borrow_date DATE NOT NULL,
    due_date DATE NOT NULL,
    return_date DATE NULL,
    FOREIGN KEY (book_id) REFERENCES books(book_id),
    FOREIGN KEY (member_id) REFERENCES members(member_id)
);
GO

-- Populate books table
INSERT INTO books (title, author, genre, available) VALUES
('To Kill a Mockingbird', 'Harper Lee', 'Fiction', 1),
('1984', 'George Orwell', 'Dystopian', 1),
('Pride and Prejudice', 'Jane Austen', 'Romance', 1),
('The Great Gatsby', 'F. Scott Fitzgerald', 'Classic', 1),
('Moby Dick', 'Herman Melville', 'Adventure', 1),
('The Catcher in the Rye', 'J.D. Salinger', 'Fiction', 1),
('The Hobbit', 'J.R.R. Tolkien', 'Fantasy', 1),
('War and Peace', 'Leo Tolstoy', 'Historical', 0),
('The Odyssey', 'Homer', 'Epic', 1),
('Brave New World', 'Aldous Huxley', 'Dystopian', 1);
GO

-- Populate members table
INSERT INTO members (name, email) VALUES
('Edsger Dijkstra', 'dijkstrae@gmail.com'),
('Haskell Curry', 'curryh@gmail.com'),
('Ada Lovelace', 'lovelacea@gmail.com'),
('John Conway', 'conwayj@gmail.com'),
('John Carmack', 'carmackj@gmail.com'),
('Donald Knuth', 'knuthd@gmail.com'),
('Dennis Ritchie', 'ritchied@gmail.com'),
('Linus Torvalds', 'torvaldsl@gmail.com'),
('Tony Hoare', 'hoaret@gmail.com'),
('Alan Turing', 'turinga@gmail.com');
GO

-- Insert initial borrow records
SET IDENTITY_INSERT borrow_records ON;
INSERT INTO borrow_records (transaction_id, book_id, member_id, borrow_date, due_date, return_date) VALUES
(1, 3, 1, '2024-12-09', '2024-12-23', '2024-12-10'),
(1002, 7, 1, '2024-11-25', '2024-12-07', NULL);
SET IDENTITY_INSERT borrow_records OFF;
GO