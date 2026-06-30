# Git Conventions — Full Reference

## Decision tree

```
Is it a bug fix?
  └─ YES → FIX🔧

Is it related to performance only?
  └─ YES → PERF

Is it a completely new feature that didn't exist before?
  └─ YES → FEAT🚀

Is it a new element INSIDE an existing feature?
  └─ YES → NEW🚀

Is it an improvement or addition to something that already exists?
  └─ YES → UPDATE🚀

Is it moving/renaming files or folders only?
  └─ YES → STRUCT📁

Is it code cleanup with no behavior change?
  └─ YES → REFACTOR♻️

Is it formatting only (spaces, indentation)?
  └─ YES → STYLE🎨

Is it tests only?
  └─ YES → TEST✅

Is it docs only?
  └─ YES → DOCS📚

Is it tooling, deps, CI config?
  └─ YES → CHORE🧹

Is it a merge commit?
  └─ YES → MERGE🔄

Is it undoing a previous commit?
  └─ YES → REVERT
```

---

## Scope table

| Scope | Area |
|---|---|
| `auth` | Authentication & authorization |
| `users` | User management |
| `api` | General API layer |
| `db` | Database, migrations, EF Core |
| `ui` | Frontend components |
| `infra` | Docker, deployment, infrastructure |
| `deps` | Dependencies and packages |
| `ci` | CI/CD pipelines |
| `config` | Configuration files |

---

## Good examples

```
FEAT🚀(auth): add user registration with email verification

Implements full registration flow including email confirmation.
Token expires after 24h and is single-use.

Closes #42
```

```
FIX🔧(auth): correct display bug on login page

Error message was not showing when credentials were invalid
due to missing null check on the response object.

Fixes #87
```

```
UPDATE🚀(users): add pagination to user list endpoint

Adds limit/offset query parameters to GET /users.
Default page size is 20, max is 100.

Refs #103
```

```
NEW🚀(users): add avatar upload support

Introduces POST /users/{id}/avatar endpoint.
Images are stored in Azure Blob Storage and served via CDN.

Closes #55
```

```
REFACTOR♻️(users): optimize data sorting logic

Replaces in-memory LINQ sort with server-side ORDER BY
to reduce memory usage on large datasets.
```

```
MERGE🔄(develop): merge feature/user-dashboard into develop
```

```
STRUCT📁(api): reorganize controllers by domain

Moves all user-related controllers into /Controllers/Users/
and all auth-related into /Controllers/Auth/.
No logic changed.
```

---

## Bad examples

```
fix bug                          # No type, no scope, too vague
FEAT: added stuff                # Past tense, no scope, no description
🚀 new feature                   # Emoji without type
feat(auth): Add JWT support.     # Lowercase type, period at end
WIP                              # Never commit WIP to shared branches
REFACTOR: changed some things    # Too vague, no scope
```

---

## Branch naming rules

- Lowercase only, hyphens to separate words
- Always include ticket ID if one exists
- Max 50 chars after prefix

### Good
```
feature/42-user-registration
fix/87-login-display-bug
refactor/users-sorting-logic
chore/update-nuget-packages
struct/reorganize-controllers
```

### Bad
```
my-branch
Feature/AddUserEndpoint        # Uppercase
fix_the_login                  # Underscores
johns-work                     # Never use personal names
```