using System;
using Xunit;
using QuadraticSolver;

namespace QuadraticSolver.Tests
{
    public class SolverTests
    {
        [Fact]
        public void Solve_NoRealRoots_ReturnsZero()
        {
            var result = Solver.Solve(1, 0, 1); // x^2 + 1 = 0 → no real roots
            Assert.Equal(0, result.rootCount);
            Assert.Null(result.root1);
            Assert.Null(result.root2);
        }

        [Fact]
        public void Solve_OneRealRoot_ReturnsOne()
        {
            var result = Solver.Solve(1, 2, 1); // x^2 + 2x + 1 = 0 → x = -1
            Assert.Equal(1, result.rootCount);
            Assert.Equal(-1.0, result.root1 ?? throw new Exception("root1 is null"), 5);
            Assert.Null(result.root2);
        }

        [Fact]
        public void Solve_TwoRealRoots_ReturnsTwo()
        {
            var result = Solver.Solve(1, -3, 2); // x^2 - 3x + 2 = 0 → x = 1 və x = 2
            Assert.Equal(2, result.rootCount);

            double r1 = result.root1 ?? throw new Exception("root1 is null");
            double r2 = result.root2 ?? throw new Exception("root2 is null");

            Assert.True((r1 == 1.0 && r2 == 2.0) || (r1 == 2.0 && r2 == 1.0),
                        $"Expected roots to be 1 and 2, but got {r1} and {r2}");
        }

        [Fact]
        public void Solve_AIsZero_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Solver.Solve(0, 2, 1));
        }
    }
}