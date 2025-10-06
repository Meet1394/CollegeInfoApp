# CollegeInfoApp

A small ASP.NET Core MVC sample app used for learning and demos. It contains models for students, teachers, and courses plus a few example views and static assets.

## What this repository contains
- C# source files, controllers, and Razor views
- Static web assets in `wwwroot/` (CSS, JS, images, vendor libs)
- A `.gitignore` configured for .NET projects

## Build & run (Windows, PowerShell)
1. Ensure you have the .NET SDK installed (recommended: .NET 9).
2. From the repository root run:

```powershell
cd /d e:\CollegeInfoApp
dotnet restore
dotnet build
dotnet run
```

3. Open the URL printed by `dotnet run` (usually `https://localhost:5001` or `http://localhost:5000`).

## Pushing changes to GitHub
If you make local changes and want to push them to the remote `origin/main`:

```powershell
git add -A
git commit -m "Describe your change"
git pull --rebase origin main
git push origin main
```

If you need to add a new remote or change it:

```powershell
# set remote (only if not already set)
git remote add origin https://github.com/<your-username>/CollegeInfoApp.git

# or change the URL of the existing remote
git remote set-url origin https://github.com/<your-username>/CollegeInfoApp.git
```

## Notes
- This repo currently tracks vendor files under `wwwroot/lib/` (Bootstrap, jQuery). If you'd prefer to fetch these at build time, consider using LibMan or npm and add vendor files to `.gitignore`.
- Do not commit secrets (API keys, passwords). Use User Secrets or environment variables.

## Want help?
Tell me if you want me to:
- add a CI workflow (GitHub Actions) to build on push
- replace vendor files with LibMan/npm
- add a development README with common tasks
