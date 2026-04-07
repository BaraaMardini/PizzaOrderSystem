# 🍕 Pizza Ordering System (C# Windows Forms)

## 📖 Overview
This project is a **Pizza Ordering System** built using C# and Windows Forms.

It allows users to customize their pizza by selecting size, crust type, toppings, and dining options, with real-time price calculation.

---

## 🚀 Features

### 🍕 Pizza Customization
- Select pizza size:
  - Small
  - Medium
  - Large
- Choose crust type:
  - Thin crust
  - Thick crust

### 🧀 Toppings Selection
- Extra Cheese
- Onion
- Mushroom
- Olives
- Tomatoes
- Green Peppers

### 🏪 Order Options
- Eat In
- Take Out

### 💰 Pricing System
- Dynamic total price calculation
- Updates automatically based on selections

### ✅ Order Management
- Confirm order (disables inputs)
- Reset order (clears all selections)

---

## 🧱 Technologies & Concepts
- **C#**
- **Windows Forms (WinForms)**
- **Event-Driven Programming**
- **GUI State Management**
- **User Input Handling**

---

## 🏗️ System Design

### 🔹 Form1
Main interface:
- Handles all user selections
- Updates UI labels dynamically
- Calculates total price

### 🔹 Event Handlers
- Radio buttons → size & crust
- Checkboxes → toppings
- Buttons → confirm & reset

---

## ⚙️ How It Works

1. User selects:
   - Pizza size
   - Crust type
   - Toppings
   - Dining option

2. System:
   - Updates total price dynamically
   - Displays selected options

3. User confirms order:
   - Inputs are disabled

4. User can reset:
   - All selections cleared
   - UI restored to default state

---

## ▶️ Example Use Case
- Simulates a simple restaurant ordering system with interactive UI.

---

## 📊 What I Learned
- Managing complex UI states in desktop applications
- Handling multiple event sources
- Building real-world interactive systems
- Structuring UI logic with dynamic updates

---

## 📌 Future Improvements
- Refactor code to reduce repetition
- Apply Object-Oriented Design (separate logic from UI)
- Add order summary screen
- Store orders in a database
- Improve UI/UX design

---
