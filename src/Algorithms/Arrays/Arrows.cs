using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallengeCollection.Algorithms.Arrays;

public static class Arrows
{
    /// <summary>
    /// You are given a string S representing a sequence of N arrows.
    /// Each arrow in the sequence points in one of the four directions: up ("^"), down ("v"), left ("<") or right (">").
    /// In one move, you can rotate an arrow anti-clock wise, for instance from up ("^") to left ("<").
    ///
    /// Write a solution that, given a string S of length N denoting the directions of the arrows,
    /// returns the minimum number of moves required to make all of the arrows point in the same direction.
    ///
    /// Examples:
    /// 1. For S = "^vv<", the function should return 3. It is optimal to rotate arrows so that all of them point down.
    /// 2. For S = "vv>>vv", the function should return 4. It is optimal to rotate arrows so that all of them point right.
    /// 3. For S = "<<<", the function should return 0. All arrows already point in the same direction.
    ///
    /// Assume that:
    /// . N is an integer within the range [1 .. 100];
    /// . string S is made only of the following characters: '<','^', '>' and/or 'v'.
    /// </summary>
    public static int Run(string s)
    {
        var indexes = new Dictionary<char, int> { { '^', 0 }, { '<', 1 }, { 'v', 2 }, { '>', 3 } };
        var directions = new [] { '^', '<', 'v', '>' };
        var minMoves = int.MaxValue;

        foreach (var targetDirection in directions)
        {
            var targetIndex = indexes[targetDirection];
            var moves = 0;

            foreach (var arrow in s)
            {
                var currentIndex = indexes[arrow];
                moves += (targetIndex - currentIndex + 4) % 4;
            }

            if (moves < minMoves)
            {
                minMoves = moves;
            }
        }

        return minMoves;
    }
}
