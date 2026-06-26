# Programming Archive

School and university programming projects in a single repository.

## Projects

| Name | When | Path | Stack | Summary |
|------|------|------|-------|---------|
| dtworkshops | 1st year secondary · 2021 | [school/dtworkshops/](school/dtworkshops/) | C | Car workshop console application |
| WinForms | 2nd year secondary · 2022 | [school/csharp/winforms_apps/](school/csharp/winforms_apps/) | C#, WinForms | Class assignments — Notepad, editor, calculator, games |
| school-portal | 2nd year secondary · 2022 | [school/school-portal/](school/school-portal/) | C#, WinForms, SQL Server | Faculty and alumni portal |
| SQL | Secondary school | [school/sql/](school/sql/) | SQL Server | Database scripts and schemas |
| SportsLink | 3rd year secondary · 2023 | [school/sportslink/](school/sportslink/) | Django, Python | Social network with auth, posts, and profiles |
| CSecurity | Last semester · 2025/26 | [university/csecurity-web/](university/csecurity-web/) | HTML, CSS, JavaScript | IT course — cybersecurity website |
| Quiz HCT | 26 Jun 2026 | [university/web/quiz-hct/](university/web/quiz-hct/) | HTML, CSS, JavaScript | Study quiz for History of Science and Technology |
| Minesweeper | 2026 | [university/cpp/minesweeper/](university/cpp/minesweeper/) | C++ | Console minesweeper |
| WPF Toolkit | 2026 | [university/csharp/wpf-toolkit/](university/csharp/wpf-toolkit/) | C#, WPF | BMI calculator, dice game, MVVM |
| LINQ School | 2026 | [university/csharp/linq-school/](university/csharp/linq-school/) | C#, LINQ | School data queries |

## Structure

```
programming-archive/
├── school/
│   ├── dtworkshops/
│   ├── school-portal/
│   ├── sportslink/
│   ├── csharp/winforms_apps/
│   └── sql/
└── university/
    ├── csecurity-web/
    ├── web/quiz-hct/
    ├── cpp/minesweeper/
    └── csharp/
        ├── wpf-toolkit/
        └── linq-school/
```

## Setup

See each project's `README.md`.

```bash
cd school/sportslink && pip install -r requirements.txt && python manage.py migrate && python manage.py runserver
open university/csecurity-web/index.html
open university/web/quiz-hct/index.html
```

## License

See [LICENSE](LICENSE).
