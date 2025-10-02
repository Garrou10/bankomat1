# Bankomat – OOP & Inkapsling

##  Beskrivning
En konsolbaserad bankomat som simulerar insättning, uttag och saldo med PIN-autentisering.

## ▶ Så här kör du
1. Öppna terminalen i projektmappen
2. Kör: `dotnet run`
3. Ange PIN: `1234`

##  Inkapsling
- `BankAccount` har ett **privat fält** `balance` som inte kan ändras direkt utifrån.
- Saldo exponeras via en **read-only property** `Balance`.
- Ändringar sker endast via metoder (`Deposit`, `Withdraw`) som **validerar input**.
- Detta skyddar datan och säkerställer att kontot alltid är i ett giltigt tillstånd.