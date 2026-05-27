# QA Training Project

## Branches

- **`exercise`** — Download this branch to work on the exercises.
- **`answers-exercises`** — Contains all the answers for the exercises. Use it to check your work.

## Project Structure

The API you will be testing is located in **`ApiToTest/CalculatorApi`**. You don't need to understand the code there — just check the README file inside that folder for instructions on how to build and run the API.

Inside **`BasicTraining`** you will find the first module of exercises to complete.

## Getting Started

### 1. Generate an SSH Key

If you don't already have an SSH key, generate one:

```bash
ssh-keygen -t ed25519 -C "your_email@example.com"
```

When prompted, press **Enter** to accept the default file location and optionally set a passphrase.

Then start the SSH agent and add your key:

```bash
eval "$(ssh-agent -s)"
ssh-add ~/.ssh/id_ed25519
```

### 2. Add the SSH Key to Your GitHub Account

Copy your public key to the clipboard:

```bash
cat ~/.ssh/id_ed25519.pub
```

Then go to **GitHub > Settings > SSH and GPG keys > New SSH key**, paste the key, and save.

### 3. Clone the Repository

```bash
git clone git@github.com:Code-Hub-Repo/qa-training-project.git
```

### 4. Switch to the Exercise Branch

```bash
cd qa-training-project
git checkout exercise
```

This is the branch you will use to complete the exercises. When you want to review the answers, switch to the `answers-exercises` branch:

```bash
git checkout answers-exercises
```
