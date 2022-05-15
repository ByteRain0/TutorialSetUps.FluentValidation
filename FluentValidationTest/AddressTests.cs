using FluentValidation.Infrastructure.Validators;
using FluentValidation.Models;
using FluentValidation.TestHelper;
using NUnit.Framework;

namespace FluentValidationTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var address = new Address()
        {
            City = "Test",
            Street = ""
        };
        var validator = new AddressValidator();
        var validationResult = validator.TestValidate(address);
        
        validationResult.ShouldHaveValidationErrorFor(x => x.UnstructuredAddress);
    }
}