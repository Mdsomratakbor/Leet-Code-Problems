using System.Linq;

public class SingleNumber
{
public int SingleNumberMethod(int[] nums) {
return nums.GroupBy(i => i).Where(g => g.Count() == 1).Select(g => g.Key).First();

}
}
