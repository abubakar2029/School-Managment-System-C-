USE UafDB;

CREATE TABLE STUDENTS(
    StudentID INT PRIMARY KEY IDENTITY,
    Password NVARCHAR(50) NOT NULL,
    FullName NVARCHAR(100),
    Email NVARCHAR(100),
    IsApproved BIT DEFAULT 0
);

CREATE TABLE Faculty(
    FacultyID INT PRIMARY KEY IDENTITY,
    Password NVARCHAR(50) NOT NULL,
    FullName NVARCHAR(100),
    Email NVARCHAR(100),
    IsApproved BIT DEFAULT 0
);

CREATE TABLE Admin(
    AdminID INT PRIMARY KEY IDENTITY,
    Password NVARCHAR(50) NOT NULL,
    FullName NVARCHAR(100),
    Email NVARCHAR(100),
);

INSERT INTO STUDENTS (Password, FullName, Email, IsApproved) VALUES
('password123', 'Ali Ahmed', 'ali.ahmed@example.com', 1),
('password123', 'Aisha Khan', 'aisha.khan@example.com', 1),
('password123', 'Mohammad Asif', 'mohammad.asif@example.com', 1),
('password123', 'Fatima Noor', 'fatima.noor@example.com', 1),
('password123', 'Hassan Raza', 'hassan.raza@example.com', 1),
('password123', 'Zara Ali', 'zara.ali@example.com', 1),
('password123', 'Umar Farooq', 'umar.farooq@example.com', 1),
('password123', 'Sana Sheikh', 'sana.sheikh@example.com', 1),
('password123', 'Bilal Hussain', 'bilal.hussain@example.com', 1),
('password123', 'Rabia Siddiqui', 'rabia.siddiqui@example.com', 1);

INSERT INTO Faculty (Password, FullName, Email, IsApproved) VALUES
('faculty123', 'Dr. Ahmed Zubair', 'ahmed.zubair@example.com', 1),
('faculty123', 'Dr. Sana Malik', 'sana.malik@example.com', 1),
('faculty123', 'Dr. Asad Ullah', 'asad.ullah@example.com', 1),
('faculty123', 'Dr. Hira Sheikh', 'hira.sheikh@example.com', 1),
('faculty123', 'Dr. Kamran Aziz', 'kamran.aziz@example.com', 1),
('faculty123', 'Dr. Nadia Javed', 'nadia.javed@example.com', 1),
('faculty123', 'Dr. Faisal Rafiq', 'faisal.rafiq@example.com', 1),
('faculty123', 'Dr. Ayesha Tariq', 'ayesha.tariq@example.com', 1),
('faculty123', 'Dr. Shahid Nawaz', 'shahid.nawaz@example.com', 1),
('faculty123', 'Dr. Maryam Shafiq', 'maryam.shafiq@example.com', 1);

INSERT INTO Admin (Password, FullName, Email) VALUES
('admin123', 'Admin Ali', 'admin.ali@example.com');

