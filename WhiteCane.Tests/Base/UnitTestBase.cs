using Bogus;
using Moq;
using Moq.AutoMock;

namespace WhiteCane.Tests.Base;

public class UnitTestBase<T> where T : class
{
    public UnitTestBase()
    {
        Faker = new Faker();
        Mocker = new AutoMocker(MockBehavior.Default, DefaultValue.Mock);
        SutMock = Mocker.GetMock<T>();
        Sut = SutMock.Object;
    }
    
    public T Sut { get; }
    public Mock<T> SutMock { get; }
    public AutoMocker Mocker { get; }
    public Faker Faker { get; }
}