---
name: git
description: >
  Defines all Git commit message and branch naming conventions for this project.
  Trigger this skill whenever the user asks to create a commit, generate a commit message,
  name a branch, or review a commit. Always apply these rules without being asked — no exceptions.
  Use it proactively when running /commit, "commit this", "make a commit", "what should I name this branch",
  or any similar phrasing.
---

# Git Workflow Conventions

## Commit message checklist

Before outputting a commit message, verify:

- [ ] TYPE is from the approved list (see references)
- [ ] Emoji matches the type exactly (no emoji for PERF and REVERT)
- [ ] Scope is present and lowercase
- [ ] Subject line is imperative mood, max 72 chars, no trailing period
- [ ] Body explains WHY (not what — the diff shows that)
- [ ] Footer references ticket if one was provided

## Commit format

```
<TYPE><emoji>(<scope>): <short description>

[optional body — explain WHY]

[optional footer — Closes #N / Fixes #N / Refs #N]
```

## Type → emoji mapping (quick reference)

| Type | Emoji | Use when |
|---|---|---|
| `FEAT` | 🚀 | Brand new feature that didn't exist before |
| `NEW` | 🚀 | New element inside an existing feature |
| `UPDATE` | 🚀 | Enhancement to something that already exists |
| `FIX` | 🔧 | Bug fix |
| `PERF` | _(none)_ | Performance improvement only |
| `REVERT` | _(none)_ | Reverting a previous commit |
| `REFACTOR` | ♻️ | Code restructuring, no behavior change |
| `DOCS` | 📚 | Documentation only |
| `STYLE` | 🎨 | Formatting/whitespace only |
| `TEST` | ✅ | Adding or updating tests |
| `CHORE` | 🧹 | Dependencies, tooling, build config |
| `MERGE` | 🔄 | Branch merge commit |
| `STRUCT` | 📁 | File/folder structure reorganization |

## Canonical patterns

```
FIX🔧(auth): correct null check on login error response

Error message was not shown when credentials were invalid
because the null check on response.error was missing.

Fixes #87
```

```
UPDATE🚀(ui): add pagination to user list

Adds limit/offset query params to the user list view.
Default page size is 20, max is 100.
```

```
MERGE🔄(develop): merge feature/user-dashboard into develop
```

## Branch naming

Format: `<type>/[ticket-id-]short-description`

- Lowercase, hyphens only (no underscores, no uppercase)
- Include ticket ID when one exists
- Max ~50 chars after the prefix

```
feature/42-user-registration
fix/87-login-display-bug
refactor/users-sorting-logic
chore/update-nuget-packages
```

## When in doubt

Use the decision tree and full scope table in [references/conventions.md](references/conventions.md).