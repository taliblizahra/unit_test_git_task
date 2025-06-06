# Quadratic Solver Project

## Overview
This project is a simple C# (.NET Core) library that finds the real roots of a quadratic equation:

a·x² + b·x + c = 0

It includes:
- **QuadraticSolver**: A class library with a single `Solve(a, b, c)` method.
- **QuadraticSolver.Tests**: An xUnit test suite verifying “no roots,” “one root,” “two roots,” and invalid‐input cases.

## Project Structure

QuadraticSolverExercise/
├─ QuadraticSolver/              # Class library
│   └─ QuadraticEquation.cs
├─ QuadraticSolver.Tests/        # xUnit tests
│   └─ QuadraticEquationTests.cs
├─ .gitignore
├─ README.md                     # (this summary)
└─ GitBranchingEvidence.pdf       # Screenshots from Learn Git Branching

## Solver Code (in QuadraticEquation.cs)
- Checks that `a != 0`; throws `ArgumentException` otherwise.
- Computes `D = b² – 4ac`.
  - If `D < 0`: returns an empty array (no real roots).
  - If `D ≈ 0`: returns one root `–b/(2a)`.
  - If `D > 0`: returns two real roots sorted in ascending order.

A tiny epsilon (`1e-12`) ensures floating‐point rounding doesn’t misclassify a double root.

## Tests (in QuadraticEquationTests.cs)
We use xUnit’s `[Theory]` with `[InlineData]` to cover multiple inputs in each method:
1. **No real roots**: `Assert.Empty(...)` for cases like `x² + 1 = 0`.
2. **One real root**: `Assert.Single(...)` + `Assert.Equal(..., precision:10)` for double‐root scenarios.
3. **Two real roots**: `Assert.Equal(2, length)` + `Assert.Equal(...)` to check sorted results.
4. **Invalid input** (`a = 0`): `Assert.Throws<ArgumentException>(…)`.

This approach keeps tests concise and clear.

## Build & Run
1. Open a terminal at the solution root.
2. Build library:
   ```bash
   cd QuadraticSolver
   dotnet build

	3.	Run tests:

cd ../QuadraticSolver.Tests
dotnet test



All tests should pass (7 total test cases).

Git & Branching Evidence
	•	The Git history (on GitHub) includes a master branch and a small feature branch (e.g., adding XML docs).
	•	GitBranchingEvidence.pdf shows two screenshots from https://learngitbranching.js.org/:
	1.	Finishing the “Introduction” exercises (commits/merges).
	2.	Finishing the “Push & Pull – Remote Repositories” exercises.

The README here points to the GitHub repo so anyone can explore the full commit history.

⸻

GitHub URL:
https://github.com/taliblizahra/unit_test_git_task
