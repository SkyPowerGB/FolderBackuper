# 📁 Folder Backup 

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


## 🧩 Technologies & Libraries

- **.NET Framework**
  - `System.IO` — for file and directory operations (`File`, `Directory`)
  - `System.Windows.Forms` — for UI and folder selection (`FolderBrowserDialog`, tray icon, etc.)
- [Newtonsoft.Json](https://www.newtonsoft.com/json) — for JSON serialization (storing folder lists, settings, etc.)
--

## 🐛 Known Bugs

- 🔁 Interval mode only activates after application restart
- 📥 Tray icon duplication under certain conditions
- ❌ Crashes when adding duplicate folders

---
## ⚠️ Behavior Notes & Limitations

- Backups **overwrite** the contents of the destination folder by default.
- Alternatively, backups can be saved to **separate timestamped folders** for versioning.
- ⚠️ **Warning**: For large folders or frequent backups, this process may be inefficient. The app performs full copies each time without incremental or differential backup optimizations.


## 📦 Status

This project is archived and no longer maintained. It was created for personal use .

---
