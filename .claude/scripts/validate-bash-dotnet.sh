#!/bin/bash

# Read the hook input from stdin
HOOK_INPUT=$(cat)

# Extract the bash command
COMMAND=$(echo "$HOOK_INPUT" | jq -r '.tool_input.command' 2>/dev/null)

echo "[HOOK] Validating bash command: $COMMAND" >&2

# ❌ BLOCK: Destructive commands
if [[ "$COMMAND" =~ ^[[:space:]]*(rm|rmdir) ]]; then
    echo "Dangerous: Cannot run rm/rmdir commands" >&2
    exit 2
fi

if [[ "$COMMAND" =~ DROP\ TABLE|DELETE\ FROM|TRUNCATE ]]; then
    echo "Dangerous: Cannot run database deletion commands" >&2
    exit 2
fi

if [[ "$COMMAND" =~ sudo|pkill|kill\ -9 ]]; then
    echo "Dangerous: Cannot run privilege escalation or kill commands" >&2
    exit 2
fi

# ⚠️ WARNING: Potentially risky but allowed
if [[ "$COMMAND" =~ git\ push|git\ reset|git\ rebase ]]; then
    echo "Warning: This is a git mutation command. Review carefully." >&2
    exit 1
fi

# ✅ ALLOW: Safe commands
exit 0