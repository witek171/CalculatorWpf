﻿using Calculator.Core.Interfaces;

namespace Calculator.Core.Operations;

public class Addition : IOperation
{
    public string Symbol => "+";
    public double Execute(double a, double b) => a + b;
}