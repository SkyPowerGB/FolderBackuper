# 📁 Folder Backup Utility

> ⚠️ **[Warning]** This project is no longer in active development or maintenance.

A simple Windows desktop app that allows users to back up selected folders into a specific location, with automatic or manual options.

---

## ✨ Features

- 📂 Backup a list of folders to a target location
- 🕒 Two working modes:
  - Interval-based backup
  - One-time backup on startup (default)
- 👆 Manual backup trigger
- ❌ Remove folders from the list
- 🔻 Minimize to system tray on exit

---

## ⚙️ Installer

An installer is included in the project. It:
- Adds a shortcut to the **Startup** folder (runs automatically on system startup)
- Adds a shortcut to the **Desktop**

---

## 🧩 Libraries Used

- [Newtonsoft.Json](https://www.newtonsoft.com/json) — for JSON serialization

---

## 🐛 Known Bugs

- 🔁 Interval mode only activates after application restart
- 📥 Tray icon duplication under certain conditions
- ❌ Crashes when adding duplicate folders

---

## 📦 Status

This project is archived and no longer maintained. It was created for personal use .

---
