# Library Borrowing System

A C# Windows Forms desktop application developed for Omega Solutions[cite: 18] to automate library operations, patron checkouts, book returns, and real-time fine calculation.

## Features & Architecture
- **`frmBorrows` (Main Checkout Interface):** Connects to an external SQL database[cite: 18] to display live inventory and member grids with responsive search filters. Automatically validates book availability and enforces business logic (preventing the checkout of unavailable titles)[cite: 18].
- **`frmReturns` (Management & Returns Portal):** Launched via the `Manage` button[cite: 18], allowing staff to select a patron, view their active borrowed books, log returns, and automatically restore item availability.
- **Automated Fine Engine:** Instantly calculates overdue penalties at **R5 per late day** for any unreturned books past their due date, dynamically rendering the total balance owed (`Total fines owed: R{amount}`)[cite: 18].

## Technical Stack & Requirements
- **Language:** C# (.NET / Windows Forms)[cite: 18]
- **IDE:** Visual Studio[cite: 18]
- **Database:** SQL Server / Local database engine initialized via `database_setup.sql`[cite: 18]
- **Key Files:** `frmBorrows.cs`, `frmReturns.cs`, `database_setup.sql`[cite: 18]
