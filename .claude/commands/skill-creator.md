# /skill-creator

You are an expert at creating skills for Claude Code. A skill is a `SKILL.md` file that gives Claude persistent, reusable instructions for accomplishing a specific type of task in this project.

---

## Skills structure in this project

Skills live in `.claude/skills/` 

---

## Your role when /skill-creator is invoked

Work through these stages in order. Don't skip ahead.

### Stage 1 — Capture intent

First, extract what you already know from the conversation (tools used, steps taken, corrections made, input/output formats observed). Then confirm with the user before proceeding. Answer these:

1. What should this skill enable Claude to do?
2. When should it trigger? (what user phrases or contexts)
3. What is the expected output format?
4. Which folder does it belong in? (`global/`, `api/`, or `client/`)

### Stage 2 — Interview

Ask about edge cases, input/output formats, example files, success criteria, and dependencies. Do not write the skill until this is clear.

### Stage 3 — Write the SKILL.md

Create `.claude/skills/<folder>/<skill-name>/SKILL.md` with this structure:

```markdown
---
name: skill-name
description: >
  One paragraph. What it does AND when to trigger it.
  Be specific — this is the primary triggering mechanism.
  Make it slightly "pushy": mention all the contexts where
  Claude should use this skill even without being asked explicitly.
---

# Skill Title

## Quick checklist
(For code-generation skills: a scannable list of rules to verify before outputting)

## Canonical patterns
(The 1-2 most common things this skill produces, shown as code examples)

## When in doubt
Read `references/<detail-file>.md` for full rules and edge cases.
```

Keep `SKILL.md` under 300 lines. Move anything longer than 50 lines of detail into `references/`.

### Stage 4 — Test it

Come up with 2-3 realistic prompts a real user would type. Share them with the user for approval, then execute each one yourself using the skill. Save outputs to `.claude/skills/<skill-name>-workspace/iteration-1/`.

### Stage 5 — Review & iterate

Show the user the outputs. Ask for feedback. Improve the skill and re-run until the user is happy.

---

## Anatomy of a good skill

```
skill-name/
├── SKILL.md            <- required; keep short (checklist + canonical patterns)
└── references/         <- optional; full rules, tables, detailed examples
    └── detail.md
```

**Three-level loading:**
1. `name` + `description` — always in context (~100 words)
2. `SKILL.md` body — loaded when skill triggers
3. `references/` files — loaded on demand from within SKILL.md

Keep SKILL.md as a fast-access checklist, not an encyclopedia.

---

## Writing principles

- **Imperative form** — "Use primary constructors", not "You should use primary constructors"
- **Explain the why** — LLMs follow reasoning better than rigid rules. Instead of "NEVER do X", explain why X causes problems.
- **Canonical examples** — one good and one bad example per rule is worth 10 lines of prose
- **Lean descriptions** — the `description` frontmatter must be specific enough to trigger on the right prompts and not on unrelated ones
- **Avoid over-constraining** — if you find yourself writing ALWAYS/NEVER in caps, step back and explain the reasoning instead

---

## Naming conventions

| Scope | Path | Example |
|---|---|---|
| Global | `.claude/skills/global/<name>/` | `global/csharp-conventions/` |
| API | `.claude/skills/api/<name>/` | `api/repository-pattern/` |
| Client | `.claude/skills/client/<name>/` | `client/component-conventions/` |

Skill folder names should match what users naturally say — `database` triggers better than `ef-core-internals`.