# Projekt Magazyn

## Wymagania
* Visual Studio 2022
* Server dazy danych SQL Server
* SQL Server Management Studio

## Pierwsze uruchomienie
1. Pobierz i wypakuj repozytorium
2. Dodaj do ścieżki wykonawczej programu (Projekt-Testowanie-Oprogramowania-main\bin\Debug\) uzyskany plik secretsauce.json
3. Używając SQL SMS utwórz bazę na podstawie pliku REPO.sql
4. Skonfiguruj connectionString w pliku DatabaseConnection.cs aby odpowiadało Twojemu połączeniu z SQL Server
5. Otwórz rozwiązanie projektu ProjektMagazyn.sln w Visual Studio
6. Aby korzystać z odzyskiwania hasła zaloguj się w serwisie MailTrap(https://mailtrap.io/) używając danych z pliku secretsauce.json
   * możesz zostać poproszony o weryfikację kodem wysłanym na email projektu
   * zaloguj się w serwisie Proton Mail(https://account.proton.me/mail) używając danych z pliku secretsauce.json
7. Uruchom program (np. F5)