using System;
using NSubstitute;
using NUnit.Framework;

[TestFixture]
public class FooTest
{
    [Test]
    public void Foo_Test()
    {
        var cloneable = Substitute.For<ICloneable>();
        
        Assert.That(cloneable, Is.Not.Null);
    }
}
