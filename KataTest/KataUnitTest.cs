using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class KataTest
{
    [TestMethod]
    public void KataTests()
    {
        //Assert.AreEqual("theStealthWarrior", Kata.ToCamelCase("the_stealth_warrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
        //Assert.AreEqual("TheStealthWarrior", Kata.ToCamelCase("The-Stealth-Warrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");

        //CollectionAssert.AreEqual(new long[] { 101, 103 }, Kata.Gap(2, 100, 110), "2, 100, 110");
        //CollectionAssert.AreEqual(new long[] { 103, 107 }, Kata.Gap(4, 100, 110), "4, 100, 110");
        //CollectionAssert.AreEqual(null, Kata.Gap(6, 100, 110), "6, 100, 110");
        //CollectionAssert.AreEqual(new long[] { 359, 367 }, Kata.Gap(8, 300, 400), "8, 300, 400");
        //CollectionAssert.AreEqual(new long[] { 337, 347 }, Kata.Gap(10, 300, 400), "10, 300, 400");

        //Assert.AreEqual("Battle Result: Evil eradicates all trace of Good", Kata.GoodVsEvil("1 1 1 1 1 1", "1 1 1 1 1 1 1"));
        //Assert.AreEqual("Battle Result: Good triumphs over Evil", Kata.GoodVsEvil("0 0 0 0 0 10", "0 1 1 1 1 0 0"));
        //Assert.AreEqual("Battle Result: No victor on this battle field", Kata.GoodVsEvil("1 0 0 0 0 0", "1 0 0 0 0 0 0"));

        //Assert.AreEqual(Kata.DblLinear(10), 22);
        //Assert.AreEqual(Kata.DblLinear(20), 57);
        //Assert.AreEqual(Kata.DblLinear(30), 91);
        //Assert.AreEqual(Kata.DblLinear(50), 175);
        //Assert.AreEqual(Kata.DblLinear(10000), 157654);
        //Assert.AreEqual(Kata.DblLinear(20000), 377625);
        //Assert.AreEqual(Kata.DblLinear(10000), 157654);
        //Assert.AreEqual(Kata.DblLinear(20000), 377625);

        var arr = new [] { 1, 2, 34, 4, 5, 5, 5, 65, 6, 65, 5454, 4 };
        Kata.WaveSort(arr);

    }
}

