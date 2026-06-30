---
description: Generate a structured PR title and body based on commits vs a target branch. Returns structured data consumed by /create-pr.
argument-hint: <target-branch> (e.g. main, develop)
---

## Process

1. Determine the target branch:
   - If `$ARGUMENTS` is provided, use it as the base branch
   - Otherwise, default to `main`

2. Run `git log <target-branch>..HEAD --oneline` to list all commits in scope

3. Run `git log <target-branch>..HEAD` for full commit messages

4. Analyze and group commits by theme (e.g. features, fixes, UX, auth, infra...)

5. Output the result in the format below

## Output format

Output two clearly delimited blocks — no extra text around them:

```
PR_TITLE: <short title — if target is main, prefix with "MEP : ">
```

Then the PR body wrapped in a markdown code block (` ```md ` ... ` ``` `):

```md
## Summary

<1 sentence describing the overall goal of this PR>

### <Theme 1>

- <change>
- <change>

### <Theme 2>

- <change>

---

## Test plan

- [ ] <test step>
- [ ] <test step>
```

## Rules

- Group commits semantically, not chronologically
- If only 1-2 commits exist, keep the summary short (no need for multiple sections)
- Never include commit hashes in the output
- Write in the same language as the commit messages
- Always wrap the PR body in a ` ```md ` code block so it is copy-paste ready