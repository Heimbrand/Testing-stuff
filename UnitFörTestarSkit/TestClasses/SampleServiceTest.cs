using Moq;
using FakeItEasy;
using testarskit.Mock.Interfaces;
using testarskit.Repositories;

namespace UnitFörTestarSkit.TestClasses;

public class SampleServiceTest
{
    private readonly SampleService _service;
    private readonly IRepository _repo;

    public SampleServiceTest()
    {
        _repo = A.Fake<IRepository>();
        _service = new SampleService(_repo);
    }

    [Fact]
    public void Get_WithValidInput_ReturnsString()
    {
        // arrange
        int id = 1;
        string expected = "hej";

        A.CallTo(() => _repo.Get(id)).Returns(expected);

        // act
        string actual = _service.Get(id);

        // assert
        Assert.Equal(expected, actual);
        A.CallTo(() => _repo.Get(id)).MustHaveHappenedOnceExactly();
    }
}