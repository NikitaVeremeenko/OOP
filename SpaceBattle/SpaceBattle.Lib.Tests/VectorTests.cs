namespace SpaceBattle.Lib.Tests;

public class VectorTests
{
    [Fact]
    public void Vector_GetHashCode()
    {
        var arr = new int[] { 1, 5 };
        var test = new Vector(arr);
        Assert.Equal(arr.GetHashCode(), test.GetHashCode());
    }

    [Fact]
    public void Vector_Equals_PassNotVectorType()
    {
        var num = 2;
        var test = new Vector(new int[] { 1, 2 });
        Assert.True(!test.Equals(num));
    }
}
