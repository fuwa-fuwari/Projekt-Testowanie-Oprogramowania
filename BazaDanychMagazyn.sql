CREATE DATABASE MagazynDB;
GO
USE MagazynDB;
GO

/* =========================================================================
   CZĘŚĆ 1: STRUKTURA BAZY DANYCH (DDL)
========================================================================= */

-- Tabela Uprawnień
CREATE TABLE Uprawnienia (
    UprawnienieID INT IDENTITY(1,1) PRIMARY KEY,
    Nazwa NVARCHAR(50) NOT NULL UNIQUE
);

-- Tabela Użytkowników
CREATE TABLE Uzytkownicy (
    UzytkownikID INT IDENTITY(1,1) PRIMARY KEY,
    Login NVARCHAR(50) NOT NULL UNIQUE, 
    HasloHash NVARCHAR(255) NOT NULL, 
    Imie NVARCHAR(50) NOT NULL,
    Nazwisko NVARCHAR(50) NOT NULL, 
    Miejscowosc NVARCHAR(100) NOT NULL, 
    KodPocztowy NVARCHAR(6) NOT NULL, 
    Ulica NVARCHAR(100) NULL, 
    NumerPosesji NVARCHAR(10) NOT NULL, 
    NumerLokalu NVARCHAR(10) NULL, 
    PESEL CHAR(11) NOT NULL UNIQUE, 
    DataUrodzenia DATE NOT NULL, 
    Plec NVARCHAR(20) NOT NULL, 
    Email NVARCHAR(255) NOT NULL UNIQUE, 
    Telefon CHAR(9) NOT NULL, 
    
    -- Mechanizm logowania
    LiczbaBlednychLogowan INT DEFAULT 0, 
    KontoZablokowaneDo DATETIME NULL, 
    
    -- Mechanizm RODO (Zapomnienie)
    CzyZapomniany BIT DEFAULT 0, 
    DataZapomnienia DATETIME NULL, 
    ZapomnianyPrzezID INT NULL FOREIGN KEY REFERENCES Uzytkownicy(UzytkownikID) 
);

-- Tabela łącząca Użytkowników z Uprawnieniami (Relacja Wiele-do-Wielu)
CREATE TABLE Uzytkownicy_Uprawnienia (
    UzytkownikID INT FOREIGN KEY REFERENCES Uzytkownicy(UzytkownikID),
    UprawnienieID INT FOREIGN KEY REFERENCES Uprawnienia(UprawnienieID),
    PRIMARY KEY (UzytkownikID, UprawnienieID) 
);

-- Historia haseł (do sprawdzania 3 ostatnich)
CREATE TABLE HistoriaHasel (
    HistoriaID INT IDENTITY(1,1) PRIMARY KEY,
    UzytkownikID INT FOREIGN KEY REFERENCES Uzytkownicy(UzytkownikID),
    HasloHash NVARCHAR(255) NOT NULL,
    DataZmiany DATETIME DEFAULT GETDATE()
); 

-- Słownik rodzajów towarów
CREATE TABLE RodzajeTowarow (
    RodzajID INT IDENTITY(1,1) PRIMARY KEY,
    Nazwa NVARCHAR(100) NOT NULL UNIQUE
); 

-- Tabela główna towarów
CREATE TABLE Towary (
    TowarID INT IDENTITY(1,1) PRIMARY KEY,
    Nazwa NVARCHAR(255) NOT NULL, 
    RodzajID INT FOREIGN KEY REFERENCES RodzajeTowarow(RodzajID), 
    JednostkaMiary NVARCHAR(20) NOT NULL, 
    Opis NVARCHAR(MAX) NULL 
);

-- Tabela zmian stawek VAT (historia planowanych stawek)
CREATE TABLE StawkiVAT (
    StawkaID INT IDENTITY(1,1) PRIMARY KEY,
    TowarID INT FOREIGN KEY REFERENCES Towary(TowarID),
    WartoscVAT DECIMAL(5,2) NOT NULL, 
    ObowiazujeOd DATE NOT NULL 
);

-- Rejestracja dostaw do magazynu
CREATE TABLE RejestracjaDostaw (
    RejestracjaID INT IDENTITY(1,1) PRIMARY KEY,
    TowarID INT FOREIGN KEY REFERENCES Towary(TowarID),
    Ilosc DECIMAL(18,2) NOT NULL, 
    CenaNetto DECIMAL(18,2) NOT NULL, 
    ZastosowanyVAT DECIMAL(5,2) NOT NULL, 
    Dostawca NVARCHAR(255) NOT NULL, 
    DataDostawy DATE NOT NULL,
    DataRejestracji DATETIME DEFAULT GETDATE(),
    RejestrujacyUzytkownikID INT FOREIGN KEY REFERENCES Uzytkownicy(UzytkownikID) 
);

-- Stany magazynowe (Tabela pomocnicza dla szybkiego odczytu)
CREATE TABLE StanyMagazynowe (
    TowarID INT PRIMARY KEY FOREIGN KEY REFERENCES Towary(TowarID),
    IloscDostepna DECIMAL(18,2) NOT NULL DEFAULT 0
); 

-- Rejestracja Sprzedaży (Nagłówek)
CREATE TABLE Sprzedaz (
    SprzedazID INT IDENTITY(1,1) PRIMARY KEY,
    NazwaKlienta NVARCHAR(255) NOT NULL, 
    AdresKlienta NVARCHAR(255) NOT NULL, 
    DataSprzedazy DATETIME DEFAULT GETDATE(),
    SprzedawcaID INT FOREIGN KEY REFERENCES Uzytkownicy(UzytkownikID)
);

-- Pozycje na dokumencie sprzedaży
CREATE TABLE PozycjeSprzedazy (
    PozycjaID INT IDENTITY(1,1) PRIMARY KEY,
    SprzedazID INT FOREIGN KEY REFERENCES Sprzedaz(SprzedazID),
    TowarID INT FOREIGN KEY REFERENCES Towary(TowarID),
    Ilosc DECIMAL(18,2) NOT NULL 
);
GO

/* =========================================================================
   CZĘŚĆ 2: WYPEŁNIANIE BAZY DANYMI (DML)
========================================================================= */

INSERT INTO Uprawnienia (Nazwa) VALUES 
('Administrator'), 
('Kierownik magazynu'), 
('Pracownik magazynu'), 
('Kierownik sprzedazy'), 
('Sprzedawca');

INSERT INTO Uzytkownicy (Login, HasloHash, Imie, Nazwisko, Miejscowosc, KodPocztowy, Ulica, NumerPosesji, NumerLokalu, PESEL, DataUrodzenia, Plec, Email, Telefon) VALUES
('admin1', 'hash123!', 'Jan', 'Kowalski', 'Warszawa', '00-001', 'Zlota', '11', '1', '80010112345', '1980-01-01', 'mężczyzna', 'admin1@firma.pl', '123456789'),
('kier_mag1', 'hash123!', 'Anna', 'Nowak', 'Krakow', '30-001', 'Florianska', '22', NULL, '85020223456', '1985-02-02', 'kobieta', 'anna.n@firma.pl', '987654321'),
('prac_mag1', 'hash123!', 'Piotr', 'Wisniewski', 'Poznan', '60-001', 'Polna', '33', '12', '90030334567', '1990-03-03', 'mężczyzna', 'piotr.w@firma.pl', '500600700'),
('prac_mag2', 'hash123!', 'Katarzyna', 'Wojcik', 'Wroclaw', '50-001', 'Dluga', '44', '5a', '92040445678', '1992-04-04', 'kobieta', 'kasia.w@firma.pl', '600700800'),
('kier_sprz1', 'hash123!', 'Tomasz', 'Kaminski', 'Gdansk', '80-001', 'Morska', '55', NULL, '88050556789', '1988-05-05', 'mężczyzna', 'tomek.k@firma.pl', '700800900'),
('sprz1', 'hash123!', 'Magdalena', 'Lewandowska', 'Lublin', '20-001', 'Krotka', '66', '3', '95060667890', '1995-06-06', 'kobieta', 'magda.l@firma.pl', '800900111'),
('sprz2', 'hash123!', 'Michal', 'Zielinski', 'Szczecin', '70-001', 'Waska', '77', NULL, '93070778901', '1993-07-07', 'mężczyzna', 'michal.z@firma.pl', '555666777'),
('user8', 'hash123!', 'Agnieszka', 'Szymanska', 'Bydgoszcz', '85-001', 'Szeroka', '88', '14', '91080889012', '1991-08-08', 'kobieta', 'aga.s@firma.pl', '444555666'),
('user9', 'hash123!', 'Krzysztof', 'Dabrowski', 'Katowice', '40-001', 'Stroma', '99', NULL, '89090990123', '1989-09-09', 'mężczyzna', 'krzys.d@firma.pl', '333444555'),
('user10', 'hash123!', 'Monika', 'Kozlowska', 'Lodz', '90-001', 'Piotrkowska', '100', '2', '94101001234', '1994-10-10', 'kobieta', 'monika.k@firma.pl', '222333444');

INSERT INTO Uzytkownicy_Uprawnienia (UzytkownikID, UprawnienieID) VALUES
(1, 1), 
(2, 2), 
(3, 3),
(4, 3),
(5, 4), 
(6, 5),
(7, 5); 

INSERT INTO RodzajeTowarow (Nazwa) VALUES 
('Elektronika'), ('AGD'), ('Meble'), ('Narzedzia'), ('Materialy budowlane');

INSERT INTO Towary (Nazwa, RodzajID, JednostkaMiary, Opis) VALUES
('Telewizor 55 cali', 1, 'Sztuki', 'Smart TV 4K'),
('Laptop Biurowy', 1, 'Sztuki', '16GB RAM, 512GB SSD'),
('Pralka Automatyczna', 2, 'Sztuki', 'Ladowana od frontu, 7kg'),
('Lodowka No Frost', 2, 'Sztuki', 'Wysokosc 180cm, srebrna'),
('Biurko Narozne', 3, 'Sztuki', 'Drewniane z metalowymi nogami'),
('Krzeslo Obrotowe', 3, 'Sztuki', 'Ergonomiczne, czarne'),
('Wiertarka Udarowa', 4, 'Sztuki', 'Moc 800W, w walizce'),
('Zestaw Kluczy', 4, 'Sztuki', '108 elementow'),
('Gwozdzie Stalowe', 5, 'Kilogramy', 'Dlugosc 50mm'),
('Klej do plytek', 5, 'Kilogramy', 'Worek 25kg, elastyczny');

INSERT INTO StanyMagazynowe (TowarID, IloscDostepna) VALUES
(1, 15.00), (2, 30.00), (3, 10.00), (4, 5.00), (5, 20.00), 
(6, 50.00), (7, 40.00), (8, 25.00), (9, 100.50), (10, 200.00);

INSERT INTO StawkiVAT (TowarID, WartoscVAT, ObowiazujeOd) VALUES
(1, 23.00, '2023-01-01'), (2, 23.00, '2023-01-01'), (3, 23.00, '2023-01-01'), 
(4, 23.00, '2023-01-01'), (5, 23.00, '2023-01-01'), (6, 23.00, '2023-01-01'), 
(7, 23.00, '2023-01-01'), (8, 23.00, '2023-01-01'), (9, 8.00, '2023-01-01'), 
(10, 8.00, '2023-01-01');

INSERT INTO RejestracjaDostaw (TowarID, Ilosc, CenaNetto, ZastosowanyVAT, Dostawca, DataDostawy, RejestrujacyUzytkownikID) VALUES
(1, 15.00, 2100.00, 23.00, 'Hurtownia RTV', '2025-01-15', 3),
(2, 30.00, 3200.00, 23.00, 'Hurtownia IT', '2025-01-20', 3),
(9, 100.50, 12.50, 8.00, 'Bud-Pol', '2025-02-10', 4);

INSERT INTO Sprzedaz (NazwaKlienta, AdresKlienta, DataSprzedazy, SprzedawcaID) VALUES
('Janusz Kowalski', 'ul. Polna 1, 00-001 Warszawa', '2025-03-01', 6),
('Firma XYZ Sp. z o.o.', 'ul. Lesna 5, 30-002 Krakow', '2025-03-10', 7),
('Anna Nowak', 'ul. Krotka 2, 80-003 Gdansk', '2025-03-15', 6);

INSERT INTO PozycjeSprzedazy (SprzedazID, TowarID, Ilosc) VALUES
(1, 1, 1.00), 
(1, 8, 2.00), 
(2, 2, 5.00),  
(2, 6, 5.00), 
(3, 3, 1.00);  

INSERT INTO HistoriaHasel (UzytkownikID, HasloHash, DataZmiany) VALUES
(1, 'starehash1!', '2024-01-01'),
(1, 'starehash2!', '2024-06-01');
GO