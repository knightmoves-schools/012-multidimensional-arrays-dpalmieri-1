namespace Tests;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Contain_A_Class_Level_Variable_Array_Named_Grouped_Numbers(){
        var group = new Groups();
        var groupNumbers = group.GroupedNumbers;
        Assert.True(groupNumbers != null);
    }

    [Fact]
    public void Should_Add_An_Array_Containing_1_3_5_To_Grouped_Numbers(){
        var group = new Groups();
        var groupNumbers = group.GroupedNumbers;
        Assert.True(groupNumbers.Length >= 3);
        Assert.True(groupNumbers.GetLength(0) >= 1);
        Assert.Equal(3, groupNumbers.GetLength(1));

        Assert.Equal(1, groupNumbers[0,0]);
        Assert.Equal(3, groupNumbers[0,1]);
        Assert.Equal(5, groupNumbers[0,2]);
    }

    [Fact]
    public void Should_Add_An_Array_Containing_2_4_6_To_Grouped_Numbers(){
        var group = new Groups();
        var groupNumbers = group.GroupedNumbers;
        Assert.Equal(6, groupNumbers.Length);
        Assert.Equal(2, groupNumbers.GetLength(0));
        Assert.Equal(3, groupNumbers.GetLength(1));

        Assert.Equal(2, groupNumbers[1,0]);
        Assert.Equal(4, groupNumbers[1,1]);
        Assert.Equal(6, groupNumbers[1,2]);
    }
}