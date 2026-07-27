---
description: Create a GitHub PR directly using the gh CLI. Generates the title and body from commits then opens the PR on GitHub.
argument-hint: <target-branch> (required — e.g. main, develop)
---

## Process

1. If `$ARGUMENTS` is empty, stop and ask the user for a target branch before doing anything else.

2. Check that the current branch is not `main` or `master` — if it is, abort and warn the user.

3. Run `/create-pr-description $ARGUMENTS` to generate the PR title and body.

4. Parse the output:
   - Extract the title from the `PR_TITLE: ` line
   - Use everything after that line as the PR body

5. Push the current branch to remote if not already up to date:
   ```bash
   git push -u origin HEAD
   ```

6. Create the PR using the gh CLI:
   ```bash
   gh pr create \
     --base "$ARGUMENTS" \
     --title "<extracted title>" \
     --body "<extracted body>"
   ```

7. Output the PR URL returned by `gh pr create` so the user can open it directly.

## Rules

- NEVER create a PR targeting main without warning the user and asking for confirmation first.
- NEVER push if there are uncommitted changes — abort and tell the user to commit first.
- If `gh pr create` fails (e.g. PR already exists), surface the gh error message clearly.
- Do not push to remote unless step 5 is reached — no side effects before that.