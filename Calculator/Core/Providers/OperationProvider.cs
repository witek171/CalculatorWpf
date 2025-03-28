﻿using Calculator.Core.Interfaces;
using Calculator.Core.Operations;

namespace Calculator.Core.Providers;

public class OperationProvider : IOperationProvider
{
    private static readonly IReadOnlyDictionary<string, IOperation> Operations = 
        new Dictionary<string, IOperation>
    {
        { "+", new Addition() },
        { "−", new Subtraction() },
        { "×", new Multiplication() },
        { "÷", new Division() },
        { "%", new Percentage() }
    };

    private static readonly IReadOnlyDictionary<string, IUnaryOperation> UnaryOperations = 
        new Dictionary<string, IUnaryOperation>
    {
        { "√x", new SquareRoot() },
        { "¹⁄ₓ", new Inversion() },
        { "+/-", new Negation() },
        { "x²", new PowerOfTwo() }
    };

    public IReadOnlyDictionary<string, IOperation> GetOperations() => Operations;
    public IReadOnlyDictionary<string, IUnaryOperation> GetUnaryOperations() => UnaryOperations;
}