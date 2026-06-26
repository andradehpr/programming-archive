# SportsLink

Django social network for sports — profiles, posts, follows, and search.

**When:** 3rd year of secondary school (2023)

## Run

```bash
cp .env.example .env   # set DJANGO_SECRET_KEY, DJANGO_DEBUG, DJANGO_ALLOWED_HOSTS
python3 -m venv venv
source venv/bin/activate
pip install -r requirements.txt
python manage.py migrate
python manage.py runserver
```

Open http://127.0.0.1:8000/

Do not commit `.env` or `db.sqlite3`.
