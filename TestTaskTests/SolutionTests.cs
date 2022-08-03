using TestTask;
namespace TestTaskTests;

public class SolutionTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void EqualsTest()
    {
        var result = new Solution().solution("cat", "cat");
        Assert.AreEqual(result, "EQUAL");
    }
    [Test]
    public void ImpossibleTest()
    {
        var result = new Solution().solution("o", "odd");
        Assert.AreEqual(result, "IMPOSSIBLE");
    }
    [Test]
    public void InsertTest()
    {
        var result = new Solution().solution("nice", "niece");
        Assert.AreEqual(result, "INSERT e");
    }
    [Test]
    public void InsertTest1()
    {
        var result = new Solution().solution("neie", "niece");
        Assert.AreEqual(result, "IMPOSSIBLE");
    }
    [Test]
    public void InsertTestTwo()
    {
        var result = new Solution().solution("aaa", "aaba");
        Assert.AreEqual(result, "INSERT b");
    }
    [Test]
    public void InsertTestThree()
    {
        var result = new Solution().solution("dsds", "dsdsz");
        Assert.AreEqual(result, "INSERT z");
    }
    [Test]
    public void ReplaceTest()
    {
        var result = new Solution().solution("test", "tent");
        Assert.AreEqual(result, "REPLACE s n");
    }
    [Test]
    public void SwapTest()
    {
        var result = new Solution().solution("form", "from");
        Assert.AreEqual(result, "SWAP o r");
    }
}
