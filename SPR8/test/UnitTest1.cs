using SPR8;
using NUnit.Framework;
namespace test;

public class Tests
{
    [Test]
    public void MinPositiveTest()
    {
        int[] testArray = { 23, 45, 86, 17, 95, 67, 34 };
        Assert.AreEqual(17,CalculatorForVariousTasks.MinPositive(testArray));
    }
    
    [Test]
    public void MinPositiveNegativTest()
    {
        Assert.AreEqual(-1,CalculatorForVariousTasks.MinPositive(null));
    }
    
    [Test]
    public void SumOfNegativeNumbersTest()
    {
        int[] testArray = { -3,-8,-2,-3,-4 };
        Assert.AreEqual(-20,CalculatorForVariousTasks.SumOfNegativeNumbers(testArray));
    }
    
    [Test]
    public void SumOfNegativeNumbersNegativTest()
    {
        Assert.AreEqual(-1,CalculatorForVariousTasks.SumOfNegativeNumbers(null));
    }
    
    [Test]
    public void FibonacciTest()
    {
        int testNumber = 7;
        Assert.AreEqual(13,CalculatorForVariousTasks.Fibonacci(testNumber));
    }
    
    [Test]
    public void FibonacciNegativTest()
    {
        Assert.AreEqual(-1,CalculatorForVariousTasks.Fibonacci(-9));
    }
    
    [Test]
    public void CurrentStrengthOnTheCircuitTest()
    {
        int testVoltage = 14 ;
        int testResistance = 7;
        Assert.AreEqual("Current strengt is : 2",CalculatorForVariousTasks.CurrentStrengthOnTheCircuit(testVoltage,testResistance));
    }
    
    [Test]
    public void CurrentStrengthOnTheCircuitNegativeTest()
    {
        int testVoltage = 70 ;
        int testResistance = -35;
        Assert.AreEqual("The resistance value is negative!",CalculatorForVariousTasks.CurrentStrengthOnTheCircuit(testVoltage,testResistance));
    }
}